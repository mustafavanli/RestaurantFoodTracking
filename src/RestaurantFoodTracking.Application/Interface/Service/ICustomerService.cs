using RestaurantFoodTracking.Application.Dtos.Customer;
using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Interface.Service
{
    public interface ICustomerService
    {
        Task<Response<CustomerRegisterDto>> Register(CustomerRegisterDto registerDto);
        Task<Response<CustomerProfileDto>> Login(CustomerLoginDto loginDto);
        Task<Response<CustomerProfileDto>> GetByProfile();
        Task<Response<CustomerProfileDto>> GetByAddresses(CustomerLoginDto loginDto);
        Task<Response<CustomerProfileUpdateDto>> UpdateProfile(CustomerProfileUpdateDto loginDto);
    }
}
