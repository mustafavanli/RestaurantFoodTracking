using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Dtos.Customer
{
    public class CustomerRegisterDto
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public string? CurrentCity { get; set; }
        public string? CurrentDistrict { get; set; }
        public GeoLocation? CurrentGeoLocation { get; set; }
    }
    public class CustomerLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
