using Nest;
using RestaurantFoodTracking.Domain.Base;
using RestaurantFoodTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Models
{
    public class Customer:BaseEntity,IAggregateRoot
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public string? CurrentCity { get; set; }
        public string? CurrentDistrict { get; set; }
        public GeoLocation? CurrentGeoLocation { get; set; }
        public List<Address>? Adresses { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
