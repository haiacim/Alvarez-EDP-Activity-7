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
    public partial class IMAdd : Form
    {
        public IMAdd()
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
        private void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtStockQuantity.Clear();
            txtDescription.Clear();

            txtProductID.Focus();
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
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
            if (txtProductID.Text == "" ||
                txtProductName.Text == "" ||
                txtPrice.Text == "" ||
                txtStockQuantity.Text == "")
            {
                MessageBox.Show("Please fill in required fields.");
                return;
            }

            
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price.");
                return;
            }

            if (!int.TryParse(txtStockQuantity.Text, out int stock))
            {
                MessageBox.Show("Invalid stock quantity.");
                return;
            }

           
            if (stock < 0)
            {
                MessageBox.Show("Stock cannot be negative.");
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Price must be greater than 0.");
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

                if (exists > 0)
                {
                    MessageBox.Show("Product ID already exists.");
                    conn.Close();
                    return;
                }

                
                string query = @"INSERT INTO product
                        (prod_id, prod_name, price, stock_quantity, description)
                        VALUES
                        (@id, @name, @price, @stock, @desc)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtProductID.Text);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product added successfully!");

                conn.Close();

                LoadProducts();
                ClearFields();
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
        private void IMAdd_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
