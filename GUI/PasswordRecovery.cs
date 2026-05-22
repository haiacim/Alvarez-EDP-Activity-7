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
    public partial class PasswordRecovery : Form
    {
        public PasswordRecovery()
        {
            InitializeComponent();
        }
        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtNewpassword.Text == "" || txtConfirm.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (txtNewpassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                // 1. Check if user exists
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@username", txtUsername.Text);

                int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (userExists == 0)
                {
                    MessageBox.Show("Username not found.");
                    conn.Close();
                    return;
                }

                // 2. Update password
                string updateQuery = "UPDATE users SET password = @password WHERE username = @username";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);

                updateCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                updateCmd.Parameters.AddWithValue("@password", txtNewpassword.Text);

                int rows = updateCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Password successfully updated!");

                    txtUsername.Clear();
                    txtNewpassword.Clear();
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Password update failed.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
