using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Helpers.IdentityService
{
    public interface ISharedIdentityService
    {
        Guid GetShopId { get; }
        Guid GetCustomerId { get; }
        Guid GetUserRoleId { get; }
        string GetUserName { get; }
        string GetUserMail { get; }
        string GetUserRole { get; }
    }
}
