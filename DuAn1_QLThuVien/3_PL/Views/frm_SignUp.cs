using _2_BUS.IServices;
using _2_BUS.Services;
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
        IAccServices _iAccServices;
        public frm_SignUp()
        {
            InitializeComponent();
            _iAccServices = new AccServices();
        }
        public void ShowFormMenu()
        {
            frm_Login mn = new frm_Login();
            mn.ShowDialog();
        }
        private void tvT_IconButton1_Click(object sender, EventArgs e)
        {
            if (tbx_repass.Texts == tbx_pass.Texts)
            {
                if (_iAccServices.CheckAccountExists(tbx_username.Texts))
                {
                    MessageBox.Show("Tai khoan da ton tai, moi kiem tra lai");
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
                MessageBox.Show("Nhap lai mat khau chua dung");
            }
            
        }
    }
}
