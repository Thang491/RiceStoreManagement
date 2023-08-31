namespace frmLogin
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btLogin = new System.Windows.Forms.Button();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.BackColor = System.Drawing.SystemColors.Highlight;
            btLogin.Location = new System.Drawing.Point(396, 281);
            btLogin.Name = "btLogin";
            btLogin.Size = new System.Drawing.Size(108, 36);
            btLogin.TabIndex = 0;
            btLogin.Text = "Đăng Nhập";
            btLogin.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(335, 141);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(242, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(335, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(242, 27);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(205, 140);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 28);
            label1.TabIndex = 3;
            label1.Text = "Tài khoản :";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPassword.Location = new System.Drawing.Point(205, 213);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(103, 28);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Mật khẩu :";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lbPassword);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btLogin);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPassword;
    }
}
