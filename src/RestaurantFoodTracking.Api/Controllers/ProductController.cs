using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Application.Interface.Service;
using RestaurantFoodTracking.Domain.Entity;

namespace RestaurantFoodTracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(ProductAddDto productAddDto)
        {
            var result = await productService.Add(productAddDto);
            if (result.IsSuccess == true) return Ok(result);
            else return BadRequest(result);
        }
        [HttpGet("GetList")]
        public async Task<IActionResult> GetList()
        {
            var result = await productService.GetList();
            if (result.IsSuccess == true) return Ok(result);
            else return BadRequest(result);
        }
        [HttpGet("GeoFilter")]
        public async Task<IActionResult> GeoFilter(double lat,double lon,int km)
        {
            var result = await productService.GeoFilter(lat,lon,km);
            if (result.IsSuccess == true) return Ok(result);
            else return BadRequest(result);
        }

        //[HttpPut("Update")]
        //public async Task<IActionResult> Update(Product product)
        //{
        //    var result = await productService.Update(product);
        //    if (result.IsSuccess == true) return Ok(result);
        //    else return BadRequest(result);
        //}
        //[HttpDelete("Delete")]
        //public async Task<IActionResult> Delete([FromQuery]Guid id)
        //{
        //    var result = await productService.Delete(id);
        //    if (result.IsSuccess == true) return Ok(result);
        //    else return BadRequest(result);
        //}

    }
}
