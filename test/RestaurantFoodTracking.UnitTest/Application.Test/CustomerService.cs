using NUnit.Framework;
using RestaurantFoodTracking.Application.Dtos.Customer;
using RestaurantFoodTracking.Application.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.UnitTest.Application.Test
{
    public class CustomerService
    {
        private readonly ICustomerService customerService;
        public CustomerService(ICustomerService customerService)
        {

        }

        [Test]
        public async Task CustomerRegister()
        {
            CustomerRegisterDto customerRegisterDto = new CustomerRegisterDto()
            {
                Email = "test@gmail.com",
                Surname = "test",
                BirthDay = DateTime.UtcNow,
                CurrentCity = "İstanbul", // or nullable
                CurrentGeoLocation=new Nest.GeoLocation(24,25),
                FirstName = "test",
                Password = "test",
                RePassword = "test"

            };
            var result = await customerService.Register(customerRegisterDto);
            Assert.Equals(result,null);
        }
    }
}
