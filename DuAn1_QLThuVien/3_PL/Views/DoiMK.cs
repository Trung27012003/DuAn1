using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class SignUP : Form
    {

        string tdn;
        IAccServices _iaccServices;
        public SignUP(string tendangnhap)
        {
            InitializeComponent();
            _iaccServices = new AccServices();
            tdn = tendangnhap;
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            Account ac = _iaccServices.GetAllAccount().Where(c => c.UserName == tdn).FirstOrDefault();
            if (tbx_mkcu.Text == "") 
            {
                MessageBox.Show("Nhập mật khẩu cũ", "Thông báo");
            }
            else if (tbx_pass.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu mới", "Thông báo");
            }
            else if (tbx_repass.Text == "")
            {
                MessageBox.Show("Nhập lại mật khẩu mới", "Thông báo");
            }
            else if (ac.PassWord == tbx_mkcu.Text)
            {
                if (tbx_pass.Text == tbx_repass.Text)
                {
                    ac.PassWord = tbx_pass.Text;

                    _iaccServices.EditEMPLOYEES(ac);
                   
                    frm_Login formDangNhap = new frm_Login();
                    formDangNhap.Show();
                }
                else
                {
                    MessageBox.Show("Nhập mật khẩu mới và nhập lại mật khẩu mới", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Nhập mật khẩu cũ", "Thông báo");
            }
        }
    }
}
