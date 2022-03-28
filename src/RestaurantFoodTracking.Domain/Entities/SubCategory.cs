using RestaurantFoodTracking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Entity
{
    public class SubCategory : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}
