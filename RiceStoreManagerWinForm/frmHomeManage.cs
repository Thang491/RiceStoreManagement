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
    public partial class frmHomeManage : Form
    {
        public frmHomeManage()
        {
            InitializeComponent();
        }

        private void btProductManager_Click(object sender, EventArgs e)
        {
            frmRiceManager frm = new frmRiceManager();
            frm.loadListRice();
            
            frm.ShowDialog();

        }

        private void btSuplierManager_Click(object sender, EventArgs e)
        {
            frmSupplier frm = new frmSupplier();
            frm.loadListSupplier();
            
            frm.ShowDialog();
        }

        private void btCustomerManage_Click(object sender, EventArgs e)
        {
            frmCustomerInfor frm = new frmCustomerInfor();
            frm.loadListCustomer();
            
            frm.ShowDialog();
        }
    }
}
