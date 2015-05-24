﻿using Northwind.Logic;
using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.Win
{
    public partial class frmCliente : Form
    {
        public event EventHandler<TbClienteBE> onClienteSeleccionado;


        List<TbClienteBE> Lista = new List<TbClienteBE>();

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //Lista = ClienteBL.SelectAll();
             //ProxyMantenimiento.Service1Client proxy = new ProxyMantenimiento.Service1Client("HTTP_EndPoint");
            //ServiceWCF.Service1Client proxy = new ServiceWCF.Service1Client();
            IISService.Service1Client proxy = new IISService.Service1Client();
            //Lista = proxy.SelectAllClients;
            TbClientebindingSource.DataSource = proxy.SelectAllClients();
            this.dataGridView1.SelectionMode = 
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void AgregarClienteaFactura()
        {
            int  i = dataGridView1.CurrentRow.Index;
            string codigocliente =  dataGridView1.Rows[i].Cells[0].Value.ToString();
            TbClienteBE oCliente = (from item in Lista.ToArray()
                                    where item.CodCliente == codigocliente
                                    select item).Single();
            onClienteSeleccionado(new object () ,oCliente);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarClienteaFactura();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Return)
            {
                AgregarClienteaFactura();
            }

        }

    }
}
