namespace GUI
{
    partial class IMDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDP = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnAP = new System.Windows.Forms.Button();
            this.txtDashboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(601, 37);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 23);
            this.btnReturn.TabIndex = 46;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDP
            // 
            this.btnDP.Location = new System.Drawing.Point(313, 69);
            this.btnDP.Name = "btnDP";
            this.btnDP.Size = new System.Drawing.Size(134, 23);
            this.btnDP.TabIndex = 43;
            this.btnDP.Text = "Delete Product";
            this.btnDP.UseVisualStyleBackColor = true;
            this.btnDP.Click += new System.EventHandler(this.btnDP_Click);
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(182, 69);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(134, 23);
            this.btnUP.TabIndex = 45;
            this.btnUP.Text = "Update Product";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnAP
            // 
            this.btnAP.Location = new System.Drawing.Point(51, 69);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(134, 23);
            this.btnAP.TabIndex = 44;
            this.btnAP.Text = "Add Product";
            this.btnAP.UseVisualStyleBackColor = true;
            this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
            // 
            // txtDashboard
            // 
            this.txtDashboard.AutoSize = true;
            this.txtDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDashboard.Location = new System.Drawing.Point(48, 24);
            this.txtDashboard.Name = "txtDashboard";
            this.txtDashboard.Size = new System.Drawing.Size(199, 36);
            this.txtDashboard.TabIndex = 42;
            this.txtDashboard.Text = "INVENTORY";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtProductID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(53, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 357);
            this.panel1.TabIndex = 41;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(406, 324);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 23);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Load Product List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnLoadProductList_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(68, 202);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteProduct.TabIndex = 27;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(148, 211);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 20);
            this.lblTotalAmount.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(374, 257);
            this.dataGridView1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Product List:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(151, 153);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(110, 22);
            this.txtProductID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Delete Product:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product ID:";
            // 
            // IMDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDP);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnAP);
            this.Controls.Add(this.txtDashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IMDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDelete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDP;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnAP;
        private System.Windows.Forms.Label txtDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}