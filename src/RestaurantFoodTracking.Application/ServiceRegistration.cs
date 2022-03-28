using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using SerialSales.Application.Dtos;
using SerialSales.Application.Interface.ElasticSearch;
using SerialSales.Application.Interface.Mongo;
using SerialSales.Application.Interface.Service;
using SerialSales.Application.Services;
using SerialSales.Domain.Entity;

namespace SerialSales.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection ServiceRegistrationApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(ServiceRegistration));

            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
