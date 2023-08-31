using BussinessObject;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiceStoreManagerWinForm
{
    public partial class frmRiceManager : Form
    {
        public frmRiceManager()
        {
            InitializeComponent();
        }
        IProductRepository productRepository = new ProductRepository();
        public BindingSource source;
        public void loadListRice()
        {
            source = new BindingSource();
            List<Product> list = (List<Product>)productRepository.getListProduct();
            dgvRiceManager.DataSource = null;
            dgvRiceManager.DataSource = list;
        }

        private void dgvRiceManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvRiceManager.CurrentCell.RowIndex;
            Product product = productRepository.getProduct(index);
            if (product != null)
            {
                txtProductId.Text = product.Id.ToString();
                txtName.Text = product.ProductName.ToString();
                txtWholeSale.Text = product.WholesalePrice.ToString();
                txtPriceDetail.Text = product.RetailPrice.ToString();
                txtSupplier.Text = product.SupplierId.ToString();

            }


        }

        private void btaddProducts_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {

                ProductName = txtName.Text,
                WholesalePrice = Decimal.Parse(txtWholeSale.Text),
                RetailPrice = Decimal.Parse(txtPriceDetail.Text),
                SupplierId = int.Parse(txtSupplier.Text)
            };
            productRepository.Addproduct(product);
            this.loadListRice();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index = dgvRiceManager.CurrentCell.RowIndex;
            DialogResult d;
            d = MessageBox.Show("Bạn có chắc chắn muốn xóa loại gạo này không?", "RiceManager",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);          
            if (index >= 0)
            {
                if (d == DialogResult.OK)
                {
                    productRepository.Deleteproduct(index);
                    this.loadListRice();
                }

            }
            else
            {
                MessageBox.Show("Null Select!");
            }
            

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = int.Parse(txtProductId.Text),
                ProductName = txtName.Text,
                WholesalePrice = Decimal.Parse(txtWholeSale.Text),
                RetailPrice = Decimal.Parse(txtPriceDetail.Text),
                SupplierId = int.Parse(txtSupplier.Text)
            };
            productRepository.UpdateProduct(product);
            this.loadListRice();
        }

        private void btaddCus_Click(object sender, EventArgs e)
        {
            frmCustomerInfor frm = new frmCustomerInfor();
            frm.loadListCustomer();

            frm.ShowDialog();
        }

        private void btaddSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier frm = new frmSupplier();
            frm.loadListSupplier();
            frm.ShowDialog();

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtProductId.Text = null;
            txtName.Text = null;
            txtWholeSale.Text = null;
            txtPriceDetail.Text = null;
            txtSupplier.Text = null;
        }
    }
}
