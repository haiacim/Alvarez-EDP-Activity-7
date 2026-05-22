using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }
        private void LoadOrders()
        {
            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = @"SELECT o.order_id, o.cust_id, o.order_date, o.status,
                                op.prod_id, op.quantity, o.total_amount
                         FROM orders o
                         JOIN order_products op ON o.order_id = op.order_id";

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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "" || txtProductID.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                // ----------------------------
                // 1. Check customer exists
                // ----------------------------
                string custQuery = "SELECT COUNT(*) FROM customer WHERE cust_id = @cust_id";
                MySqlCommand custCmd = new MySqlCommand(custQuery, conn);
                custCmd.Parameters.AddWithValue("@cust_id", txtCustomerID.Text);

                int custExists = Convert.ToInt32(custCmd.ExecuteScalar());

                if (custExists == 0)
                {
                    MessageBox.Show("Customer ID does not exist.");
                    conn.Close();
                    return;
                }

                // ----------------------------
                // 2. Check product exists + get price
                // ----------------------------
                string prodQuery = "SELECT price FROM product WHERE prod_id = @prod_id";
                MySqlCommand prodCmd = new MySqlCommand(prodQuery, conn);
                prodCmd.Parameters.AddWithValue("@prod_id", txtProductID.Text);

                object priceResult = prodCmd.ExecuteScalar();

                if (priceResult == null)
                {
                    MessageBox.Show("Product ID does not exist.");
                    conn.Close();
                    return;
                }

                decimal price = Convert.ToDecimal(priceResult);
                int quantity = Convert.ToInt32(txtQuantity.Text);

                decimal totalAmount = price * quantity;

                lblTotalAmount.Text = totalAmount.ToString("0.00");

                // ----------------------------
                // 3. Generate order_id (00001 format)
                // ----------------------------
                string idQuery = "SELECT MAX(order_id) FROM orders";
                MySqlCommand idCmd = new MySqlCommand(idQuery, conn);

                object lastIdObj = idCmd.ExecuteScalar();

                string newOrderId = "00001";

                if (lastIdObj != null && lastIdObj != DBNull.Value)
                {
                    string lastIdStr = lastIdObj.ToString();
                    int numericPart = int.Parse(lastIdStr);
                    newOrderId = (numericPart + 1).ToString("D5");
                }

                // ----------------------------
                // 4. Insert into orders
                // ----------------------------
                string orderInsert = @"INSERT INTO orders
                              (order_id, cust_id, order_date, status, total_amount)
                              VALUES
                              (@order_id, @cust_id, @order_date, @status, @total_amount)";

                MySqlCommand orderCmd = new MySqlCommand(orderInsert, conn);

                orderCmd.Parameters.AddWithValue("@order_id", newOrderId);
                orderCmd.Parameters.AddWithValue("@cust_id", txtCustomerID.Text);
                orderCmd.Parameters.AddWithValue("@order_date", DateTime.Now);
                orderCmd.Parameters.AddWithValue("@status", "Pending");
                orderCmd.Parameters.AddWithValue("@total_amount", totalAmount);

                orderCmd.ExecuteNonQuery();

                // ----------------------------
                // 5. Insert into order_products
                // ----------------------------
                string orderProdInsert = @"INSERT INTO order_products
                                  (order_id, prod_id, quantity, price)
                                  VALUES
                                  (@order_id, @prod_id, @quantity, @price)";

                MySqlCommand opCmd = new MySqlCommand(orderProdInsert, conn);

                opCmd.Parameters.AddWithValue("@order_id", newOrderId);
                opCmd.Parameters.AddWithValue("@prod_id", txtProductID.Text);
                opCmd.Parameters.AddWithValue("@quantity", quantity);
                opCmd.Parameters.AddWithValue("@price", price);

                opCmd.ExecuteNonQuery();

                // ----------------------------
                // 6. Success + cleanup
                // ----------------------------
                MessageBox.Show("Order saved successfully!");

                txtCustomerID.Clear();
                txtProductID.Clear();
                txtQuantity.Clear();
                lblTotalAmount.Text = "0.00";

                txtCustomerID.Focus();

                conn.Close();

                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtProductID.Text == "" || txtQuantity.Text == "")
            {
                lblTotalAmount.Text = "0.00";
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                lblTotalAmount.Text = "0.00";
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT price FROM product WHERE prod_id = @prod_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@prod_id", txtProductID.Text);

                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    lblTotalAmount.Text = "0.00";
                    conn.Close();
                    return;
                }

                decimal price = Convert.ToDecimal(result);
                decimal total = price * quantity;

                lblTotalAmount.Text = total.ToString("0.00");

                conn.Close();
            }
            catch
            {
                lblTotalAmount.Text = "0.00";
            }
        }
        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            txtQuantity_TextChanged(null, null);
        }
        private void txtDashboard_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
