using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente WCF
            Proxy.WorkClient wc = new Proxy.WorkClient("EndPoint_MSMQ");
            wc.Ejecuta("Saludos");


        }
    }
}
