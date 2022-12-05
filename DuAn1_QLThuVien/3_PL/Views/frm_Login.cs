using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using _3_PL.Views;
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
    public partial class frm_Login : Form
    {
        private IAccServices _iaccServices;
        public frm_Login()
        {
            InitializeComponent();
            _iaccServices = new AccServices();
           
        }
        public void ShowFormLoUp()
        {
            frm_SignUp mn = new frm_SignUp();
            mn.ShowDialog();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormLoUp)); //Tạo luồng mới
            thread.Start(); //Khởi chạy luồng
            this.Close();
        }
        public void ShowFormMenu()
        {
            frm_menus mn = new frm_menus();
            mn.ShowDialog();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (_iaccServices.CheckEmtyDB())
            {
                MessageBox.Show("There is no Account exists in database, please create a new one");
            }
            else
            {
                Account account = _iaccServices.CheckLogin(tbx_username.Texts, tbx_password.Texts);
                if (account == null)
                {
                    MessageBox.Show("tai khoan mat khau ko chinh xac");
                }
                else
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    Thread thread = new Thread(new ThreadStart(ShowFormMenu)); //Tạo luồng mới
                    thread.Start(); //Khởi chạy luồng
                    this.Close();
                }
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}