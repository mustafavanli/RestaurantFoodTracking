using RestaurantFoodTracking.Application.Dtos.ShopOwner;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Application.Interface.Mongo;
using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Infrastructure.Mongo.Repositories
{
    public class ShopOwnerRepository : GenericRepository<ShopOwner>, IShopOwnerRepository
    {
        public ShopOwnerRepository(MongoOptions options) : base(options)
        {
        }
    }
}
