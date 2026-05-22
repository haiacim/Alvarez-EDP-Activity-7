namespace GUI
{
    partial class IMUpdate
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
            this.btnDP = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnAP = new System.Windows.Forms.Button();
            this.txtDashboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDP
            // 
            this.btnDP.Location = new System.Drawing.Point(313, 69);
            this.btnDP.Name = "btnDP";
            this.btnDP.Size = new System.Drawing.Size(134, 23);
            this.btnDP.TabIndex = 37;
            this.btnDP.Text = "Delete Product";
            this.btnDP.UseVisualStyleBackColor = true;
            this.btnDP.Click += new System.EventHandler(this.btnDP_Click);
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(182, 69);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(134, 23);
            this.btnUP.TabIndex = 39;
            this.btnUP.Text = "Update Product";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnAP
            // 
            this.btnAP.Location = new System.Drawing.Point(51, 69);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(134, 23);
            this.btnAP.TabIndex = 38;
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
            this.txtDashboard.TabIndex = 36;
            this.txtDashboard.Text = "INVENTORY";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtStockQuantity);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnUpdateProduct);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtProductID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Location = new System.Drawing.Point(53, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 357);
            this.panel1.TabIndex = 35;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(234, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 23);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "🔍︎";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(162, 246);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(93, 22);
            this.txtDescription.TabIndex = 31;
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Location = new System.Drawing.Point(162, 201);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(93, 22);
            this.txtStockQuantity.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Description:";
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
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(69, 295);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(134, 23);
            this.btnUpdateProduct.TabIndex = 27;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(158, 201);
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
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(162, 117);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(93, 22);
            this.txtProductName.TabIndex = 4;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(162, 77);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(67, 22);
            this.txtProductID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Update Product:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stock Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product ID:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(162, 161);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(93, 22);
            this.txtPrice.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(601, 37);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 23);
            this.btnReturn.TabIndex = 40;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // IMUpdate
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
            this.Name = "IMUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMUpdate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDP;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnAP;
        private System.Windows.Forms.Label txtDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnReturn;
    }
}