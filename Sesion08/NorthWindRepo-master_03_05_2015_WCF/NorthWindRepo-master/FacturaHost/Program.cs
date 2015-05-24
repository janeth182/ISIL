using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Messaging;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FacturaHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string qName = ConfigurationSettings.AppSettings["queueName"];
            //if (!MessageQueue.Exists(qName))
            //    MessageQueue.Create(qName, true);

            //using (ServiceHost host = new ServiceHost(typeof(FacturaService.Service1)))
            //{
            //    host.Open();
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("Servicio Factura Online");
            //    Console.ReadLine();
            //}
        }
    }
}
