namespace RiceStoreManagerWinForm
{
    partial class frmSupplier
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
            dgvSupplier = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            txtEmailSup = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPhoneSup = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtAdressSup = new System.Windows.Forms.TextBox();
            lbName = new System.Windows.Forms.Label();
            txtNameSup = new System.Windows.Forms.TextBox();
            lbRice = new System.Windows.Forms.Label();
            txtIdSupplier = new System.Windows.Forms.TextBox();
            btUpdateSupplier = new System.Windows.Forms.Button();
            btDeleteSupplier = new System.Windows.Forms.Button();
            btAddSupplier = new System.Windows.Forms.Button();
            btClear = new System.Windows.Forms.Button();
            btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // dgvSupplier
            // 
            dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new System.Drawing.Point(429, 1);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.RowTemplate.Height = 29;
            dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSupplier.Size = new System.Drawing.Size(680, 501);
            dgvSupplier.TabIndex = 0;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(5, 226);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(148, 25);
            label3.TabIndex = 23;
            label3.Text = "Email                  :";
            // 
            // txtEmailSup
            // 
            txtEmailSup.Location = new System.Drawing.Point(183, 226);
            txtEmailSup.Name = "txtEmailSup";
            txtEmailSup.Size = new System.Drawing.Size(240, 27);
            txtEmailSup.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(5, 175);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(146, 25);
            label2.TabIndex = 21;
            label2.Text = "Số điện thoại     :";
            // 
            // txtPhoneSup
            // 
            txtPhoneSup.Location = new System.Drawing.Point(183, 175);
            txtPhoneSup.Name = "txtPhoneSup";
            txtPhoneSup.Size = new System.Drawing.Size(240, 27);
            txtPhoneSup.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(5, 126);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(144, 25);
            label1.TabIndex = 19;
            label1.Text = "Địa chỉ               :";
            // 
            // txtAdressSup
            // 
            txtAdressSup.Location = new System.Drawing.Point(183, 126);
            txtAdressSup.Name = "txtAdressSup";
            txtAdressSup.Size = new System.Drawing.Size(240, 27);
            txtAdressSup.TabIndex = 18;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbName.Location = new System.Drawing.Point(5, 77);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(158, 25);
            lbName.TabIndex = 17;
            lbName.Text = "Tên nhà cung cấp :";
            // 
            // txtNameSup
            // 
            txtNameSup.Location = new System.Drawing.Point(183, 77);
            txtNameSup.Name = "txtNameSup";
            txtNameSup.Size = new System.Drawing.Size(240, 27);
            txtNameSup.TabIndex = 16;
            // 
            // lbRice
            // 
            lbRice.AutoSize = true;
            lbRice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbRice.Location = new System.Drawing.Point(5, 35);
            lbRice.Name = "lbRice";
            lbRice.Size = new System.Drawing.Size(159, 25);
            lbRice.TabIndex = 15;
            lbRice.Text = "ID                         :";
            // 
            // txtIdSupplier
            // 
            txtIdSupplier.Enabled = false;
            txtIdSupplier.Location = new System.Drawing.Point(183, 35);
            txtIdSupplier.Name = "txtIdSupplier";
            txtIdSupplier.Size = new System.Drawing.Size(120, 27);
            txtIdSupplier.TabIndex = 14;
            // 
            // btUpdateSupplier
            // 
            btUpdateSupplier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btUpdateSupplier.Location = new System.Drawing.Point(283, 304);
            btUpdateSupplier.Name = "btUpdateSupplier";
            btUpdateSupplier.Size = new System.Drawing.Size(133, 69);
            btUpdateSupplier.TabIndex = 24;
            btUpdateSupplier.Text = "Sửa thông tin";
            btUpdateSupplier.UseVisualStyleBackColor = false;
            btUpdateSupplier.Click += btUpdateSupplier_Click;
            // 
            // btDeleteSupplier
            // 
            btDeleteSupplier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btDeleteSupplier.Location = new System.Drawing.Point(144, 304);
            btDeleteSupplier.Name = "btDeleteSupplier";
            btDeleteSupplier.Size = new System.Drawing.Size(133, 69);
            btDeleteSupplier.TabIndex = 25;
            btDeleteSupplier.Text = "Xóa nhà cung cấp";
            btDeleteSupplier.UseVisualStyleBackColor = false;
            btDeleteSupplier.Click += btDeleteSupplier_Click;
            // 
            // btAddSupplier
            // 
            btAddSupplier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btAddSupplier.Location = new System.Drawing.Point(5, 304);
            btAddSupplier.Name = "btAddSupplier";
            btAddSupplier.Size = new System.Drawing.Size(133, 69);
            btAddSupplier.TabIndex = 26;
            btAddSupplier.Text = "Thêm nhà cung cấp";
            btAddSupplier.UseVisualStyleBackColor = false;
            btAddSupplier.Click += btAddSupplier_Click;
            // 
            // btClear
            // 
            btClear.Location = new System.Drawing.Point(5, 1);
            btClear.Name = "btClear";
            btClear.Size = new System.Drawing.Size(61, 25);
            btClear.TabIndex = 27;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btCancel
            // 
            btCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btCancel.Location = new System.Drawing.Point(344, 450);
            btCancel.Name = "btCancel";
            btCancel.Size = new System.Drawing.Size(84, 52);
            btCancel.TabIndex = 28;
            btCancel.Text = "Trở về";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(1121, 502);
            Controls.Add(btCancel);
            Controls.Add(btClear);
            Controls.Add(btAddSupplier);
            Controls.Add(btDeleteSupplier);
            Controls.Add(btUpdateSupplier);
            Controls.Add(label3);
            Controls.Add(txtEmailSup);
            Controls.Add(label2);
            Controls.Add(txtPhoneSup);
            Controls.Add(label1);
            Controls.Add(txtAdressSup);
            Controls.Add(lbName);
            Controls.Add(txtNameSup);
            Controls.Add(lbRice);
            Controls.Add(txtIdSupplier);
            Controls.Add(dgvSupplier);
            Name = "frmSupplier";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmSupplier";
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailSup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdressSup;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtNameSup;
        private System.Windows.Forms.Label lbRice;
        private System.Windows.Forms.TextBox txtIdSupplier;
        private System.Windows.Forms.Button btUpdateSupplier;
        private System.Windows.Forms.Button btDeleteSupplier;
        private System.Windows.Forms.Button btAddSupplier;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
    }
}