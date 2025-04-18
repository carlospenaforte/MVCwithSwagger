﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCwithSwagger.DTO;
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

        [HttpGet("SearchAuthorId/{idAuthor}")]
        public async Task<ActionResult<ResponseModel<AuthorModel>>> SearchAuthorId(int idAuthor)
        {
            var author = await _authorInterface.SearchAuthorId(idAuthor);
            return Ok(author);
        }

        [HttpGet("SearchAuthorIdBook/{idBook}")]
        public async Task<ActionResult<ResponseModel<AuthorModel>>> SearchAuthorIdBook(int idBook)
        {
            var author = await _authorInterface.SearchAuthorIdBook(idBook);
            return Ok(author);
        }

        [HttpPost("AddAuthor")]
        public async Task<ActionResult<ResponseModel<AuthorModel>>> AddAuthor(AuthorCreationDto authorCreationDto)
        {
            var authors = await _authorInterface.AddAuhor(authorCreationDto);
            return Ok(authors);
        }
    }
}
