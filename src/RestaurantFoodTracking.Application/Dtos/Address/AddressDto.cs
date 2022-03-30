using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Dtos.Address
{
    public class AddressAddDto
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class AddressGetDto
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
    }
}
