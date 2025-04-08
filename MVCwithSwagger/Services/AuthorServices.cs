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

        public Task<ResponseModel<AuthorModel>> SearchAuthorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AuthorModel>> SearchAuthorIdBook(int idBook)
        {
            throw new NotImplementedException();
        }
    }
}
