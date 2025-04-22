using Microsoft.AspNetCore.Mvc;
using MyLibraryDotNet.Communication.Responses;

namespace MyLibraryDotNet.Controllers
{
    public class LibraryController : MyLibraryBaseController
    {

        [HttpPost]
        [ProducesResponseType(typeof(CreateBookResponse),StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] Book request)
        {
            var newBook = new CreateBookResponse
            {
                Title = request.Title,
                Author = request.Author,
                Description = request.Description,
                Genre = request.Genre,
                Id = 999,
                Price = 99,
                QuantityAvailable = 1,
            };
            
            return Created("", newBook);
        }

    }
}
