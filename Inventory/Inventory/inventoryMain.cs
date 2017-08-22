using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class inventoryMain : Form
    {

        public inventoryMain()
        {
            InitializeComponent();
        }

        private void inventoryMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Products pro = new Products();
            pro.MdiParent = this; 
            pro.Show();
        }

    }
}
