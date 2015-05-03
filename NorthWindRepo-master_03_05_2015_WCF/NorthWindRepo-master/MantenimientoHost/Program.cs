using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type serviceType = typeof(MantenimientoService.Service1);
            using (ServiceHost host = new ServiceHost(serviceType))
            {
                host.Open();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Servicio Mantemiento Online");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
