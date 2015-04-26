using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceHostConsole
{
    //Host del Servicio
    class Program
    {
        static void Main(string[] args)
        {
            var  serviceType = typeof(ProductsService.ProductsService);
            using (ServiceHost host = new ServiceHost(serviceType))
            {
                host.Open();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Servicio Producto Online");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
