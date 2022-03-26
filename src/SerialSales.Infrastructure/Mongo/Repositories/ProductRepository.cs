using AutoMapper;
using SerialSales.Application.Dtos;
using SerialSales.Application.Interface.Mongo;
using SerialSales.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Infrastructure.Mongo.Repositories
{
    public class ProductRepository : GenericRepository<Product, ProductAddDto, ProductUpdateDto>,IProductRepository
    {
        public ProductRepository(MongoOptions options, IMapper mapper) : base(options, mapper)
        {
        }
    }
}
