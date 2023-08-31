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
    public partial class frmCustomerInfor : Form
    {
        public frmCustomerInfor()
        {
            InitializeComponent();
        }
        ICustomerRepository repository = new CustomerRepository();
        public BindingSource source;

        public void loadListCustomer()
        {
            source = new BindingSource();
            var list = repository.getListCustomer();
            dgvCustomerInfor.DataSource = null;
            dgvCustomerInfor.DataSource = list;

        }

        private void dgvCustomerInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCustomerInfor.CurrentCell.RowIndex;
            var customer = repository.getCustomer(index);
            if (customer != null)
            {
                txtIdCus.Text = customer.Id.ToString();
                txtNameCus.Text = customer.CustomerName.ToString();
                txtPhone.Text = customer.PhoneNumber.ToString();
                txtAdress.Text = customer.Address.ToString();
                txtEmail.Text = customer.Email.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btAddCus_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerName = txtNameCus.Text,
                PhoneNumber = txtPhone.Text,
                Address = txtAdress.Text,
                Email = txtEmail.Text,
            };
            if (customer != null)
            {
                repository.addCustomer(customer);
                this.loadListCustomer();
            }
            else
            { MessageBox.Show("Customer is null"); }

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtIdCus.Text = null;
            txtNameCus.Text = null;
            txtPhone.Text = null;

            txtAdress.Text = null;
            txtEmail.Text = null;
        }

        private void btDeleteCus_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "CustomerManager",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            int index = dgvCustomerInfor.CurrentCell.RowIndex;
            if (index >= 0)
            {
                if (d == DialogResult.OK)
                {
                    repository.deleteCustomer(index);
                    this.loadListCustomer();
                }

            }
            else
            {
                MessageBox.Show("Null Select!");
            }


        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Id = int.Parse(txtIdCus.Text),
                CustomerName = txtNameCus.Text,
                PhoneNumber = txtPhone.Text,
                Address = txtAdress.Text,
                Email = txtEmail.Text,
            };
            if (customer != null)
            {
                repository.UpdateCustomer(customer);
               
                this.loadListCustomer();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }

        }

        private void btCancel_Click(object sender, EventArgs e) => this.Close();

       
        
        
      

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvCustomerInfor.CurrentCell.RowIndex;
            var cus = repository.getCustomer(index);
            if (cus != null)
            {
                frmOrder frm = new frmOrder();
                frm.LoadRiceList();
                frm.loadListOrder();
                frm.getCustomerID(cus);
                frm.ShowDialog();
            }
            
        }
    }
}
