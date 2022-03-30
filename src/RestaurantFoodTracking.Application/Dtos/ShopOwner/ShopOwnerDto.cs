using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Dtos.ShopOwner
{
    public class ShopOwnerRegisterDto
    {
        public string ShopName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentDistrict { get; set; }
        public GeoLocation? CurrentGeoLocation { get; set; }
    }
    public class ShopOwnerLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
    public class ShopOwnerProfileDto
    {
        public Guid Id { get; set; }
        public string ShopName { get; set; }
        public string Email { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentDistrict { get; set; }
        public GeoLocation? CurrentGeoLocation { get; set; }
    }
}
