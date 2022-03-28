using AutoMapper;
using SerialSales.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Dtos
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
            CreateMap<Product, ProductAddDto>().ReverseMap();
        }
    }
}
