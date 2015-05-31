using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductMaintenance
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime LastReviewed { get; set; }
    }
}
