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
        public frm_SignUp()
        {
            InitializeComponent();
        }
        public void ShowFormMenu()
        {
            frm_Login mn = new frm_Login();
            mn.ShowDialog();
        }
        private void tvT_IconButton1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormMenu)); //Tạo luồng mới
            thread.Start(); //Khởi chạy luồng
            this.Close();
        }
    }
}
