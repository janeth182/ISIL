using Northwind.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FacturaService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public void GuardarDocumento(NorthWind.Entity.DocumentoBE oDocumentoDTO)
        {
            DocumentoBL documento = new DocumentoBL();
            documento.GuardarDocumento(oDocumentoDTO);
        }
    }
}
