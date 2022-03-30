using RestaurantFoodTracking.Application.Dtos.Customer;
using RestaurantFoodTracking.Application.Interface.ElasticSearch;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Application.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantFoodTracking.Application.Interface;
using RestaurantFoodTracking.Application.Helpers.Hashing;
using AutoMapper;
using RestaurantFoodTracking.Domain.Models;

namespace RestaurantFoodTracking.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IMapper mapper;

        public CustomerService(IMapper mapper, ICustomerRepository customerRepository)
        {
            this.mapper = mapper;
            this.customerRepository = customerRepository;
        }

        public Task<Response<CustomerProfileDto>> GetByAddresses(CustomerLoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<CustomerProfileDto>> GetByProfile()
        {
            throw new NotImplementedException();
        }

        public async Task<Response<CustomerProfileDto>> Login(CustomerLoginDto loginDto)
        {
            var mailExits = await customerRepository.GetAsync(x=>x.Email == loginDto.Email);
            if (mailExits is null)
            {
                return Response<CustomerProfileDto>.Fail("Böyle bir kullanıcı yok");
            }
            CustomerProfileDto profileDto = mapper.Map<CustomerProfileDto>(mailExits);
            return Response<CustomerProfileDto>.Success(profileDto);
        }

        public async Task<Response<CustomerRegisterDto>> Register(CustomerRegisterDto registerDto)
        {
            if (registerDto.RePassword != registerDto.Password)
            {
                return Response<CustomerRegisterDto>.Fail("Şifreler uyuşmuyor!");
            }
            var mailExits = await customerRepository.GetAsync(x => x.Email == registerDto.Email);
            if (mailExits is not null)
            {
                return Response<CustomerRegisterDto>.Fail("Böyle bir kullanıcı zaten var");
            }
            else
            {
                Customer customer = mapper.Map<Customer>(registerDto);
                HashingHelper.CreatePasswordHash(registerDto.Password,out byte[] passwordHash,out byte[] passwordSalt);
                customer.PasswordHash = passwordHash;
                customer.PasswordSalt = passwordSalt;

                var result = await customerRepository.AddAsync(customer);
                if (result == null)
                {
                    return Response<CustomerRegisterDto>.Fail("Bir hata oluştu!");
                }


                return Response<CustomerRegisterDto>.Success(registerDto); // direk geri döndürüyorum
            }
        }

        public async Task<Response<CustomerProfileUpdateDto>> UpdateProfile(CustomerProfileUpdateDto profileDto)
        {
            var customer = await customerRepository.GetAsync(x => x.Id == profileDto.Id);
            if (customer is null)
            {
                return Response<CustomerProfileUpdateDto>.Fail("Böyle bir kullanıcı yok");
            }
            customer.BirthDay = profileDto.BirthDay;
            customer.Surname = profileDto.Surname;
            customer.FirstName = profileDto.FirstName;
            customer.Email = profileDto.Email;
            await customerRepository.UpdateAsync(customer);
            return Response<CustomerProfileUpdateDto>.Success(profileDto);
        }
    }
}
