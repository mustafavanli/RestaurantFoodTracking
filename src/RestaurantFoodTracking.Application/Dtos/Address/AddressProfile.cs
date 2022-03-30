using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Dtos.Address
{
    public class AddressProfile:Profile
    {
        public AddressProfile()
        {
            CreateMap<Domain.Models.Address, AddressGetDto>().ReverseMap();
            CreateMap<Domain.Models.Address, AddressAddDto>().ReverseMap();
        }
    }
}
