using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantFoodTracking.Application.Dtos.ShopOwner;
using RestaurantFoodTracking.Application.Helpers.IdentityService;
using RestaurantFoodTracking.Application.Interface.Mongo;
using RestaurantFoodTracking.Application.Interface.Service;

namespace RestaurantFoodTracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopOwnerController : ControllerBase
    {
        private readonly IShopOwnerService shopOwnerRepository;
        private readonly ISharedIdentityService sharedIdentityService;

        public ShopOwnerController(IShopOwnerService shopOwnerRepository, ISharedIdentityService sharedIdentityService)
        {
            this.shopOwnerRepository = shopOwnerRepository;
            this.sharedIdentityService = sharedIdentityService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(ShopOwnerRegisterDto registerDto)
        {
            var result = await shopOwnerRepository.Register(registerDto);
            if (result.IsSuccess == true) return Ok(result);
            else return BadRequest(result);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(ShopOwnerLoginDto loginDto)
        {
            var result = await shopOwnerRepository.Login(loginDto);
            if (result.IsSuccess == true) return Ok(result);
            else return BadRequest(result);
        }
        [HttpPost("GetByProfile")]
        public async Task<IActionResult> GetByProfile()
        {
            var result = await shopOwnerRepository.GetByProfile(sharedIdentityService.GetShopId);
            if (result.IsSuccess == true) return Ok(result);
            else return BadRequest(result);
        }
    }
}
