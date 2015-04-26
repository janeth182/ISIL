using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProductsService
{
    [DataContract] 
    public class Product
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public double UnitPrice { get; set; }
        [DataMember]
        public int StockLevel { get; set; }
        [DataMember]
        public string Category { get; set; }
    }
}
