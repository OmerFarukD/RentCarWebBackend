using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        IColourService _colourService;
        public ColoursController(IColourService service)
        {
            _colourService = service;
        }
        [HttpPost("AddColours")]
        public IActionResult AddColour(Colour colour)
        {
            var result = _colourService.Add(colour);
            if (!result.Success)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpGet("GetAllColours")]
        public IActionResult GetAllColours()
        {
            var result = _colourService.GetAllColours();

            if (!result.Success)
            {
                return BadRequest();
            }
            return Ok(result.Data);
        }
        [HttpPost("RemoveColour")]
        public IActionResult RemoveColour(Colour colour)
        {
            var result = _colourService.RemoveColour(colour);
            if (!result.Success)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
