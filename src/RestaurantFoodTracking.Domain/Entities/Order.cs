using RestaurantFoodTracking.Domain.Enums;
using RestaurantFoodTracking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Entities
{
    public class Order:BaseEntity
    {
        public Guid UserId { get; set; }
        public OrderState OrderState { get; set; }
    }
}
