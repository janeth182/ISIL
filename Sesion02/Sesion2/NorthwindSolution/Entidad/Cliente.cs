using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente
    {
        public string Nombre { get; set;  }
        public string Apellidos { get; set; }
        public DateTime Nacimiento { get; set; }

        public Cliente(string nombre,string apellido,DateTime nacimiento) 
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.Nacimiento = nacimiento;
        }
        public static List<Cliente> SelectAll() 
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente("Juan", "Mota", new DateTime(1990, 12, 2)));
            clientes.Add(new Cliente("Maria", "Perez", new DateTime(1990, 12, 2)));
            clientes.Add(new Cliente("Pedro", "Lopez", new DateTime(1990, 12, 2)));
            clientes.Add(new Cliente("Juana", "Vidal", new DateTime(1990, 12, 2)));

            return clientes;
        }

    }
}
