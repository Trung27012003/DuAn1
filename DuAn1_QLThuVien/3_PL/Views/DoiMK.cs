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
    public partial class DoiMK : Form
    {

        string tdn;
        IAccServices _iaccServices;
        public DoiMK(string tendangnhap)
        {
            InitializeComponent();
            _iaccServices = new AccServices();
            tdn = tendangnhap;
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            Account ac = _iaccServices.GetAllAccount().Where(c => c.UserName == tdn).FirstOrDefault();
            if (ac.PassWord == tbx_mkcu.Text)
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
                    MessageBox.Show("Nhập sai thông tin", "Thông báo");
                }
            }
        }
    }
}
