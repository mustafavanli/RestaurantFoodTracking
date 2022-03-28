using AutoMapper;
using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Application.Interface.ElasticSearch;
using RestaurantFoodTracking.Application.Interface.Mongo;
using RestaurantFoodTracking.Application.Interface.Service;
using RestaurantFoodTracking.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Services
{
    public class ProductService: IProductService
    {
        private readonly IElasticSearchProductRepository elasticRepository;
        private readonly IProductRepository mongoRepository;
        private readonly IMapper mapper;

        public ProductService(IElasticSearchProductRepository elasticRepository, IProductRepository mongoRepository, IMapper mapper)
        {
            this.elasticRepository = elasticRepository;
            this.mongoRepository = mongoRepository;
            this.mapper = mapper;
        }

        public async Task<Response<Product>> Add(ProductAddDto productAddDto)
        {
            try
            {
                var entity = mapper.Map<Product>(productAddDto);
                var resultDb = await mongoRepository.AddAsync(entity);
                if (resultDb ==null)
                {
                    return Response<Product>.Fail("Ürün eklenemedi!");
                }
                var resultEs = await elasticRepository.AddAsync(resultDb);
                return Response<Product>.Success(resultEs);
            }
            catch (Exception)
            {
                return Response<Product>.Exception();
            }
        }

        public async Task<Response<List<Product>>> GeoFilter(double lan, double lon, int km)
        {
            try
            {

                var result = await elasticRepository.GeoFilter(lan, lon, km);
                return Response<List<Product>>.Success(result);
            }
            catch (Exception)
            {
                return Response<List<Product>>.Exception();
            }
        }
        public async Task<Response<List<Product>>> GetList()
        {
            try
            {
                var result = await elasticRepository.GetListAsync();
                return Response<List<Product>>.Success(result);
            }
            catch (Exception)
            {
                return Response<List<Product>>.Exception();
            }
        }
    }
}
