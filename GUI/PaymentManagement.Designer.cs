namespace GUI
{
    partial class PaymentManagement
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
            this.txtDashboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dtViewPayments = new System.Windows.Forms.DataGridView();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.btnVerifyOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.dtViewOrder = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDashboard
            // 
            this.txtDashboard.AutoSize = true;
            this.txtDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDashboard.Location = new System.Drawing.Point(47, 28);
            this.txtDashboard.Name = "txtDashboard";
            this.txtDashboard.Size = new System.Drawing.Size(404, 36);
            this.txtDashboard.TabIndex = 5;
            this.txtDashboard.Text = "PAYMENT MANAGEMENT";
            this.txtDashboard.Click += new System.EventHandler(this.txtDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtViewPayments);
            this.panel1.Controls.Add(this.cbPaymentStatus);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbPaymentMethod);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTransactionID);
            this.panel1.Controls.Add(this.txtPaymentID);
            this.panel1.Controls.Add(this.btnVerifyOrder);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnSavePayment);
            this.panel1.Controls.Add(this.dtViewOrder);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.txtOrderID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(53, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 364);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(321, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Current Payments";
            // 
            // dtViewPayments
            // 
            this.dtViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewPayments.Location = new System.Drawing.Point(327, 179);
            this.dtViewPayments.Name = "dtViewPayments";
            this.dtViewPayments.RowHeadersWidth = 51;
            this.dtViewPayments.RowTemplate.Height = 24;
            this.dtViewPayments.Size = new System.Drawing.Size(336, 157);
            this.dtViewPayments.TabIndex = 36;
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Items.AddRange(new object[] {
            "pending",
            "paid"});
            this.cbPaymentStatus.Location = new System.Drawing.Point(189, 297);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(121, 24);
            this.cbPaymentStatus.TabIndex = 35;
            this.cbPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.cbPaymentStatus_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Payment Status:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "paypal",
            "credit card",
            "bank transfer"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(191, 261);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(121, 24);
            this.cbPaymentMethod.TabIndex = 34;
            this.cbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Payment Method:";
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Location = new System.Drawing.Point(191, 228);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.Size = new System.Drawing.Size(121, 22);
            this.txtTransactionID.TabIndex = 32;
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Location = new System.Drawing.Point(189, 191);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(123, 22);
            this.txtPaymentID.TabIndex = 31;
            // 
            // btnVerifyOrder
            // 
            this.btnVerifyOrder.Location = new System.Drawing.Point(90, 92);
            this.btnVerifyOrder.Name = "btnVerifyOrder";
            this.btnVerifyOrder.Size = new System.Drawing.Size(134, 23);
            this.btnVerifyOrder.TabIndex = 30;
            this.btnVerifyOrder.Text = "Verify Order";
            this.btnVerifyOrder.UseVisualStyleBackColor = true;
            this.btnVerifyOrder.Click += new System.EventHandler(this.btnVerifyOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Payment Information";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(529, 19);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 23);
            this.btnReturn.TabIndex = 28;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.Location = new System.Drawing.Point(178, 328);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(134, 23);
            this.btnSavePayment.TabIndex = 27;
            this.btnSavePayment.Text = "Save Payment";
            this.btnSavePayment.UseVisualStyleBackColor = true;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // dtViewOrder
            // 
            this.dtViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewOrder.Location = new System.Drawing.Point(289, 48);
            this.dtViewOrder.Name = "dtViewOrder";
            this.dtViewOrder.RowHeadersWidth = 51;
            this.dtViewOrder.RowTemplate.Height = 24;
            this.dtViewOrder.Size = new System.Drawing.Size(374, 78);
            this.dtViewOrder.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "View Order";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(189, 158);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(126, 22);
            this.txtAmount.TabIndex = 4;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(162, 58);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(93, 22);
            this.txtOrderID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Search Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Payment ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Transaction ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order ID:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(29, 328);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(134, 23);
            this.btnGenerate.TabIndex = 38;
            this.btnGenerate.Text = "Generate ID\'s";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // PaymentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.txtDashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaymentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentManagement";
            this.Load += new System.EventHandler(this.PaymentManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.DataGridView dtViewOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Button btnVerifyOrder;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.DataGridView dtViewPayments;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGenerate;
    }
}