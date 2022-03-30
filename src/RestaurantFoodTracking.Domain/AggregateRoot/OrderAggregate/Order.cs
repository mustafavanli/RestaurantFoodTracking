using RestaurantFoodTracking.Domain.Enums;
using RestaurantFoodTracking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Models
{
    public class Order:BaseEntity,IAggregateRoot
    {
        public Order(Guid userId, OrderState orderState)
        {
            UserId = userId;
            OrderState = orderState;
        }

        public Guid UserId { get; set; }
        public OrderState OrderState { get; set; }
        public Address Address { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public void AddOrderItem(Guid productId, string pictureUrl, string name, double price, int quantity)
        {
            OrderItems.Add(new(productId,pictureUrl,name,price,quantity));
        }
    }
}
