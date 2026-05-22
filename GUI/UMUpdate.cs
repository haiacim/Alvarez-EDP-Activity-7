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
    public partial class UMUpdate : Form
    {
        public UMUpdate()
        {
            InitializeComponent();
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (txtUserid.Text == "")
            {
                MessageBox.Show("Please enter User ID.");
                return;
            }
            if (txtUserid.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtFirstname.Text == "" ||
                txtLastname.Text == "" ||
                txtEmail.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "UPDATE users SET " +
                               "username = @username, " +
                               "password = @password, " +
                               "firstname = @firstname, " +
                               "lastname = @lastname, " +
                               "email = @email, " +
                               "is_active = @is_active " +
                               "WHERE user_id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtUserid.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                // radio button logic
                bool isActive = rbtnActivate.Checked;

                cmd.Parameters.AddWithValue("@is_active", isActive);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User updated successfully!");
                }
                else
                {
                    MessageBox.Show("User ID not found.");
                }
                txtUserid.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtFirstname.Clear();
                txtLastname.Clear();
                txtEmail.Clear();
                txtConfirm.Clear();

                rbtnActivate.Checked = true;
                rbtnDeactivate.Checked = false;

                txtUserid.Focus();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void txtUserid_TextChanged(object sender, EventArgs e)
        {
            if (txtUserid.Text == "")
                return;

            int userId;

            // 🚨 ensures valid number only
            if (!int.TryParse(txtUserid.Text, out userId))
                return;

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT * FROM users WHERE user_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtUsername.Text = reader["username"].ToString();
                    txtPassword.Text = reader["password"].ToString();
                    txtFirstname.Text = reader["firstname"].ToString();
                    txtLastname.Text = reader["lastname"].ToString();
                    txtEmail.Text = reader["email"].ToString();

                    bool isActive = Convert.ToInt32(reader["is_active"]) == 1;

                    rbtnActivate.Checked = isActive;
                    rbtnDeactivate.Checked = !isActive;
                }
                else
                {
                    
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtFirstname.Clear();
                    txtLastname.Clear();
                    txtEmail.Clear();

                    rbtnActivate.Checked = false;
                    rbtnDeactivate.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            UMView view = new UMView();
            view.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UMUpdate up = new UMUpdate();
            up.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            UMAdd add = new UMAdd();
            add.Show();
        }
     
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
