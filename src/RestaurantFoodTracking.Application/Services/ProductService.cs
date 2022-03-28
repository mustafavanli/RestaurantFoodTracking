using AutoMapper;
using SerialSales.Application.Dtos;
using SerialSales.Application.Helpers;
using SerialSales.Application.Interface.ElasticSearch;
using SerialSales.Application.Interface.Mongo;
using SerialSales.Application.Interface.Service;
using SerialSales.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Services
{
    public class ProductService :GenericService<Product,ProductAddDto,ProductUpdateDto,IProductRepository,IElasticSearchProductRepository>,IProductService
    {
        private readonly IElasticSearchProductRepository elasticRepository;
        public ProductService(IMapper mapper, IElasticSearchProductRepository elasticRepository, IProductRepository mongoRepository) : base(mapper, elasticRepository, mongoRepository)
        {
            this.elasticRepository = elasticRepository;
        }

        public async Task<Response<List<Product>>> GeoFilter(double lan, double lon, int km)
        {
            var result = await elasticRepository.GeoFilter(lan,lon,km);
            return Response<List<Product>>.Success(result);
        }

    }
}
