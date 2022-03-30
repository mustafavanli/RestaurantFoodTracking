using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using RestaurantFoodTracking.Application.Interface;
using RestaurantFoodTracking.Application.Interface.ElasticSearch;
using RestaurantFoodTracking.Application.Interface.Mongo;
using RestaurantFoodTracking.Infrastructure.ElasticSearch.Repositories;
using RestaurantFoodTracking.Infrastructure.Mongo;
using RestaurantFoodTracking.Infrastructure.Mongo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection ServiceRegistrationInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var elasticSearchOptions = configuration.GetRequiredSection("ElasticSearchOptions").Get<ElasticSearchOptions>();
            var settings = new ConnectionSettings(new Uri($"{elasticSearchOptions.Hostname}:{elasticSearchOptions.Port.ToString()}"))
             .DefaultIndex("defaultidx")
             .PrettyJson();
            var client = new ElasticClient(settings);
            services.AddSingleton<IElasticClient>(client);

            var mongoDbOptions = configuration.GetRequiredSection("MongoDbOptions").Get<MongoOptions>();
            services.AddSingleton<MongoOptions>(mongoDbOptions);


            RegisterElasticSearchRepository(services); 
            RegisterMongoRepository(services);
            return services;
        }

        public static IServiceCollection RegisterElasticSearchRepository(this IServiceCollection services)
        {

            services.AddScoped<IElasticSearchProductRepository, ElasticSearchProductRepository>();
            services.AddScoped<IElasticSearchShopOwnerRepository, ElasticSearchShopOwnerRepository>();
            services.AddScoped<IElasticSearchAddressRepository, ElasticSearchAddressRepository>();
            return services;
        }
        public static IServiceCollection RegisterMongoRepository(this IServiceCollection services)
        {

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IShopOwnerRepository, ShopOwnerRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();

            return services;
        }
    }
}
