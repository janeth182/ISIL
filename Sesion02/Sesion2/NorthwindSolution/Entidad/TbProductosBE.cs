using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class TbProductosBE
    {
        public string CodProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public TbProductosBE(string codProducto, string descripcion, decimal precio) {

            this.CodProducto = codProducto;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }

        public static List<TbProductosBE> SelecctAll() 
        {
            List<TbProductosBE> Productos = new List<TbProductosBE>();
            Productos.Add(new TbProductosBE("1","Pantalon",50));
            Productos.Add(new TbProductosBE("2", "Camisa", 60));
            Productos.Add(new TbProductosBE("3", "Short", 150));
            return Productos;

        }
    }
}
