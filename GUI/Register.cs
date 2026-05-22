using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing land = new Landing();
            land.Show();
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
