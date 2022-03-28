using RestaurantFoodTracking.Application.Dtos.Customer;
using RestaurantFoodTracking.Application.Interface.ElasticSearch;
using RestaurantFoodTracking.Application.Helpers;
using RestaurantFoodTracking.Application.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantFoodTracking.Application.Interface;

namespace RestaurantFoodTracking.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IElasticSearchCustomerRepository elasticSearchCustomerRepository;
        private readonly ICustomerRepository customerRepository;

        public CustomerService(IElasticSearchCustomerRepository elasticSearchCustomerRepository, ICustomerRepository customerRepository)
        {
            this.elasticSearchCustomerRepository = elasticSearchCustomerRepository;
            this.customerRepository = customerRepository;
        }

        public Task<Response<CustomerRegisterDto>> Login(CustomerRegisterDto registerDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<CustomerRegisterDto>> Register(CustomerRegisterDto registerDto)
        {
            throw new NotImplementedException();

        }
    }
}
