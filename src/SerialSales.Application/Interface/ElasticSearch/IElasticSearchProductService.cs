﻿using SerialSales.Application.Dtos;
using SerialSales.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Interface.ElasticSearch
{
    public interface IElasticSearchProductService : IElasticSearchGenericRepository<Product, ProductAddDto, ProductUpdateDto>
    {
    }
}