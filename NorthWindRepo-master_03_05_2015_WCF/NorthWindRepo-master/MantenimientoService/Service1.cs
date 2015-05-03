using Northwind.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MantenimientoService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {

        public List<NorthWind.Entity.TbClienteBE> SelectAllClients()
        {
            return ClienteBL.SelectAll();
        }

        public List<NorthWind.Entity.TbProductoBE> SelectAllProducts()
        {
            return ProductoBL.SelectAll();
        }
    }
}
