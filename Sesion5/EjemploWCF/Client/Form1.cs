using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proxy.ProductsServiceClient Proxy = new
                Proxy.ProductsServiceClient("HTTP_EndPoint");
            int prodID = 1;
            int stockLevel = Proxy.GetStockLevel(prodID);
            MessageBox.Show(stockLevel.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proxy.ProductsServiceClient Proxy = new
              Proxy.ProductsServiceClient("HTTP_EndPoint");
            dataGridView1.DataSource = Proxy.GetProductsList();

        }
    }
}
