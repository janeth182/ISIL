using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;


namespace Transaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejecutar3(1, 2, 2);
        }

        private void Ejecutar1(int creditProductID, 
                                             int debitProductID, 
                                             int stock)
        {
            SqlConnection con = null;
            bool result = false;
            string Cnx = 
                ConfigurationManager.ConnectionStrings["NorthWind"].ToString();
            string updateCommand =
                        @"BEGIN TRY
                            BEGIN TRANSACTION
                            update TbProducto set Stock = Stock -  {0} where CodProducto = {1}
                            update TbProducto set Stock = Stock + {2} where CodProducto = {3}
                            COMMIT TRANSACTION
                            END TRY
                            BEGIN CATCH
                                ROLLBACK TRANSACTION
                            END CATCH";
            try
            {
                con = new SqlConnection(Cnx);
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = string.Format (updateCommand,
                    stock, creditProductID,
                    stock, debitProductID);
                    result = cmd.ExecuteNonQuery() == 2;
                    MessageBox.Show("Se Eejcuto Transaccion");
                }              
            }
            finally
            {
                con.Close();
            }        

        }


        private void Ejecutar2(int creditProductID,
                                           int debitProductID,
                                           int stock)
        {
            bool debitresult = false;
            bool creditresult = false;
            SqlConnection con = null;

            string Cnx =
       ConfigurationManager.ConnectionStrings["NorthWind"].ToString();
            con = new SqlConnection(Cnx);
            SqlTransaction transaction = null;
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = string.Format(
                        "update TbProducto Set Stock=Stock- {0} where CodProducto= {1}",
                         stock, debitProductID);
                    cmd.Transaction = transaction;
                    debitresult = cmd.ExecuteNonQuery() == 1;
                }

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = string.Format(
                        "update TbProducto Set Stock=Stock + {0} where CodProducto= {1}",
                         stock, debitProductID);
                    cmd.Transaction = transaction;
                    debitresult = cmd.ExecuteNonQuery() == 1;
                }

                if (debitresult && creditresult)
                {
                    transaction.Commit();
                }

            }
            catch (Exception)
            {
                transaction.Rollback();
            }
            finally
            {
                con.Close();
            }

        }


        private void Ejecutar3(int creditProductID,
                                          int debitProductID,
                                          int stock)
        {
            
            bool debitResult = false;
            bool creditResult = false;            
            string Cnx =
     ConfigurationManager.ConnectionStrings["NorthWind"].ToString();            
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    using (SqlConnection con = new SqlConnection(Cnx))
                    {
                        con.Open();                        
                      
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = string.Format(
                                "update TbProducto set Stock = Stock - {0} where CodProducto = {1}",
                                stock, debitProductID);

                            debitResult = cmd.ExecuteNonQuery() == 1;
                            
                        }                      
                       
                        
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = string.Format(
                                "update TbProducto set Stock = Stock + {0} where CodProducto  = {1}",
                                stock, creditProductID);
                            creditResult = cmd.ExecuteNonQuery() == 1;
                        }

                        if (debitResult && creditResult)
                        {                            
                            ts.Complete();
                            MessageBox.Show("Se Completo la Transaccion");
                        }
                    }
                }
            }
            catch
            {
                
            }  
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
            
    }
}
