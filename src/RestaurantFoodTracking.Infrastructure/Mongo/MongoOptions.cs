using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Infrastructure.Mongo
{
    public class MongoOptions
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
