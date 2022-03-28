using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Entity
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public string? CurrentCity { get; set; }
        public string? CurrentDistrict { get; set; }
        public GeoLocation? CurrentGeoLocation { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
