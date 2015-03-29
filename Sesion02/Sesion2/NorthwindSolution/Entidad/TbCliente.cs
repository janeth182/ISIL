using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class TbCliente:EventArgs
    {
        public string CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public TbCliente(string codCliente,string nombre,string ruc) 
        {
            this.CodCliente = codCliente;
            this.Nombre = nombre;
            this.Ruc = ruc;
        }
        public static List<TbCliente> SelectAll() 
        {
            List<TbCliente> clientes = new List<TbCliente>();
            clientes.Add(new TbCliente("Juan", "Mota","20102121"));
            clientes.Add(new TbCliente("Maria", "Perez","10212121"));
            clientes.Add(new TbCliente("Pedro", "Lopez","1035565"));
            clientes.Add(new TbCliente("Juana", "Vidal","4646464644"));

            return clientes;
        }
    }
}
