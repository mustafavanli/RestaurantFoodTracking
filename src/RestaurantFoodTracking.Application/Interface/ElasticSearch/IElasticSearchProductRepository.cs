using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Interface.ElasticSearch
{
    public interface IElasticSearchProductRepository:IElasticSearchGenericRepository<Product>
    {
        public Task<List<Product>> GeoFilter(double lat, double lon, int km);
    }
}
