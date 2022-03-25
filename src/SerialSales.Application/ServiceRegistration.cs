using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using SerialSales.Application.Dtos;
using SerialSales.Application.Interface.ElasticSearch;
using SerialSales.Domain.Entity;

namespace SerialSales.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection ServiceRegistrationApplication(this IServiceCollection services, IConfiguration configuration)
        {


            return services;
        }
    }
}
