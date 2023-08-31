namespace RiceStoreManagerWinForm
{
    partial class frmRiceManager
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
            dgvRiceManager = new System.Windows.Forms.DataGridView();
            btaddCus = new System.Windows.Forms.Button();
            btaddProducts = new System.Windows.Forms.Button();
            btaddSupplier = new System.Windows.Forms.Button();
            txtProductId = new System.Windows.Forms.TextBox();
            lbRice = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lbName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtWholeSale = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPriceDetail = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtSupplier = new System.Windows.Forms.TextBox();
            btDelete = new System.Windows.Forms.Button();
            btUpdate = new System.Windows.Forms.Button();
            btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvRiceManager).BeginInit();
            SuspendLayout();
            // 
            // dgvRiceManager
            // 
            dgvRiceManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiceManager.Location = new System.Drawing.Point(519, -1);
            dgvRiceManager.Name = "dgvRiceManager";
            dgvRiceManager.RowHeadersWidth = 51;
            dgvRiceManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRiceManager.Size = new System.Drawing.Size(645, 502);
            dgvRiceManager.TabIndex = 0;
            dgvRiceManager.CellClick += dgvRiceManager_CellClick;
            // 
            // btaddCus
            // 
            btaddCus.BackColor = System.Drawing.Color.Orchid;
            btaddCus.Location = new System.Drawing.Point(2, 435);
            btaddCus.Name = "btaddCus";
            btaddCus.Size = new System.Drawing.Size(261, 69);
            btaddCus.TabIndex = 1;
            btaddCus.Text = "Thêm thông tin người mua hàng";
            btaddCus.UseVisualStyleBackColor = false;
            btaddCus.Click += btaddCus_Click;
            // 
            // btaddProducts
            // 
            btaddProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btaddProducts.Location = new System.Drawing.Point(2, 304);
            btaddProducts.Name = "btaddProducts";
            btaddProducts.Size = new System.Drawing.Size(173, 69);
            btaddProducts.TabIndex = 2;
            btaddProducts.Text = "Thêm loại gạo vào kho";
            btaddProducts.UseVisualStyleBackColor = false;
            btaddProducts.Click += btaddProducts_Click;
            // 
            // btaddSupplier
            // 
            btaddSupplier.BackColor = System.Drawing.Color.Orchid;
            btaddSupplier.Location = new System.Drawing.Point(259, 435);
            btaddSupplier.Name = "btaddSupplier";
            btaddSupplier.Size = new System.Drawing.Size(261, 69);
            btaddSupplier.TabIndex = 3;
            btaddSupplier.Text = "Thêm thông tin nhà cung cấp gạo";
            btaddSupplier.UseVisualStyleBackColor = false;
            btaddSupplier.Click += btaddSupplier_Click;
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new System.Drawing.Point(134, 52);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new System.Drawing.Size(120, 27);
            txtProductId.TabIndex = 4;
            // 
            // lbRice
            // 
            lbRice.AutoSize = true;
            lbRice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbRice.Location = new System.Drawing.Point(2, 52);
            lbRice.Name = "lbRice";
            lbRice.Size = new System.Drawing.Size(39, 25);
            lbRice.TabIndex = 5;
            lbRice.Text = "ID :";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(134, 94);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(286, 27);
            txtName.TabIndex = 6;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbName.Location = new System.Drawing.Point(2, 94);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(116, 25);
            lbName.TabIndex = 7;
            lbName.Text = "Tên loại gạo :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(2, 143);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 25);
            label1.TabIndex = 9;
            label1.Text = "Giá bán sỉ     :";
            // 
            // txtWholeSale
            // 
            txtWholeSale.Location = new System.Drawing.Point(134, 143);
            txtWholeSale.Name = "txtWholeSale";
            txtWholeSale.Size = new System.Drawing.Size(286, 27);
            txtWholeSale.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(2, 192);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 25);
            label2.TabIndex = 11;
            label2.Text = "Giá bán lẻ     :";
            // 
            // txtPriceDetail
            // 
            txtPriceDetail.Location = new System.Drawing.Point(134, 192);
            txtPriceDetail.Name = "txtPriceDetail";
            txtPriceDetail.Size = new System.Drawing.Size(286, 27);
            txtPriceDetail.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(2, 243);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(125, 25);
            label3.TabIndex = 13;
            label3.Text = "Nhà cung cấp:";
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new System.Drawing.Point(134, 243);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new System.Drawing.Size(286, 27);
            txtSupplier.TabIndex = 12;
            // 
            // btDelete
            // 
            btDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btDelete.Location = new System.Drawing.Point(172, 304);
            btDelete.Name = "btDelete";
            btDelete.Size = new System.Drawing.Size(173, 69);
            btDelete.TabIndex = 14;
            btDelete.Text = "Xóa gạo khỏi kho";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btUpdate.Location = new System.Drawing.Point(340, 304);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new System.Drawing.Size(173, 69);
            btUpdate.TabIndex = 15;
            btUpdate.Text = "Sửa thông tin gạo";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // btClear
            // 
            btClear.Location = new System.Drawing.Point(2, -1);
            btClear.Name = "btClear";
            btClear.Size = new System.Drawing.Size(61, 25);
            btClear.TabIndex = 28;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // frmRiceManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            ClientSize = new System.Drawing.Size(1168, 504);
            Controls.Add(btClear);
            Controls.Add(btUpdate);
            Controls.Add(btDelete);
            Controls.Add(label3);
            Controls.Add(txtSupplier);
            Controls.Add(label2);
            Controls.Add(txtPriceDetail);
            Controls.Add(label1);
            Controls.Add(txtWholeSale);
            Controls.Add(lbName);
            Controls.Add(txtName);
            Controls.Add(lbRice);
            Controls.Add(txtProductId);
            Controls.Add(btaddSupplier);
            Controls.Add(btaddProducts);
            Controls.Add(btaddCus);
            Controls.Add(dgvRiceManager);
            Name = "frmRiceManager";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmRiceManager";
            ((System.ComponentModel.ISupportInitialize)dgvRiceManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRiceManager;
        private System.Windows.Forms.Button btaddCus;
        private System.Windows.Forms.Button btaddProducts;
        private System.Windows.Forms.Button btaddSupplier;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lbRice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWholeSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPriceDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btClear;
    }
}