using RestaurantFoodTracking.Application.Dtos.ShopOwner;
using RestaurantFoodTracking.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Interface.Service
{
    public interface IShopOwnerService
    {
        Task<Response<ShopOwnerProfileDto>> Register(ShopOwnerRegisterDto shopOwnerRegisterDto);
        Task<Response<ShopOwnerProfileDto>> Login(ShopOwnerLoginDto shopOwnerRegisterDto);
        Task<Response<ShopOwnerProfileDto>> GetByProfile(Guid id);
    }
}
