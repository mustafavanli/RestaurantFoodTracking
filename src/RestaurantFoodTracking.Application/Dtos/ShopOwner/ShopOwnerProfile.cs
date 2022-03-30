using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Dtos.ShopOwner
{
    public class ShopOwnerProfile:Profile
    {
        public ShopOwnerProfile()
        {

            CreateMap<Domain.Models.ShopOwner, ShopOwnerProfileDto>().ReverseMap();
            CreateMap<Domain.Models.ShopOwner, ShopOwnerRegisterDto>().ReverseMap();
            CreateMap<Domain.Models.ShopOwner, ShopOwnerLoginDto>().ReverseMap();
        }
    }
}
