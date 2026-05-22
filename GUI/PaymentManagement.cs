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
    public partial class PaymentManagement : Form
    {
        public PaymentManagement()
        {
            InitializeComponent();
        }
        private string GeneratePaymentID()
        {
            Random rnd = new Random();
            char l1 = (char)rnd.Next('A', 'Z');
            char l2 = (char)rnd.Next('A', 'Z');
            int n1 = rnd.Next(0, 9);
            int n2 = rnd.Next(0, 9);

            return $"{l1}{n1}{l2}{n2}";
        }
        private string GenerateTransactionID()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 99999).ToString();
        }
        private void btnVerifyOrder_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "")
            {
                MessageBox.Show("Enter Order ID.");
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                
                string orderQuery = "SELECT * FROM orders WHERE order_id = @order_id";
                MySqlCommand orderCmd = new MySqlCommand(orderQuery, conn);
                orderCmd.Parameters.AddWithValue("@order_id", txtOrderID.Text);

                MySqlDataAdapter da = new MySqlDataAdapter(orderCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Order does not exist.");
                    conn.Close();
                    return;
                }

                dtViewOrder.DataSource = dt;
                txtAmount.Text = dt.Rows[0]["total_amount"].ToString();

                
                string payQuery = "SELECT * FROM payments WHERE order_id = @order_id";
                MySqlCommand payCmd = new MySqlCommand(payQuery, conn);
                payCmd.Parameters.AddWithValue("@order_id", txtOrderID.Text);

                MySqlDataReader reader = payCmd.ExecuteReader();

                if (reader.Read())
                {
                    txtPaymentID.Text = reader["payment_id"].ToString();
                    txtTransactionID.Text = reader["transaction_id"].ToString();
                    cbPaymentMethod.Text = reader["payment_method"].ToString();
                    cbPaymentStatus.Text = reader["payment_status"].ToString();
                }
                else
                {
                    
                    txtPaymentID.Clear();
                    txtTransactionID.Clear();
                    cbPaymentMethod.SelectedIndex = -1;
                    cbPaymentStatus.SelectedIndex = -1;
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "" || txtAmount.Text == "" ||
                txtPaymentID.Text == "" || txtTransactionID.Text == "" ||
                cbPaymentMethod.SelectedIndex == -1 ||
                cbPaymentStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM payments WHERE order_id = @order_id";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@order_id", txtOrderID.Text);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                DateTime? paidAt = null;

                if (cbPaymentStatus.Text == "paid")
                {
                    paidAt = DateTime.Now;
                }

                if (exists > 0)
                {
                  
                    string updateQuery = @"UPDATE payments SET
                                  payment_id = @payment_id,
                                  transaction_id = @transaction_id,
                                  payment_amount = @payment_amount,
                                  payment_method = @payment_method,
                                  payment_status = @payment_status,
                                  paid_at = @paid_at
                                  WHERE order_id = @order_id";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);

                    cmd.Parameters.AddWithValue("@payment_id", txtPaymentID.Text);
                    cmd.Parameters.AddWithValue("@transaction_id", txtTransactionID.Text);
                    cmd.Parameters.AddWithValue("@payment_amount", txtAmount.Text);
                    cmd.Parameters.AddWithValue("@payment_method", cbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@payment_status", cbPaymentStatus.Text);
                    cmd.Parameters.AddWithValue("@paid_at", (object)paidAt ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@order_id", txtOrderID.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment updated.");
                }
                else
                {
            
                    string insertQuery = @"INSERT INTO payments
                                  (payment_id, order_id, transaction_id, payment_amount,
                                   payment_method, payment_status, created_at, paid_at)
                                  VALUES
                                  (@payment_id, @order_id, @transaction_id, @payment_amount,
                                   @payment_method, @payment_status, @created_at, @paid_at)";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);

                    cmd.Parameters.AddWithValue("@payment_id", txtPaymentID.Text);
                    cmd.Parameters.AddWithValue("@order_id", txtOrderID.Text);
                    cmd.Parameters.AddWithValue("@transaction_id", txtTransactionID.Text);
                    cmd.Parameters.AddWithValue("@payment_amount", txtAmount.Text);
                    cmd.Parameters.AddWithValue("@payment_method", cbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@payment_status", cbPaymentStatus.Text);
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@paid_at", (object)paidAt ?? DBNull.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment saved.");
                }

                conn.Close();

                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadPayments()
        {
            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT * FROM payments ORDER by created_at DESC";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dtViewPayments.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPaymentID.Text = GeneratePaymentID();
            txtTransactionID.Text = GenerateTransactionID();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }
        private void txtDashboard_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaymentManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
