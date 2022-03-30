using RestaurantFoodTracking.Application.Dtos.ShopOwner;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Interface.Mongo
{
    public interface IShopOwnerRepository:IGenericRepository<ShopOwner>
    {
    }
}
