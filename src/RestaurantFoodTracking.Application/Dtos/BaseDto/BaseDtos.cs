using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Dtos
{
    public abstract class AddDto
    {

    }
    public abstract class UpdateDto
    {
        public Guid Id { get; set; }
    }
}
