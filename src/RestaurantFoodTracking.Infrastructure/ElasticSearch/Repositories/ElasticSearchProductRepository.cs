using AutoMapper;
using Nest;
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
    public class ElasticSearchProductRepository : ElasticSearchGenericRepository<Product>, IElasticSearchProductRepository
    {
        public override string IndexName => "product";
        private readonly IElasticClient client;
        public ElasticSearchProductRepository(IElasticClient client, IMapper mapper) : base(client, mapper)
        {
            this.client = client;
        }
        public async Task<List<Product>> GeoFilter(double lat, double lon, int km)
        {
            try
            {
                var result = await client.SearchAsync<Product>(s => s.Query(q => q.GeoDistance(geo => geo.DistanceType(GeoDistanceType.Plane).Distance(Distance.Kilometers(km)).Location(lat, lon))));
            
                
                return result.Documents.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
