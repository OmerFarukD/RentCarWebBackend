using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpPost("AddCar")]
        public IActionResult AddCar(Car car)
        {
            var result = _carService.AddCar(car);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
        [HttpGet("GetAllCars")]
        public IActionResult GetAllCars()
        {
            var result = _carService.GetAllCars();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }
        [HttpGet("GetAllCarsByBrandId")]
        public IActionResult GetAllCarsByBrandId(int id)
        {
            var result = _carService.GetAllCarsByBrandId(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }
        [HttpGet("GetDetails")]
        public IActionResult GetDetails()
        {
            var result = _carService.GetDetails();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }
        [HttpPost("RemoveCar")]
        public IActionResult RemoveCar(Car car)
        {
            var result = _carService.RemoveCar(car);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
        [HttpPost("UpdateCar")]
        public IActionResult UpdateCar(Car car)
        {
            var result = _carService.RemoveCar(car);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}
