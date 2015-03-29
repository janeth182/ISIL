using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
namespace NorthWind.Win
{
    public partial class FrmProducto : Form
    {
        
        List<TbProductosBE> Lista = new List<TbProductosBE>();
        public event EventHandler<TbProductosBE> onProductoSeleccionado;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Lista = TbProductosBE.SelecctAll();
            ProductosbindingSource1.DataSource = Lista;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AgregarProductoFactura()
        {
            int i = dataGridView1.CurrentRow.Index;
            string codigoProducto = dataGridView1.Rows[i].Cells[0].Value.ToString();
            TbProductosBE oTbProductosBE = (from item in Lista.ToArray()
                                    where item.CodProducto == codigoProducto
                                    select item).Single();
            onProductoSeleccionado(new object(), oTbProductosBE);
            this.Close();

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                AgregarProductoFactura();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProductoFactura();
        }
    }
}
