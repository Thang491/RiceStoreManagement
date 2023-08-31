using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiceStoreManagerWinForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            var userName = config["AdminAccount:username"];
            var password = config["AdminAccount:password"];

            if (userName.Equals(txtUsername.Text) && password.Equals(txtPassword.Text))
            {
                frmHomeManage frm = new frmHomeManage();
                this.Hide();
                frm.ShowDialog();



            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu đã sai!");
            }
        }
    }
}
