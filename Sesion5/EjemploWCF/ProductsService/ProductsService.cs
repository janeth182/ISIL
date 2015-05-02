using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace ProductsService
{    
    //Implementacion del Servicio
    public class ProductsService : IProductsService //Como ?
    {
        public List<Product> GetProductsList()
        {
            var productList = from p in XElement.Load("Products.xml").Elements()
                              select new Product
                              {
                                  ProductID = int.Parse(p.Attribute("ProductID").Value),
                                  ProductName = p.Element("ProductName").Value,
                                  UnitPrice = double.Parse(p.Element("UnitPrice").Value),
                                  StockLevel = int.Parse(p.Element("StockLevel").Value),
                                  Category = p.Element("Category").Value
                              };

            return productList.ToList();
        }

        public List<Product> GetProductByCategory(string CategoryName)
        {
            var productList = from p in XElement.Load("Products.xml").Elements()
                              where p.Element("Category").Value == CategoryName
                              select new Product
                              {
                                  ProductID = int.Parse(p.Attribute("ProductID").Value),
                                  ProductName = p.Element("ProductName").Value,
                                  UnitPrice = double.Parse(p.Element("UnitPrice").Value),
                                  StockLevel = int.Parse(p.Element("StockLevel").Value),
                                  Category = p.Element("Category").Value
                              };

            return productList.ToList();
        }

        public Product GetProduct(int ProductID)
        {
            Product prod = (
                     from p in XElement.Load("Products.xml").Elements()
                     where p.Attribute("ProductID").Value == ProductID.ToString()
                     select new Product
                     {
                         ProductID = int.Parse(p.Attribute("ProductID").Value),
                         ProductName = p.Element("ProductName").Value,
                         UnitPrice = double.Parse(p.Element("UnitPrice").Value),
                         StockLevel = int.Parse(p.Element("StockLevel").Value),
                         Category = p.Element("Category").Value
                     }
                     ).FirstOrDefault();
            return prod;
        }

        public int GetStockLevel(int ProductID)
        {
            int stockLevel =
                     (
                     from p in XElement.Load("Products.xml").Elements()
                     where p.Attribute("ProductID").Value == ProductID.ToString()
                     select int.Parse(p.Element("StockLevel").Value)
                     ).FirstOrDefault();

            return stockLevel;
        }
        public List<Product> GetProductsListID()
        {
            var productList = from p in XElement.Load("Products.xml").Elements()
                              select new Product
                              {
                                  ProductID = int.Parse(p.Attribute("ProductID").Value),
                                  ProductName = p.Element("ProductName").Value,
                              };

            return productList.ToList();
        }
    }
}
