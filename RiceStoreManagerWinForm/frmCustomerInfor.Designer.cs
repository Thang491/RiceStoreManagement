namespace RiceStoreManagerWinForm
{
    partial class frmCustomerInfor
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
            components = new System.ComponentModel.Container();
            dgvCustomerInfor = new System.Windows.Forms.DataGridView();
            contextMenuAddOrder = new System.Windows.Forms.ContextMenuStrip(components);
            label3 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtAdress = new System.Windows.Forms.TextBox();
            lbName = new System.Windows.Forms.Label();
            txtNameCus = new System.Windows.Forms.TextBox();
            lbRice = new System.Windows.Forms.Label();
            txtIdCus = new System.Windows.Forms.TextBox();
            btUpdate = new System.Windows.Forms.Button();
            btDeleteCus = new System.Windows.Forms.Button();
            btAddCus = new System.Windows.Forms.Button();
            btClear = new System.Windows.Forms.Button();
            btCancel = new System.Windows.Forms.Button();
            đặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInfor).BeginInit();
            contextMenuAddOrder.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomerInfor
            // 
            dgvCustomerInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerInfor.ContextMenuStrip = contextMenuAddOrder;
            dgvCustomerInfor.Location = new System.Drawing.Point(429, 1);
            dgvCustomerInfor.Name = "dgvCustomerInfor";
            dgvCustomerInfor.RowHeadersWidth = 51;
            dgvCustomerInfor.RowTemplate.Height = 29;
            dgvCustomerInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerInfor.Size = new System.Drawing.Size(680, 501);
            dgvCustomerInfor.TabIndex = 0;
            dgvCustomerInfor.CellClick += dgvCustomerInfor_CellClick;
            //dgvCustomerInfor.CellContextMenuStripNeeded += dgvCustomerInfor_CellContextMenuStripNeeded;
           
            // 
            // contextMenuAddOrder
            // 
            contextMenuAddOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuAddOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { đặtHàngToolStripMenuItem });
            contextMenuAddOrder.Name = "contextMenu";
            contextMenuAddOrder.Size = new System.Drawing.Size(183, 28);
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
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(183, 226);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(240, 27);
            txtEmail.TabIndex = 22;
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
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(183, 175);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(240, 27);
            txtPhone.TabIndex = 20;
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
            // txtAdress
            // 
            txtAdress.Location = new System.Drawing.Point(183, 126);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new System.Drawing.Size(240, 27);
            txtAdress.TabIndex = 18;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbName.Location = new System.Drawing.Point(5, 77);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(143, 25);
            lbName.TabIndex = 17;
            lbName.Text = "Tên khách hàng :";
            // 
            // txtNameCus
            // 
            txtNameCus.Location = new System.Drawing.Point(183, 77);
            txtNameCus.Name = "txtNameCus";
            txtNameCus.Size = new System.Drawing.Size(240, 27);
            txtNameCus.TabIndex = 16;
            // 
            // lbRice
            // 
            lbRice.AutoSize = true;
            lbRice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbRice.Location = new System.Drawing.Point(5, 35);
            lbRice.Name = "lbRice";
            lbRice.Size = new System.Drawing.Size(139, 25);
            lbRice.TabIndex = 15;
            lbRice.Text = "ID                     :";
            // 
            // txtIdCus
            // 
            txtIdCus.Enabled = false;
            txtIdCus.Location = new System.Drawing.Point(183, 35);
            txtIdCus.Name = "txtIdCus";
            txtIdCus.Size = new System.Drawing.Size(120, 27);
            txtIdCus.TabIndex = 14;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btUpdate.Location = new System.Drawing.Point(283, 304);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new System.Drawing.Size(133, 69);
            btUpdate.TabIndex = 24;
            btUpdate.Text = "Sửa thông tin";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDeleteCus
            // 
            btDeleteCus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btDeleteCus.Location = new System.Drawing.Point(144, 304);
            btDeleteCus.Name = "btDeleteCus";
            btDeleteCus.Size = new System.Drawing.Size(133, 69);
            btDeleteCus.TabIndex = 25;
            btDeleteCus.Text = "Xóa khách hàng";
            btDeleteCus.UseVisualStyleBackColor = false;
            btDeleteCus.Click += btDeleteCus_Click;
            // 
            // btAddCus
            // 
            btAddCus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btAddCus.Location = new System.Drawing.Point(5, 304);
            btAddCus.Name = "btAddCus";
            btAddCus.Size = new System.Drawing.Size(133, 69);
            btAddCus.TabIndex = 26;
            btAddCus.Text = "Thêm khách hàng";
            btAddCus.UseVisualStyleBackColor = false;
            btAddCus.Click += btAddCus_Click;
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
            btCancel.Location = new System.Drawing.Point(339, 450);
            btCancel.Name = "btCancel";
            btCancel.Size = new System.Drawing.Size(84, 52);
            btCancel.TabIndex = 29;
            btCancel.Text = "Trở về";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // đặtHàngToolStripMenuItem
            // 
            đặtHàngToolStripMenuItem.Name = "đặtHàngToolStripMenuItem";
            đặtHàngToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            đặtHàngToolStripMenuItem.Text = "Thêm đặt hàng ";
            đặtHàngToolStripMenuItem.Click += đặtHàngToolStripMenuItem_Click;
            // 
            // frmCustomerInfor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(1121, 502);
            Controls.Add(btCancel);
            Controls.Add(btClear);
            Controls.Add(btAddCus);
            Controls.Add(btDeleteCus);
            Controls.Add(btUpdate);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(txtAdress);
            Controls.Add(lbName);
            Controls.Add(txtNameCus);
            Controls.Add(lbRice);
            Controls.Add(txtIdCus);
            Controls.Add(dgvCustomerInfor);
            Name = "frmCustomerInfor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCustomerInfor";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInfor).EndInit();
            contextMenuAddOrder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerInfor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.Label lbRice;
        private System.Windows.Forms.TextBox txtIdCus;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDeleteCus;
        private System.Windows.Forms.Button btAddCus;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuAddOrder;
        private System.Windows.Forms.ToolStripMenuItem đặtHàngToolStripMenuItem;
    }
}