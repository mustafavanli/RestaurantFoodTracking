﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using SerialSales.Application.Interface.ElasticSearch;
using SerialSales.Application.Interface.Mongo;
using SerialSales.Infrastructure.ElasticSearch.Repositories;
using SerialSales.Infrastructure.Mongo;
using SerialSales.Infrastructure.Mongo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection ServiceRegistrationInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var elasticSearchOptions = configuration.GetRequiredSection("ElasticSearchOptions").Get<ElasticSearchOptions>();
            var settings = new ConnectionSettings(new Uri($"{elasticSearchOptions.Hostname}:{elasticSearchOptions.Port.ToString()}"))
             .DefaultIndex("Defaultidx")
             .PrettyJson();
            var client = new ElasticClient(settings);
            services.AddSingleton<IElasticClient>(client);

            var mongoDbOptions = configuration.GetRequiredSection("MongoDbOptions").Get<MongoOptions>();




            return services;
        }
    }
}
