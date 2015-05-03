using NorthWind.DAO;
using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Logic
{
    public class ClienteBL
    {
        public static List<TbClienteBE> SelectAll()
        {
            return TbClienteDAO.SelectAll();
        }
    }
}
