using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Interface.ElasticSearch
{
    public interface IElasticSearchAddressRepository : IElasticSearchGenericRepository<Address>
    {

    }
}
