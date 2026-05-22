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
    public partial class UMView : Form
    {
        public UMView()
        {
            InitializeComponent();
        }
        private void UMView_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT user_id, username, firstname, lastname, email, is_active FROM users";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = @"SELECT user_id, username, firstname, lastname, email, is_active
                         FROM users
                         WHERE username LIKE @search
                         OR firstname LIKE @search
                         OR lastname LIKE @search";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnFind.PerformClick();
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
    }
}
