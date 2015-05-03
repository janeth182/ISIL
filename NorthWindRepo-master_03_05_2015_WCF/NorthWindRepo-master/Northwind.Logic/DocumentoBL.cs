using NorthWind.DAO;
using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Logic
{
    public class DocumentoBL
    {
        public void GuardarDocumento(DocumentoBE oDocumentoDTO)
        {
            TbDocumentoDAO documento = new TbDocumentoDAO();
            documento.GuardarDocumento(oDocumentoDTO);
        }
    }
}
