using AutoMapper;
using RestaurantFoodTracking.Application.Dtos.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Dtos
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {

            CreateMap<Domain.Models.Customer, CustomerRegisterDto>().ReverseMap();
            CreateMap<Domain.Models.Customer, CustomerLoginDto>().ReverseMap();
            CreateMap<Domain.Models.Customer, CustomerProfileDto>().ReverseMap();
        }
    }
}
