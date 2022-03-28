using SerialSales.Application.Dtos;
using SerialSales.Application.Helpers;
using SerialSales.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Interface.Service
{
    public interface IProductService:IGenericService<Product,ProductAddDto,ProductUpdateDto>
    {
        Task<Response<List<Product>>> GeoFilter(double lan,double lon,int km);

    }
}
