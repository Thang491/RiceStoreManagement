namespace RiceStoreManagerWinForm
{
    partial class frmHomeManage
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
            btProductManager = new System.Windows.Forms.Button();
            btSuplierManager = new System.Windows.Forms.Button();
            btCustomerManage = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btProductManager
            // 
            btProductManager.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btProductManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btProductManager.Location = new System.Drawing.Point(116, 57);
            btProductManager.Name = "btProductManager";
            btProductManager.Size = new System.Drawing.Size(352, 117);
            btProductManager.TabIndex = 0;
            btProductManager.Text = "Quản lý sản phẩm";
            btProductManager.UseVisualStyleBackColor = false;
            btProductManager.Click += btProductManager_Click;
            // 
            // btSuplierManager
            // 
            btSuplierManager.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btSuplierManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btSuplierManager.Location = new System.Drawing.Point(118, 202);
            btSuplierManager.Name = "btSuplierManager";
            btSuplierManager.Size = new System.Drawing.Size(352, 117);
            btSuplierManager.TabIndex = 1;
            btSuplierManager.Text = "Quản lý nhà cung cấp";
            btSuplierManager.UseVisualStyleBackColor = false;
            btSuplierManager.Click += btSuplierManager_Click;
            // 
            // btCustomerManage
            // 
            btCustomerManage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btCustomerManage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btCustomerManage.Location = new System.Drawing.Point(116, 349);
            btCustomerManage.Name = "btCustomerManage";
            btCustomerManage.Size = new System.Drawing.Size(352, 117);
            btCustomerManage.TabIndex = 2;
            btCustomerManage.Text = "Quản lý khách hàng";
            btCustomerManage.UseVisualStyleBackColor = false;
            btCustomerManage.Click += btCustomerManage_Click;
            // 
            // frmHomeManage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ScrollBar;
            ClientSize = new System.Drawing.Size(588, 521);
            Controls.Add(btCustomerManage);
            Controls.Add(btSuplierManager);
            Controls.Add(btProductManager);
            Name = "frmHomeManage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmHomeManage";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btProductManager;
        private System.Windows.Forms.Button btSuplierManager;
        private System.Windows.Forms.Button btCustomerManage;
    }
}