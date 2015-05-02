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
    public partial class FrmListProdID : Form
    {
        public FrmListProdID()
        {
            InitializeComponent();
        }

        private void FrmListProdID_Load(object sender, EventArgs e)
        {
            Proxy.ProductsServiceClient Proxy = new
             Proxy.ProductsServiceClient("HTTP_EndPoint");

            comboBox1.DataSource = Proxy.GetProductsList();
            comboBox1.ValueMember = "ProductID";
            comboBox1.DisplayMember = "ProductName";
        }
    }
}
