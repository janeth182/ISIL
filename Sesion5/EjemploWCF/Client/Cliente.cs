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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client.Products.FrmListProd frmprodu = new Client.Products.FrmListProd();
            frmprodu.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client.Products.FrmStockProdu frmprodu = new Client.Products.FrmStockProdu();
            frmprodu.Show();
        }
    }
}
