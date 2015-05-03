using NorthWind.DAO;
using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Logic
{
    public class ProductoBL
    {
        public static List<TbProductoBE> SelectAll()
        {
            return TbProductoDAO.SelectAll();
        }
    }
}
