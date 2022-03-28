using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Infrastructure.ElasticSearch.Repositories
{
    public class ElasticSearchOptions
    {
        public string Hostname { get; set; }
        public int Port { get; set; }
    }
}
