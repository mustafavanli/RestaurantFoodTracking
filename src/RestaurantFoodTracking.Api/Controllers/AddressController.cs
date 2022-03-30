using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantFoodTracking.Application.Interface.Service;

namespace RestaurantFoodTracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService addressService;

        public AddressController(IAddressService addressService)
        {
            this.addressService = addressService;
        }


        //[HttpPost("Add")]
        //public async Task<IActionResult> Add()
        //{


        //}
    }
}
