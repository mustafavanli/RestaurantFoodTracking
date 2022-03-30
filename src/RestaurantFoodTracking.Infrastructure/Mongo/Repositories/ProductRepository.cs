using AutoMapper;
using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Application.Interface.Mongo;
using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Infrastructure.Mongo.Repositories
{
    public class ProductRepository : GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(MongoOptions options):base(options)
        {
        }
    }
}
