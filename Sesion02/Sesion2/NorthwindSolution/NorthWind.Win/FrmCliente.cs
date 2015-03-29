using Entidad;
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
    public partial class FrmCliente : Form
    {
        List<TbCliente> Lista = new List<TbCliente>();

        public event EventHandler<TbCliente> onClienteSeleccionado;
        
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Lista = TbCliente.SelectAll();
            TblClientebindingSource1.DataSource = Lista;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void AgregarClienteFactura() 
        {
            int i = dataGridView1.CurrentRow.Index;
            string codigoCliente =dataGridView1.Rows[i].Cells[0].Value.ToString();
            TbCliente oTbCliente = (from item in Lista.ToArray() where item.CodCliente==codigoCliente
                                        select item).Single();
            onClienteSeleccionado(new object(),oTbCliente);
            this.Close();
                                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarClienteFactura();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return) 
            {
                AgregarClienteFactura();
            }
        }
    }
}
