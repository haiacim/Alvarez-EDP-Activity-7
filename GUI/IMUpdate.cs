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
    public partial class IMUpdate : Form
    {
        public IMUpdate()
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
        private void btnSearch_Click(object sender, EventArgs e)
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

                string query = "SELECT * FROM product WHERE prod_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtProductID.Text);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Product not found.");
                    conn.Close();
                    return;
                }

                
                dataGridView1.DataSource = dt;

                
                txtProductName.Text = dt.Rows[0]["prod_name"].ToString();
                txtPrice.Text = dt.Rows[0]["price"].ToString();
                txtStockQuantity.Text = dt.Rows[0]["stock_quantity"].ToString();
                txtDescription.Text = dt.Rows[0]["description"].ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "" ||
                txtProductName.Text == "" ||
                txtPrice.Text == "" ||
                txtStockQuantity.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
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

            if (price <= 0)
            {
                MessageBox.Show("Price must be greater than 0.");
                return;
            }

            if (stock < 0)
            {
                MessageBox.Show("Stock cannot be negative.");
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = @"UPDATE product SET
                        prod_name = @name,
                        price = @price,
                        stock_quantity = @stock,
                        description = @desc
                        WHERE prod_id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtProductID.Text);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Product updated successfully.");
                }
                else
                {
                    MessageBox.Show("Product ID not found.");
                }

                conn.Close();

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

    }
     
    }
