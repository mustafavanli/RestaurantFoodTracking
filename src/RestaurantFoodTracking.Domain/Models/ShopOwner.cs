using Nest;
using RestaurantFoodTracking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Models
{
    public class ShopOwner:BaseEntity
    {
        public string ShopName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentDistrict { get; set; }
        public GeoLocation CurrentGeoLocation { get; set; }
        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public bool IsOpen { get; set; } = false;
    }
}
