using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantFoodTracking.Application.Dtos.Customer;
using RestaurantFoodTracking.Application.Interface.Service;

namespace RestaurantFoodTracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(CustomerRegisterDto regiterDto)
        {
            var result = await customerService.Register(regiterDto);
            if(result.IsSuccess== true) return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Register(CustomerLoginDto loginDto)
        {
            var result = await customerService.Login(loginDto);
            if (result.IsSuccess == true) return Ok(result);
            return BadRequest(result);
        }
        [HttpPut("UpdateProfile")]
        public async Task<IActionResult> UpdateProfile(CustomerProfileUpdateDto profileUpdateDto)
        {
            var result = await customerService.UpdateProfile(profileUpdateDto);
            if (result.IsSuccess == true) return Ok(result);
            return BadRequest(result);
        }
    }
}
