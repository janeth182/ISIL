using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Messaging;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Server
{
    //Interface del Servicio, Contrato
    [ServiceContract]
    interface IWork
    {
        [OperationContract(IsOneWay=true)]
        void Ejecuta(string mensaje);
    }
    //Implementacion del Servicio
    public class WorkService:IWork
    {
        public void Ejecuta(string mensaje)
        {
            Console.WriteLine("Se ejecuto: " + mensaje);
        }
    }
    //HOST Del Servicio
    class Program
    {
        static void Main(string[] args)
        {
            string qName = ConfigurationSettings.AppSettings["queueName"];
            if (! MessageQueue.Exists(qName))
                MessageQueue.Create(qName, true);

            using (ServiceHost host = new ServiceHost(typeof(WorkService)))
            {
                host.Open();
                Console.WriteLine("Servicio Listo....");
                Console.ReadLine();
            }
        }
    }
}
