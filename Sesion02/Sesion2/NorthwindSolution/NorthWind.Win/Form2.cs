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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<TbProductosBE> Producto = new List<TbProductosBE>();
        private void Form2_Load(object sender, EventArgs e)
        {
            ListarProductos();
            Producto = TbProductosBE.SelecctAll();
        }
        private void ListarProductos() {
            dataGridView1.DataSource = TbProductosBE.SelecctAll();
            
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Producto.Add(new TbProductosBE(textBox1.Text, textBox2.Text, Convert.ToDecimal(textBox3.Text)));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Producto;
                 
        }
    }
}
