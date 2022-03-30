using AutoMapper;
using RestaurantFoodTracking.Application.Dtos.ShopOwner;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Application.Helpers.Hashing;
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
    public class ShopOwnerService : IShopOwnerService
    {
        private readonly IElasticSearchShopOwnerRepository elasticSearchShopOwnerRepository;
        private readonly IShopOwnerRepository shopOwnerRepository;
        private readonly IMapper mapper;

        public ShopOwnerService(IElasticSearchShopOwnerRepository elasticSearchShopOwnerRepository, IShopOwnerRepository shopOwnerRepository,IMapper mapper)
        {
            this.elasticSearchShopOwnerRepository = elasticSearchShopOwnerRepository;
            this.shopOwnerRepository = shopOwnerRepository;
            this.mapper = mapper;
        }

        public async Task<Response<ShopOwnerProfileDto>> GetByProfile(Guid id)
        {
            var result = await elasticSearchShopOwnerRepository.GetByIdAsync(id);
            var profileDto = mapper.Map<ShopOwnerProfileDto>(result);
            return Response<ShopOwnerProfileDto>.Success(profileDto);
        }

        public async Task<Response<ShopOwnerProfileDto>> Login(ShopOwnerLoginDto shopOwnerRegisterDto)
        {
            var result = await shopOwnerRepository.GetAsync(x=>x.Email == shopOwnerRegisterDto.Email);
            if (result is not null)
            {
                return Response<ShopOwnerProfileDto>.Fail("Böyle bir emaile kayıtlı kullanıcı yok!");
            }
            // jwt
            var shopownerProfileDto = mapper.Map<ShopOwnerProfileDto>(result);
            return Response<ShopOwnerProfileDto>.Success(shopownerProfileDto);

        }

        public async Task<Response<ShopOwnerProfileDto>> Register(ShopOwnerRegisterDto shopOwnerRegisterDto)
        {
            var result = await shopOwnerRepository.GetAsync(x => x.Email == shopOwnerRegisterDto.Email);
            if (result is not null)
            {
                return Response<ShopOwnerProfileDto>.Fail("Böyle bir email ile kayıtlı kullanıcı var");
            }
            // jwt
            var shopOwnerEntity = mapper.Map<ShopOwner>(shopOwnerRegisterDto);
            HashingHelper.CreatePasswordHash(shopOwnerRegisterDto.Password, out byte[] passwordHash, out byte[] passwordSalt);
            shopOwnerEntity.PasswordHash = passwordHash;
            shopOwnerEntity.PasswordSalt = passwordSalt;

            var shopOwner = await shopOwnerRepository.AddAsync(shopOwnerEntity);
            await elasticSearchShopOwnerRepository.AddAsync(shopOwner);

            var profileDto = mapper.Map<ShopOwnerProfileDto>(shopOwnerEntity);
            return Response<ShopOwnerProfileDto>.Success(profileDto);
        }
    }
}
