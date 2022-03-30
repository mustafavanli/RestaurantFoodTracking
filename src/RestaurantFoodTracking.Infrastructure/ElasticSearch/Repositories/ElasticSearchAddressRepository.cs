using Nest;
using RestaurantFoodTracking.Application.Interface.ElasticSearch;
using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Infrastructure.ElasticSearch.Repositories
{
    public class ElasticSearchAddressRepository : ElasticSearchGenericRepository<Address>, IElasticSearchAddressRepository
    {
        public ElasticSearchAddressRepository(IElasticClient client) : base(client)
        {
        }

        public override string IndexName => "address";
    }
}
