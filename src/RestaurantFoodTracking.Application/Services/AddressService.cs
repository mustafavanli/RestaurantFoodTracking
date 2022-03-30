using AutoMapper;
using RestaurantFoodTracking.Application.Dtos.Address;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Application.Interface.ElasticSearch;
using RestaurantFoodTracking.Application.Interface.Mongo;
using RestaurantFoodTracking.Application.Interface.Service;
using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository addressRepository;
        private readonly IElasticSearchAddressRepository elasticSearchAddressRepository;
        private readonly IMapper mapper;

        public AddressService(IAddressRepository addressRepository, IElasticSearchAddressRepository elasticSearchAddressRepository, IMapper mapper)
        {
            this.addressRepository = addressRepository;
            this.elasticSearchAddressRepository = elasticSearchAddressRepository;
            this.mapper = mapper;
        }

        public async Task<Response<Address>> Add(AddressAddDto addDto)
        {
            var entity = mapper.Map<Address>(addDto);
            var result = await addressRepository.AddAsync(entity);
            if (result is null)
            {
                return Response<Address>.Fail("bir problem oluştu!");
            }
            await elasticSearchAddressRepository.AddAsync(result);
            return Response<Address>.Success(result);
        }

        public async Task<Response<List<Address>>> GetList()
        {
            // elastic
            return Response<List<Address>>.Success();
        }
    }
}
