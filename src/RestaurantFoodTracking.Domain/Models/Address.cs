using RestaurantFoodTracking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Models
{
    public class Address: BaseEntity
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
    }
}
