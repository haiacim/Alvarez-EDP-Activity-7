using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }
        private void btnDP_Click(object sender, EventArgs e)
        {
            this.Hide();
            IMDelete delete = new IMDelete();
            delete.Show();
        }
        private void btnAP_Click(object sender, EventArgs e)
        {
            this.Hide();
            IMAdd add = new IMAdd();
            add.Show();
        }
        private void btnUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            IMUpdate update = new IMUpdate();
            update.Show();
        }
        private void txtDashboard_Click(object sender, EventArgs e)
        {

        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
