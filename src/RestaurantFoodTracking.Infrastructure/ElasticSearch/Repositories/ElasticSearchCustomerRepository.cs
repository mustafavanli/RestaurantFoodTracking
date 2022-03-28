using AutoMapper;
using Nest;
using RestaurantFoodTracking.Application.Interface.ElasticSearch;
using RestaurantFoodTracking.Domain.Entity;
using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Application.Interface.ElasticSearch;
using RestaurantFoodTracking.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Infrastructure.ElasticSearch.Repositories
{
    public class ElasticSearchCustomerRepository : ElasticSearchGenericRepository<Customer>, IElasticSearchCustomerRepository
    {
        public override string IndexName => "customer";
        private readonly IElasticClient client;
        public ElasticSearchCustomerRepository(IElasticClient client, IMapper mapper) : base(client, mapper)
        {
            this.client = client;
        }
    }
}
