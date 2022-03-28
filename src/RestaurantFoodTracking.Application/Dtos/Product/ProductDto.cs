using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Dtos
{
    public class ProductAddDto:AddDto
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public int Views { get; set; }
        public int Favorites { get; set; }
        public double Price { get; set; }
    }
    public class ProductUpdateDto : Product
    {
    }
}
