using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DocumentoBE
    {
        public CabDocumentoBE Cabecera { get; set; }
        public List<ItemBE> Detalle { get; set; }

    }
}
