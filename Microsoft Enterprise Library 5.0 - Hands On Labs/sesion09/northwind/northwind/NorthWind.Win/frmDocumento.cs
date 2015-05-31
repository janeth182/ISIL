using NorthWind.DAO;
using NorthWind.Entity;
using NorthWind.Win.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using System.Globalization;

namespace NorthWind.Win
{
    public partial class frmDocumento : Form
    {
        public frmDocumento()
        {
            InitializeComponent();
        }
        private Validator<ItemBE> ItemBEValidator;
        private void button1_Click(object sender, EventArgs e)
        {
            ValidatorFactory valFactory =
              EnterpriseLibraryContainer.Current.GetInstance<ValidatorFactory>();
            ItemBEValidator = valFactory.CreateValidator<ItemBE>();


            //Boton Seleccionar Cliente
            frmCliente oFrmCliente = new frmCliente();
            oFrmCliente.onClienteSeleccionado += new EventHandler<TbClienteBE>(
                oFrmCliente_OnClienteSeleccionado);
            oFrmCliente.Show();
        }

        TbClienteBE otmpCliente;
        void oFrmCliente_OnClienteSeleccionado(object sender, TbClienteBE e)
        {
            txtcliente.Text = e.Nombre;
            txtruc.Text = e.Ruc;
            otmpCliente = e;
        }

        TbProductoBE otmpProducto;
        void oFrmProducto_OnProductoSeleccionado(object sender, TbProductoBE e)
        {
            txtproducto.Text=e.Descripcion;
            txtprecio.Text=e.Precio;
            otmpProducto = e;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Boton Seleccionar Producto
            frmProducto oFrmProducto = new frmProducto();
            oFrmProducto.onProductoSeleccionado += new EventHandler<TbProductoBE>(
                oFrmProducto_OnProductoSeleccionado);
            oFrmProducto.Show();
        }

        DocumentoBL oFacturaBL = new DocumentoBL();
        private void button3_Click(object sender, EventArgs e)
        {
            
            //Boton Agregar a Factura
            ItemBE oItemBE=new ItemBE
            {
                Cantidad= Convert.ToInt32(txtcantidad.Text),
                Precio=Convert.ToDecimal(txtprecio.Text),
                Producto = otmpProducto
            };
            ValidationResults results = ItemBEValidator.Validate(oItemBE);
            if (!results.IsValid)
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("Customer is not valid:");
                foreach (ValidationResult result in results)
                {
                    builder.AppendLine(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            "{0}: {1}",
                            result.Key,
                            result.Message));
                }
                MessageBox.Show(
                    this,
                    builder.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else {
            oFacturaBL.AgregarDetalle(oItemBE);
            //Actualizar DataGrid
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = oFacturaBL.GetDetalle();

            txtsubtotal.Text = oFacturaBL.SubTotal.ToString();
            txtigv.Text = oFacturaBL.IGV.ToString();
            txttotal.Text = oFacturaBL.Total.ToString();
            
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }
    }
}
