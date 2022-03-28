using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Interface.Service
{
    public interface IProductService
    {
        Task<Response<List<Product>>> GeoFilter(double lan,double lon,int km);
        Task<Response<Product>> Add(ProductAddDto productAddDto);
        Task<Response<List<Product>>> GetList();
    }
}
