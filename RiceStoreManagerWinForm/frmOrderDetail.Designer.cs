namespace RiceStoreManagerWinForm
{
    partial class frmOrder
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
            dgvOrder = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtQuantityKg = new System.Windows.Forms.TextBox();
            lbOrderDetail = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.TextBox();
            btUpdateOrder = new System.Windows.Forms.Button();
            btDeleteOrder = new System.Windows.Forms.Button();
            btAddOrder = new System.Windows.Forms.Button();
            btClear = new System.Windows.Forms.Button();
            btCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            dtpDatetime = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtCustomerID = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            cbRice = new System.Windows.Forms.ComboBox();
            btLoad = new System.Windows.Forms.Button();
            txtSubtotal = new System.Windows.Forms.MaskedTextBox();
            txtUnitPrice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new System.Drawing.Point(429, 1);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new System.Drawing.Size(680, 501);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(2, 321);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 25);
            label3.TabIndex = 23;
            label3.Text = "Tổng tiền (VNĐ)  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(5, 230);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(150, 25);
            label2.TabIndex = 21;
            label2.Text = "Số lượng (KG)     :";
            // 
            // txtQuantityKg
            // 
            txtQuantityKg.Location = new System.Drawing.Point(183, 230);
            txtQuantityKg.Name = "txtQuantityKg";
            txtQuantityKg.Size = new System.Drawing.Size(240, 27);
            txtQuantityKg.TabIndex = 20;
            // 
            // lbOrderDetail
            // 
            lbOrderDetail.AutoSize = true;
            lbOrderDetail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbOrderDetail.Location = new System.Drawing.Point(5, 35);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new System.Drawing.Size(154, 25);
            lbOrderDetail.TabIndex = 15;
            lbOrderDetail.Text = "ID                        :";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new System.Drawing.Point(183, 35);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(120, 27);
            txtOrderID.TabIndex = 14;
            // 
            // btUpdateOrder
            // 
            btUpdateOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btUpdateOrder.Location = new System.Drawing.Point(280, 361);
            btUpdateOrder.Name = "btUpdateOrder";
            btUpdateOrder.Size = new System.Drawing.Size(133, 69);
            btUpdateOrder.TabIndex = 24;
            btUpdateOrder.Text = "Sửa thông tin";
            btUpdateOrder.UseVisualStyleBackColor = false;
            btUpdateOrder.Click += btUpdateOrder_Click;
            // 
            // btDeleteOrder
            // 
            btDeleteOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btDeleteOrder.Location = new System.Drawing.Point(141, 361);
            btDeleteOrder.Name = "btDeleteOrder";
            btDeleteOrder.Size = new System.Drawing.Size(133, 69);
            btDeleteOrder.TabIndex = 25;
            btDeleteOrder.Text = "Xóa đơn hàng";
            btDeleteOrder.UseVisualStyleBackColor = false;
            btDeleteOrder.Click += btDeleteOrder_Click;
            // 
            // btAddOrder
            // 
            btAddOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btAddOrder.Location = new System.Drawing.Point(2, 361);
            btAddOrder.Name = "btAddOrder";
            btAddOrder.Size = new System.Drawing.Size(133, 69);
            btAddOrder.TabIndex = 26;
            btAddOrder.Text = "Thêm mới đơn hàng";
            btAddOrder.UseVisualStyleBackColor = false;
            btAddOrder.Click += btAddOrder_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(5, 85);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(154, 25);
            label1.TabIndex = 30;
            label1.Text = "Ngày đặt hàng    :";
            // 
            // dtpDatetime
            // 
            dtpDatetime.Enabled = false;
            dtpDatetime.Location = new System.Drawing.Point(183, 86);
            dtpDatetime.Name = "dtpDatetime";
            dtpDatetime.Size = new System.Drawing.Size(240, 27);
            dtpDatetime.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(5, 132);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(153, 25);
            label4.TabIndex = 33;
            label4.Text = "Loại Gạo(ID)        :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(5, 180);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(151, 25);
            label5.TabIndex = 35;
            label5.Text = "Khách hàng(ID)   :";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new System.Drawing.Point(183, 180);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(240, 27);
            txtCustomerID.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(5, 275);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(151, 25);
            label6.TabIndex = 37;
            label6.Text = "Đơn giá   (VNĐ)  :";
            // 
            // cbRice
            // 
            cbRice.FormattingEnabled = true;
            cbRice.Location = new System.Drawing.Point(180, 132);
            cbRice.Name = "cbRice";
            cbRice.Size = new System.Drawing.Size(243, 28);
            cbRice.TabIndex = 38;
            // 
            // btLoad
            // 
            btLoad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btLoad.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btLoad.Location = new System.Drawing.Point(368, 317);
            btLoad.Name = "btLoad";
            btLoad.Size = new System.Drawing.Size(55, 29);
            btLoad.TabIndex = 39;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = false;
            btLoad.Click += btLoad_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new System.Drawing.Point(183, 319);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(240, 27);
            txtSubtotal.TabIndex = 40;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.FormattingEnabled = true;
            txtUnitPrice.Location = new System.Drawing.Point(180, 272);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(243, 28);
            txtUnitPrice.TabIndex = 41;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(1121, 502);
            Controls.Add(txtUnitPrice);
            Controls.Add(btLoad);
            Controls.Add(txtSubtotal);
            Controls.Add(cbRice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCustomerID);
            Controls.Add(label4);
            Controls.Add(dtpDatetime);
            Controls.Add(label1);
            Controls.Add(btCancel);
            Controls.Add(btClear);
            Controls.Add(btAddOrder);
            Controls.Add(btDeleteOrder);
            Controls.Add(btUpdateOrder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtQuantityKg);
            Controls.Add(lbOrderDetail);
            Controls.Add(txtOrderID);
            Controls.Add(dgvOrder);
            Name = "frmOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmOrderDetail";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantityKg;
        private System.Windows.Forms.Label lbOrderDetail;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btUpdateOrder;
        private System.Windows.Forms.Button btDeleteOrder;
        private System.Windows.Forms.Button btAddOrder;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRice;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.MaskedTextBox txtSubtotal;
        private System.Windows.Forms.ComboBox txtUnitPrice;
    }
}