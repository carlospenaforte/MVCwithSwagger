using MVCwithSwagger.DTO;
using MVCwithSwagger.Models;

namespace MVCwithSwagger.Services
{
    public interface IAuthorInterface
    {
        // GET

        Task<ResponseModel<List<AuthorModel>>> ListofAuthors();
        Task<ResponseModel<AuthorModel>> SearchAuthorId(int id);
        Task<ResponseModel<AuthorModel>> SearchAuthorIdBook(int idBook);

        // POST

        Task<ResponseModel<AuthorModel>> AddAuhor(AuthorCreationDto authorCreationDto); // You need receive a model
    }
}
