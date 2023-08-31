using BussinessObject;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RiceStoreManagerWinForm
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        IOrderRepository Repository = new OrderRepository();
        IProductRepository ProductRepository = new ProductRepository();
        public BindingSource source;

        public void LoadRiceList()
        {
            try
            {
                List<Product> listRice = (List<Product>)ProductRepository.getListProduct();
                cbRice.DataSource = listRice;
                cbRice.DisplayMember = "ProductName";
                cbRice.ValueMember = "Id";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }
        public void loadListOrder()
        {
            //
            try
            {
                var list = Repository.getListOrder();
                source = new BindingSource();
                source.DataSource = list;
                /* txtOrderID.DataBindings.Clear();
                 dtpDatetime.DataBindings.Clear();
                 txtCustomerID.DataBindings.Clear();
                 cbRice.DataBindings.Clear();
                 txtQuantityKg.DataBindings.Clear();
                 txtUnitPrice.DataBindings.Clear();
                 txtSubtotal.DataBindings.Clear();*/
                //txtOrderID.DataBindings.Add("Text", source, "Id");
                //dtpDatetime.DataBindings.Add("Text", source, "OrderDate");
                //txtCustomerID.DataBindings.Add("Text", source, "CustomerId");
                //cbRice.DataBindings.Add("Text", source, "Product.ProductName");
                //txtQuantityKg.DataBindings.Add("Text", source, "Quantity");
                //txtUnitPrice.DataBindings.Add("Text", source, "Unitprice");
                //txtSubtotal.DataBindings.Add("Text", source, sum.ToString());
                dgvOrder.DataSource = null;
                dgvOrder.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of foods");
            }
        }
        public void getCustomerID(Customer cus)
        {
            txtCustomerID.Text = cus.Id.ToString();
        }

        private void btCancel_Click(object sender, EventArgs e) => this.Close();



        private void btUpdateOrder_Click(object sender, EventArgs e)
        {
            int index = cbRice.SelectedIndex;
            var product = ProductRepository.getProduct(index);
            
            Order order = new Order()
            {
                Id = int.Parse(txtOrderID.Text),
                OrderDate = DateTime.Parse(dtpDatetime.Text),
                ProductId = product.Id,
                CustomerId = int.Parse(txtCustomerID.Text),
                Quantity = int.Parse(txtQuantityKg.Text),
                Unitprice = decimal.Parse(txtUnitPrice.Text),
                TotalAmount = decimal.Parse(txtSubtotal.Text),
            };
            if (order != null)
            {
                Repository.UpdateOrder(order);
                this.loadListOrder();
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void btAddOrder_Click(object sender, EventArgs e)
        {
            Decimal sum = Decimal.Parse(txtUnitPrice.Text) * Decimal.Parse(txtUnitPrice.Text);
            txtSubtotal.Text = sum.ToString();

            if (txtQuantityKg.Text == "" || txtUnitPrice.Text == "")
            {
                MessageBox.Show("All fields are required!", "Order Management");
            }
            else
            {
                Order order = new Order()
                {
                    OrderDate = DateTime.Parse(dtpDatetime.Text),
                    ProductId = int.Parse(cbRice.SelectedValue.ToString()),
                    CustomerId = int.Parse(txtCustomerID.Text),
                    Quantity = int.Parse(txtQuantityKg.Text),
                    Unitprice = decimal.Parse(txtUnitPrice.Text),
                    TotalAmount = decimal.Parse(txtSubtotal.Text),
                };
                if (order != null)
                {
                    Repository.addOrder(order);
                    MessageBox.Show("Thêm thành công");
                    this.loadListOrder();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btDeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn đặt hàng này không?", "OrderManager",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            int index = dgvOrder.CurrentCell.RowIndex;
            if (index >= 0)
            {
                if (d == DialogResult.OK)
                {
                    Repository.deleteOrder(index);
                    this.loadListOrder();
                }

            }
            else
            {
                MessageBox.Show("Null Select!");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cbRice.Text = string.Empty;
            txtQuantityKg.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            var sum = decimal.Parse(txtQuantityKg.Text) * decimal.Parse(txtUnitPrice.Text);
            txtSubtotal.Text = sum.ToString();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvOrder.CurrentCell.RowIndex;
            if (index >= 0)
            {
                IProductRepository repo = new ProductRepository();

                var order = Repository.getOrder(index);
                //listproduct supplier = businessobject.supplier
                var listProduct = (List<Product>)repo.getListProduct();
                //supplier = null
                Product product = repo.getProductbyId(order.ProductId);
                int indexx = listProduct.FindIndex(p => p.Id == product.Id);
                txtUnitPrice.Items.Clear();
                txtUnitPrice.Items.Add(product.WholesalePrice.ToString());
                txtUnitPrice.Items.Add(product.RetailPrice.ToString());

                txtOrderID.Text = order.Id.ToString();
                dtpDatetime.Text = order.OrderDate.ToString();
                cbRice.SelectedIndex = indexx;
                txtCustomerID.Text = order.CustomerId.ToString();
                txtQuantityKg.Text = order.Quantity.ToString();
                txtUnitPrice.Text = string.Format("{0:#,##0.00}", order.Unitprice.Value).ToString();
                txtSubtotal.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", order.TotalAmount.Value).ToString();

            }
            else
            {
                MessageBox.Show("index null");
            }
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            var value = 8012.34m;
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            txtSubtotal.Text = String.Format(info, "{0:c}", value);
        }
    }
}
