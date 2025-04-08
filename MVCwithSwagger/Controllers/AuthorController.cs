using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCwithSwagger.Models;
using MVCwithSwagger.Services;

namespace MVCwithSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorInterface _authorInterface;

        public AuthorController(IAuthorInterface authorInterface)
        {
            _authorInterface = authorInterface;
        }

        [HttpGet("ListofAuthors")]
        public async Task<ActionResult<ResponseModel<List<AuthorModel>>>> ListAuthors()
        {
            var authors = await _authorInterface.ListofAuthors();

            return Ok(authors);
        }
    }
}
