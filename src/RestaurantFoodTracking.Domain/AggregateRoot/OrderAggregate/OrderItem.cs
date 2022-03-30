using RestaurantFoodTracking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Models
{
    public class OrderItem:BaseEntity
    {
        public OrderItem(Guid productId, string pictureUrl, string name, double price, int quantity)
        {
            ProductId = productId;
            PictureUrl = pictureUrl;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Guid ProductId { get; set; }
        public string PictureUrl { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
