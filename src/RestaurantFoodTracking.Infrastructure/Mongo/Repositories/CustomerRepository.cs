using AutoMapper;
using RestaurantFoodTracking.Application.Dtos.Customer;
using RestaurantFoodTracking.Application.Interface;
using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Infrastructure.Mongo.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(MongoOptions options) : base(options)
        {
        }
    }
}
