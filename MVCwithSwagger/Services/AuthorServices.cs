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

        public Task<ResponseModel<List<AuthorModel>>> ListofAuthors()
        {
            throw new NotImplementedException();
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
