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
    public partial class FrmStockProdu : Form
    {
        public FrmStockProdu()
        {
            InitializeComponent();
        }

        private void FrmStockProdu_Load(object sender, EventArgs e)
        {
            Proxy.ProductsServiceClient Proxy = new
              Proxy.ProductsServiceClient("HTTP_EndPoint");
            
            comboBox1.DataSource =Proxy.GetProductsList();
            comboBox1.ValueMember="ProductID";
            comboBox1.DisplayMember="ProductName";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proxy.ProductsServiceClient Proxy = new
               Proxy.ProductsServiceClient("HTTP_EndPoint");
            string prodID = comboBox1.SelectedValue.ToString();
            int stockLevel = Proxy.GetStockLevel(int.Parse(prodID));
            textBox1.Text = (stockLevel.ToString());
        }
    }
}
