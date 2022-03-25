using SerialSales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Domain.Entity
{
    public class Product:BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public int Views { get; set; } = 0;
        public int Favorites { get; set; } = 0;
        public double Price { get; set; }
    }
}
