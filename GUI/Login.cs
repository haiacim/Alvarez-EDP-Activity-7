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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT * FROM users " +
                               "WHERE username = @username " +
                               "AND password = @password " +
                               "AND is_active = @is_active";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@is_active", true);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Session.Firstname = reader["firstname"].ToString();
                    MessageBox.Show("Login Successful!");

                    Session.Username = txtUsername.Text;
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing land = new Landing();
            land.Show();
        }
        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRecovery pr = new PasswordRecovery();
            pr.Show();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }
    }
}
