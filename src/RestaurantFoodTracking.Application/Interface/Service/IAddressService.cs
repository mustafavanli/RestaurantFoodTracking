using RestaurantFoodTracking.Application.Dtos.Address;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Interface.Service
{
    public interface IAddressService
    {
        Task<Response<Address>> Add(AddressAddDto addDto);
        Task<Response<List<Address>>> GetList();
    }
}
