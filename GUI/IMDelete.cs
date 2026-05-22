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
    public partial class IMDelete : Form
    {
        public IMDelete()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
        private void LoadProducts()
        {
            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT * FROM product";
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
        private void btnLoadProductList_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Enter Product ID.");
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                
                string checkQuery = "SELECT COUNT(*) FROM product WHERE prod_id = @id";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", txtProductID.Text);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists == 0)
                {
                    MessageBox.Show("Product ID not found.");
                    conn.Close();
                    return;
                }

                
                string deleteQuery = "DELETE FROM product WHERE prod_id = @id";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@id", txtProductID.Text);

                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Product deleted successfully.");

                conn.Close();

                txtProductID.Clear();
                txtProductID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
