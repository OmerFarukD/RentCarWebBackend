using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpPost("AddBrand")]
        public IActionResult AddBrand(Brand brand)
        {
            var result = _brandService.AddBrand(brand);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
        [HttpGet("GetAllBrands")]
        public IActionResult GetAllBrands()
        {
            var result = _brandService.GetAllBrands();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
        [HttpGet("GetByBrandId")]
        public IActionResult GetByBrandId(int id)
        {
            var result = _brandService.GetByBrandId(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
        [HttpPost("DeleteBrand")]
        public IActionResult DeleteBrand(Brand brand)
        {
            var result = _brandService.DeleteBrand(brand);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
        [HttpPost("UpdateBrand")]
        public IActionResult UpdateBrand(Brand brand)
        {
            var result = _brandService.UpdateBrand(brand);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}
