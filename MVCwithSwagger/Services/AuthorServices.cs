using Microsoft.EntityFrameworkCore;
using MVCwithSwagger.Data;
using MVCwithSwagger.Models;

namespace MVCwithSwagger.Services
{
    public class AuthorServices : IAuthorInterface
    {
        private readonly AppDBContext _context;

        public AuthorServices(AppDBContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<List<AuthorModel>>> ListofAuthors()
        {
            ResponseModel<List<AuthorModel>> response = new ResponseModel<List<AuthorModel>>();
            try
            {
                var authors = await _context.Authors.ToListAsync();
                response.Data = authors;
                response.Message = "List of authors";

                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;

                return response;
            }
        }

        public async Task<ResponseModel<AuthorModel>> SearchAuthorId(int idAuthor)
        {
            ResponseModel<AuthorModel> response = new ResponseModel<AuthorModel>();
            try
            {
                var author = await _context.Authors.FirstOrDefaultAsync(authorData => authorData.Id == idAuthor);
                if (author == null)
                { 
                    response.Message = "Author not found";
                    return response;

                }
                response.Data = author;
                response.Message = "Author found";

                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;

            }
        }

        public async Task<ResponseModel<AuthorModel>> SearchAuthorIdBook(int idBook)
        {
            ResponseModel<AuthorModel> response = new ResponseModel<AuthorModel>();
            try
            {
                var book = await _context.Books
                    .Include(a => a.Author)
                    .FirstOrDefaultAsync(BookData => BookData.Id == idBook);

                if (book == null)
                {
                    response.Message = "Author not found";
                    return response;
                }
                response.Data = book.Author;
                response.Message = "Author found";
                return response;


            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;

                return response;
            }
        }
    }
}
