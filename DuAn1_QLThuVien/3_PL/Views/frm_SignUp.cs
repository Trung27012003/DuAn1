using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.Utilities;
using _2_BUS.ViewModels;
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
    public partial class frm_SignUp : Form
    {
        Validates validates;
        IAccServices _iAccServices;
        public frm_SignUp()
        {
            InitializeComponent();
            _iAccServices = new AccServices();
            validates = new Validates();
        }
        public void ShowFormMenu()
        {
            frm_Login mn = new frm_Login();
            mn.ShowDialog();
        }
        private void tvT_IconButton1_Click(object sender, EventArgs e)
        {
            if (tbx_username.Texts == "")
            {
                MessageBox.Show("Nhập tên tài khoản", "Thông báo");
            }
            else if (tbx_pass.Texts == "")
            {
                MessageBox.Show("Nhập mật khẩu", "Thông báo");
            }
            //else if (validates.CheckPass(tbx_pass.Texts) == false)
            //{
            //    MessageBox.Show("Nhập mật khẩu chứa số hoặc chữ", "Thông báo");
            //}
            else if (tbx_repass.Texts == "")
            {
                MessageBox.Show("Nhập lại mật khẩu ", "Thông báo");
            }
            else if (cbx_robot.Checked == false)
            {
                MessageBox.Show("Bạn là người máy à!!", "Thông báo");
            }
            else if (tbx_repass.Texts == tbx_pass.Texts)
            {
                if (_iAccServices.CheckAccountExists(tbx_username.Texts))
                {
                    MessageBox.Show("Tài khoản đã tồn tại, mời kiểm tra lại","Thông báo");
                    tbx_username.Texts = "";
                }
                else
                {
                    AccView acc = new AccView();
                    {
                        acc.UserName = tbx_username.Texts;
                        acc.PassWord = tbx_pass.Texts;
                    }
                    
                    MessageBox.Show(_iAccServices.CreateAccount(acc));
                    Thread thread = new Thread(new ThreadStart(ShowFormMenu)); //Tạo luồng mới
                    thread.Start(); //Khởi chạy luồng
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu chưa đúng với mật khẩu", "Thông báo");
            }
            
        }

        
    }
}
