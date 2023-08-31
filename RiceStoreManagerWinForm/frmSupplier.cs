using BussinessObject;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RiceStoreManagerWinForm
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }
        ISupplierRepository repository = new SupplierRepository();
        public BindingSource source;
        public void loadListSupplier()
        {
            source = new BindingSource();
            var list = repository.getListSupplier();
            dgvSupplier.DataSource = null;
            dgvSupplier.DataSource = list;

        }
        private void btClear_Click(object sender, EventArgs e)
        {
            txtIdSupplier = null;
            txtNameSup = null;
            txtPhoneSup = null;
            txtAdressSup = null;
            txtEmailSup = null;
        }



        private void btCancel_Click(object sender, EventArgs e) => this.Close();

        private void btAddSupplier_Click(object sender, EventArgs e)
        {


           
            if (txtNameSup.Text == "" || txtAdressSup.Text == "" || txtPhoneSup.Text == "" || txtEmailSup.Text == "")
            {
                MessageBox.Show("All fields are required!", "Supplier Management");
            }
            else
            {
                Supplier supplier = new Supplier()
                {

                SupplierName = txtNameSup.Text,
                Address = txtAdressSup.Text,
                PhoneNumber = txtPhoneSup.Text,
                Email = txtEmailSup.Text,
            };
                if (supplier != null)
                {
                    repository.addSupplier(supplier);
                    this.loadListSupplier();
                }
                else
                {
                    MessageBox.Show("Add failed!!!");
                }
            }
           

        }

        private void btDeleteSupplier_Click(object sender, EventArgs e)
        {

            DialogResult d;
            d = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", "RiceStoreManager",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
           
                int index = dgvSupplier.CurrentCell.RowIndex;
            if (index >= 0)
            {
                if (d == DialogResult.OK)
                {
                    repository.deleteSupplier(index);
                    this.loadListSupplier();
                }
                   
            }
            else
            {
                MessageBox.Show("Null Select!");
            }


        }

        private void btUpdateSupplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier()
            {
                Id = int.Parse(txtIdSupplier.Text),
                SupplierName = txtNameSup.Text,
                Address = txtAdressSup.Text,
                PhoneNumber = txtPhoneSup.Text,
                Email = txtEmailSup.Text,
            };
            if (supplier != null)
            {
                repository.UpdateSupplier(supplier);
                this.loadListSupplier();
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSupplier.CurrentCell.RowIndex ;
            var supplier = repository.getSupplier(index);
            if (supplier != null)
            {
                txtIdSupplier.Text = supplier.Id.ToString();
                txtNameSup.Text = supplier.SupplierName.ToString();
                txtAdressSup.Text = supplier.Address.ToString();
                txtPhoneSup.Text = supplier.PhoneNumber.ToString();
                txtEmailSup.Text = supplier.Email.ToString();
            }
        }
    }
}
