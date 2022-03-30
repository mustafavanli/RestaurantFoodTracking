using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Helpers.IdentityService
{
    public class SharedIdentityService : ISharedIdentityService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SharedIdentityService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Guid GetCustomerId => Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value); 
        public Guid GetShopId => Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirst("RoleId").Value);
        public string GetUserMail => _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
        public string GetUserRole => _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role).Value;
        public string GetUserName => _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;

        public Guid GetUserRoleId => throw new NotImplementedException();
    }
}
