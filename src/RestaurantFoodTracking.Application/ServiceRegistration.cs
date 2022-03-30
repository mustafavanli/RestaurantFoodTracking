using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using RestaurantFoodTracking.Application.Dtos;
using RestaurantFoodTracking.Application.Interface.ElasticSearch;
using RestaurantFoodTracking.Application.Interface.Mongo;
using RestaurantFoodTracking.Application.Interface.Service;
using RestaurantFoodTracking.Application.Services;
using RestaurantFoodTracking.Domain.Models;

namespace RestaurantFoodTracking.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection ServiceRegistrationApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(ServiceRegistration));

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IShopOwnerService, ShopOwnerService>();
            services.AddScoped<IAddressService, AddressService>();


            return services;
        }
    }
}
