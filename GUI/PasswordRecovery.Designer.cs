namespace GUI
{
    partial class PasswordRecovery
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
            this.txtRecovery = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnRecover = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRecovery
            // 
            this.txtRecovery.AutoSize = true;
            this.txtRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecovery.Location = new System.Drawing.Point(57, 22);
            this.txtRecovery.Name = "txtRecovery";
            this.txtRecovery.Size = new System.Drawing.Size(262, 25);
            this.txtRecovery.TabIndex = 0;
            this.txtRecovery.Text = "PASSWORD RECOVERY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your username: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(154, 75);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // btnRecover
            // 
            this.btnRecover.Location = new System.Drawing.Point(121, 191);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(155, 25);
            this.btnRecover.TabIndex = 3;
            this.btnRecover.Text = "Recover Password";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter new password:";
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.Location = new System.Drawing.Point(154, 106);
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.Size = new System.Drawing.Size(216, 22);
            this.txtNewpassword.TabIndex = 6;
            this.txtNewpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm new password:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(162, 136);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(208, 22);
            this.txtConfirm.TabIndex = 8;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecovery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PasswordRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordRecovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtRecovery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirm;
    }
}