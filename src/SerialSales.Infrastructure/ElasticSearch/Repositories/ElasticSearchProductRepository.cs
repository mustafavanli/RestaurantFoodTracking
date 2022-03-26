using AutoMapper;
using Nest;
using SerialSales.Application.Dtos;
using SerialSales.Application.Interface.ElasticSearch;
using SerialSales.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Infrastructure.ElasticSearch.Repositories
{
    public class ElasticSearchProductRepository : ElasticSearchGenericRepository<Product, ProductAddDto, ProductUpdateDto>, IElasticSearchProductRepository
    {
        private readonly IElasticClient client;
        public ElasticSearchProductRepository(IElasticClient client, IMapper mapper) : base(client, mapper)
        {
            this.client = client;
        }
        public override string IndexName => "product";
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
