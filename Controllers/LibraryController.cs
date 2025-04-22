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

        [HttpGet]
        [ProducesResponseType(typeof(List<CreateBookResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            var books = new List<CreateBookResponse>
            {
                new() {
                    Title = "Book 1",
                    Author = "Author 1",
                    Description = "Description 1",
                    Genre = "Genre 1",
                    Id = 1,
                    Price = 10,
                    QuantityAvailable = 5,
                },
                new() {
                    Title = "Book 2",
                    Author = "Author 2",
                    Description = "Description 2",
                    Genre = "Genre 2",
                    Id = 2,
                    Price = 20,
                    QuantityAvailable = 3,
                }
            };

            return Ok(books);
        }
    }
}
