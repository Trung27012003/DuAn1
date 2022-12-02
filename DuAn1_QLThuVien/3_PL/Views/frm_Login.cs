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
        public frm_Login()
        {
            InitializeComponent();
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
            Thread thread = new Thread(new ThreadStart(ShowFormMenu)); //Tạo luồng mới
            thread.Start(); //Khởi chạy luồng
            this.Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}