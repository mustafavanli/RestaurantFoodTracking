using RestaurantFoodTracking.Domain.Entity;
using RestaurantFoodTracking.Application.Interface.ElasticSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Interface.ElasticSearch
{
    public interface IElasticSearchCustomerRepository : IElasticSearchGenericRepository<Customer>
    {
    }
}
