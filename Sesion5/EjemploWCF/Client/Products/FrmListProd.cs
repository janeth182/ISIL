using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Products
{
    public partial class FrmListProd : Form
    {
        public FrmListProd()
        {
            InitializeComponent();
        }

        private void FrmListProd_Load(object sender, EventArgs e)
        {
            Proxy.ProductsServiceClient Proxy = new
              Proxy.ProductsServiceClient("HTTP_EndPoint");
            dataGridView1.DataSource = Proxy.GetProductsList();
        }
    }
}
