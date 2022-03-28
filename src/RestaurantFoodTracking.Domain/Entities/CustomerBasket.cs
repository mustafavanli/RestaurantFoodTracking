using RestaurantFoodTracking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Entities
{
    public class CustomerBasket:BaseEntity
    {
        public Guid UserId { get; set; }
        public List<BasketItem> BasketItems { get; set; }


    }
}
