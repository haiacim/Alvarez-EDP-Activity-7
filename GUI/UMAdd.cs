using MySql.Data.MySqlClient;
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
    public partial class UMAdd : Form
    {
        public UMAdd()
        {
            InitializeComponent();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtFirstname.Text == "" ||
                txtLastname.Text == "" ||
                txtEmail.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            string connStr = "server=localhost;user=root;password=;database=activity3_db;";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "INSERT INTO users " +
                               "(username, password, firstname, lastname, email, is_active) " +
                               "VALUES " +
                               "(@username, @password, @firstname, @lastname, @email, @is_active)";

                MySqlCommand cmd = new MySqlCommand(query, conn);


                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);


                cmd.Parameters.AddWithValue("@is_active", true);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration Successful!");

                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirm.Clear();
                txtFirstname.Clear();
                txtLastname.Clear();
                txtEmail.Clear();

                txtUsername.Focus();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            UMView view = new UMView();
            view.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            UMAdd add = new UMAdd();
            add.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UMUpdate update = new UMUpdate();
            update.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
