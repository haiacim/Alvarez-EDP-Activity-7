using MySql.Data.MySqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class ReportGeneration : Form
    {
        public ReportGeneration()
        {
            InitializeComponent();
        }

        
        
        private void ReportGeneration_Load(object sender, EventArgs e)
        {

        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            ExcelPackage.License.SetNonCommercialPersonal("Furniture Ordering System");

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel File|*.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(sfd.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                   
                        ExcelWorksheet ws = package.Workbook.Worksheets.Add("Report");

                        var pic = ws.Drawings.AddPicture("Logo", new FileInfo(@"logo.png"));
                        pic.SetPosition(0, 0, 4, 0);
                        pic.SetSize(80, 80);

                        ws.Cells["A1"].Value = "Furniture Ordering System";
                        ws.Cells["A2"].Value = cmbReport.Text + " Report";
                        ws.Cells["A3"].Value = "Generated: " + DateTime.Now;

                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            ws.Cells[5, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                        }

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (dataGridView1.Rows[i].IsNewRow) continue;

                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                ws.Cells[i + 6, j + 1].Value =
                                    dataGridView1.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        int lastRow = dataGridView1.Rows.Count + 8;
                        ws.Cells["A" + lastRow].Value = "Prepared by:";
                        ws.Cells["A" + (lastRow + 2)].Value = "____________________";

                        
                        ExcelWorksheet chartSheet = package.Workbook.Worksheets.Add("Graph");

                        int rowIndex = 1;

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            var row = dataGridView1.Rows[i];
                            if (row.IsNewRow) continue;

                           
                            chartSheet.Cells[rowIndex, 1].Value =
                                row.Cells[0].Value?.ToString();


                            string reportType = cmbReport.Text;
                            object rawValue = null;

                            if (reportType == "Orders")
                                rawValue = row.Cells["total_amount"].Value;
                            else if (reportType == "Inventory")
                                rawValue = row.Cells["stock_quantity"].Value;
                            else if (reportType == "Payments")
                                rawValue = row.Cells["payment_amount"].Value;

                            if (decimal.TryParse(rawValue?.ToString(), out decimal val))
                                chartSheet.Cells[rowIndex, 2].Value = val;
                            else
                                chartSheet.Cells[rowIndex, 2].Value = 0;

                            rowIndex++;
                        }

                        var chart = chartSheet.Drawings.AddChart("chart", eChartType.ColumnClustered);

                        var xRange = chartSheet.Cells[1, 1, rowIndex - 1, 1];
                        var yRange = chartSheet.Cells[1, 2, rowIndex - 1, 2];

                        var series = chart.Series.Add(yRange, xRange);
                        series.Header = cmbReport.Text;

                        chart.Title.Text = cmbReport.Text + " Graph";
                        chart.SetPosition(1, 0, 3, 0);
                        chart.SetSize(800, 400);

                        package.SaveAs(file);
                    }

                    MessageBox.Show("Excel exported successfully!");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbReport.Text == "")
            {
                MessageBox.Show("Please select a report type.");
                return;
            }

            string table = "";

            if (cmbReport.Text == "Orders")
                table = "customer_orders";
            else if (cmbReport.Text == "Payments")
                table = "payments";
            else if (cmbReport.Text == "Inventory")
                table = "product";
            else
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=activity3_db;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT * FROM " + table;

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
