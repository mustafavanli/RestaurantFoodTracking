using RestaurantFoodTracking.Application.Dtos.Customer;
using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Domain.Entity;
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
        Task<Response<CustomerRegisterDto>> Login(CustomerRegisterDto registerDto);
    }
}
