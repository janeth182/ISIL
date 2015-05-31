using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace NorthWind.DAO
{
    public class TbClienteDAO
    {
        
        //public static List<TbClienteBE> SelectAll()
        //{
        //    string ConnectionString =
        //        ConfigurationManager.ConnectionStrings["NorthWind"].ToString();
        //    string sql = "Select  CodCliente, Nombre, Ruc from TbCliente";
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            command.CommandType = CommandType.Text;
        //            List<TbClienteBE> Clientes = new List<TbClienteBE>();
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    TbClienteBE objCliente = new TbClienteBE();
        //                    objCliente.CodCliente =Convert.ToString( reader.GetDecimal(0));
        //                    objCliente.Nombre = reader.GetString(1);
        //                    objCliente.Ruc = reader.GetString(2);
        //                    Clientes.Add(objCliente);
        //                }
        //            }
        //            return Clientes;
        //        }
        //    }
        //}

        //CON ENTERPRISE 
        public static List<TbClienteBE> SelectAll()
        {
            Database db = EnterpriseLibraryContainer.Current.GetInstance<Database>("NW");
            string sql = "Select  CodCliente, Nombre, Ruc from TbCliente";
            List<TbClienteBE> clientes=new List<TbClienteBE>();
            using (IDataReader dataReader = db.ExecuteReader(CommandType.Text,sql)) 
            {
                while (dataReader.Read()) { 
                TbClienteBE objTbClienteBE=new TbClienteBE();
                objTbClienteBE.CodCliente=Convert.ToString(dataReader.GetDecimal(0));
                objTbClienteBE.Nombre=dataReader.GetString(1);
                objTbClienteBE.Ruc=dataReader.GetString(2);
                clientes.Add(objTbClienteBE);
                }
                
                }
            return clientes;
            }
      
          
        }
    
}
