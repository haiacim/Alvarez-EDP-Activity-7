namespace GUI
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.txtDashboard = new System.Windows.Forms.Label();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUM = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDashboard
            // 
            this.txtDashboard.AutoSize = true;
            this.txtDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDashboard.Location = new System.Drawing.Point(297, 9);
            this.txtDashboard.Name = "txtDashboard";
            this.txtDashboard.Size = new System.Drawing.Size(213, 36);
            this.txtDashboard.TabIndex = 0;
            this.txtDashboard.Text = "DASHBOARD";
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(33, 46);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(216, 29);
            this.txtWelcome.TabIndex = 1;
            this.txtWelcome.Text = "Welcome, Admin!";
            this.txtWelcome.Click += new System.EventHandler(this.txtWelcome_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(481, 159);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(212, 28);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "REPORTS GENERATION";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(481, 192);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(212, 30);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "ABOUT THE PROGRAM";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(18, 227);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(212, 28);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUM
            // 
            this.btnUM.Location = new System.Drawing.Point(18, 192);
            this.btnUM.Name = "btnUM";
            this.btnUM.Size = new System.Drawing.Size(212, 31);
            this.btnUM.TabIndex = 6;
            this.btnUM.Text = "USER MANAGEMENT";
            this.btnUM.UseVisualStyleBackColor = true;
            this.btnUM.Click += new System.EventHandler(this.btnUM_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnUM);
            this.panel1.Controls.Add(this.btnOrderManagement);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 341);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.blank_profile_picture_973460_1280;
            this.pictureBox1.Location = new System.Drawing.Point(24, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "INVENTORY MANAGEMENT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnInventoryManagement);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "PAYMENT MANAGEMENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPaymentManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Location = new System.Drawing.Point(481, 48);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(212, 31);
            this.btnOrderManagement.TabIndex = 8;
            this.btnOrderManagement.Text = "ORDER MANAGEMENT";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Operations";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 160);
            this.label1.TabIndex = 13;
            this.label1.Text = "The User Dashboard is \r\nwhere all of the system \r\nfeatures can be accessed \r\nin o" +
    "ne convenient place. \r\nNavigate through the \r\nappopriate menus by \r\npressing on " +
    "the appopriate \r\nbutton.\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.txtDashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDashboard;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}