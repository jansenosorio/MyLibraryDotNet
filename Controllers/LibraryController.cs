using Microsoft.AspNetCore.Mvc;

namespace MyLibraryDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(Book),StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] Book request)
        {
            var bookName = request;
            
            return Ok("Book created!");
        }

    }
}
