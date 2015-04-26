using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductsService
{    
    [ServiceContract] //Que?
    public interface IProductsService
    {
        [OperationContract]
        List<Product> GetProductsList();
        [OperationContract]
        List<Product> GetProductByCategory(string CategoryName);
        [OperationContract]
        Product GetProduct(int ProductID);
        [OperationContract]
        int GetStockLevel(int ProductID);        
    }
}
