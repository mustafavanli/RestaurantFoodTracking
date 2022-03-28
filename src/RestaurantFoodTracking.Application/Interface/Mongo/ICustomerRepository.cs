using RestaurantFoodTracking.Application.Dtos.Customer;
using RestaurantFoodTracking.Application.Interface.Mongo;
using RestaurantFoodTracking.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Interface
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
    }
}
