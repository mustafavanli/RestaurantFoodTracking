using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Dtos.Basket
{
    public class BasketAddDto
    {
        public Guid ShopId { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        public bool IsThere { get; set; }
    }
    public class BasketItemDto
    {
        public Guid ShopId { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public string Quantity { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }
    }
    public class BasketGetByUserDto
    {
       List<BasketItemDto> basketItemDtos = new List<BasketItemDto>();
       
    }
    public class BasketGetDto
    {


    }
}
