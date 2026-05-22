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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            txtWelcome.Text = "Welcome " + Session.Firstname + "!";
        }
        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            OrderManagement om = new OrderManagement();
            om.Show();
        }
        private void btnInventoryManagement(object sender, EventArgs e)
        {
            InventoryManagement im = new InventoryManagement();
            im.Show();
        }
        private void btnPaymentManagement_Click(object sender, EventArgs e)
        {
            PaymentManagement pm = new PaymentManagement();
            pm.Show();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportGeneration rg = new ReportGeneration();
            rg.Show();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void btnUM_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement UM = new UserManagement();
            UM.Show();
        }
        private void txtWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
