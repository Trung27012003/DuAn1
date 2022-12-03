using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.Services;
using _2_BUS.Utilities;
using _3_PL.Views;
namespace _3_PL.Views
{
    public partial class LoginForm : Form
    {
        public AccServices _iaccServices;
        Validates _validates;
        public LoginForm()
        {
            InitializeComponent();
            _iaccServices = new _2_BUS.Services.AccServices();
            _validates = new Validates();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            MenuForm mn = new MenuForm();
            mn.Show();
            this.Hide();
            mn.DangXuat += Mn_DangXuat;
        }

        private void Mn_DangXuat(object sender, EventArgs e)
        {
            (sender as MenuForm)._isthoat = false;
            (sender as MenuForm).Close();
            this.Show();
        }

        private void tbt_taikhoan_TextChanged(object sender, EventArgs e)
        {
            tbt_matkau.Text= _validates.checkSDT(tbt_taikhoan.Text);
        }
    }
}
