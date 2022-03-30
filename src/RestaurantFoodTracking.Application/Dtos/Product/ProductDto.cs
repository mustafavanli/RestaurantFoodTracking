using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Dtos
{
    public class ProductAddDto
    {
        public Guid CategoryId { get; set; }
        public Guid ShopId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class ProductUpdateDto
    {
    }
}
