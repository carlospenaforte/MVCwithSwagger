using MVCwithSwagger.Models;

namespace MVCwithSwagger.Services
{
    public interface IAuthorInterface
    {
        Task<ResponseModel<List<AuthorModel>>> ListofAuthors();
        Task<ResponseModel<AuthorModel>> SearchAuthorId(int id);
        Task<ResponseModel<AuthorModel>> SearchAuthorIdBook(int idBook);
    }
}
