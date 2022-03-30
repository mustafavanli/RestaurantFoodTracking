using RestaurantFoodTracking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Models
{
    public class BasketItem:BaseEntity
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; } // OldPrice
    }
}
