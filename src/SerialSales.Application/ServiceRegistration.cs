
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SerialSales.Application.Helpers.ElasticSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection ServiceRegistrationApplication(this IServiceCollection services,IConfiguration configuration)
        {
            var elasticSearchOptions = configuration.GetSection("ElasticSearchOptions") as ElasticSearchOptions;
            services.AddSingleton<ElasticSearchOptions>(elasticSearchOptions);



            return services;
        }
    }
}
