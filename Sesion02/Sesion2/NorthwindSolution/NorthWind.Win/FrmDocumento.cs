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
    public partial class FrmDocumento : Form
    {
        public FrmDocumento()
        {
            InitializeComponent();
        }
        TbCliente OTbClienteTMP;
        TbProductosBE TbProductosBEtmp; 
        private void oFrmCliente_OnClienteSeleccionado(object sender,TbCliente e) {

            txtcliente.Text = e.Nombre;
            txtruc.Text = e.Ruc;
            OTbClienteTMP = e;

        }
        private void oFrmProducto_OnProductoSeleccionado(object sender, TbProductosBE e)
        {

            txtproducto.Text = e.Descripcion;
            txtprecio.Text =  e.Precio.ToString();
            TbProductosBEtmp = e;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente oFrmCliente = new FrmCliente();
            oFrmCliente.onClienteSeleccionado += new System.EventHandler<TbCliente>(oFrmCliente_OnClienteSeleccionado); 
            
            oFrmCliente.Show();
        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProducto oFrmProducto = new FrmProducto();
            oFrmProducto.onProductoSeleccionado += new System.EventHandler<TbProductosBE>(oFrmProducto_OnProductoSeleccionado);

            oFrmProducto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cliente;
            string ruc;
            cliente = txtcliente.Text;
            ruc = txtruc.Text;
            
        }
    }
}
