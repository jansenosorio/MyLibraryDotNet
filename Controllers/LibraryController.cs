using Microsoft.AspNetCore.Mvc;

namespace MyLibraryDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create()
        {
            
            return Ok("Book created!");
        }

    }
}
