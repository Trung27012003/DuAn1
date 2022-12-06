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
    public partial class frm_menus : Form
    {
        public frm_menus()
        {
            InitializeComponent();
            timer_01.Start();
        }
        private Form CurrentPanel;
        private void OpenPanel(Form panel)
        {
            if (CurrentPanel != null)
            {
                CurrentPanel.Close();
            }
            CurrentPanel = panel;
            panel.TopLevel = false;
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            pn_show.Controls.Add(panel);
            pn_show.Tag = panel;
            panel.BringToFront();
            panel.Show();
        }

        private void tbx_thongtinsach_Click(object sender, EventArgs e)
        {
            OpenPanel(new SachForm());
        }

        private void tbx_muontrasach_Click(object sender, EventArgs e)
        {
            OpenPanel(new MuonTraForm());
        }

        private void tbx_thethanhvien_Click(object sender, EventArgs e)
        {
            OpenPanel(new TheTVForm());
        }

        private void tbx_thenhanvien_Click(object sender, EventArgs e)
        {
            OpenPanel(new TheNVForm());
        }

        private void tbx_thengay_Click(object sender, EventArgs e)
        {
            OpenPanel(new TheNgayForm());
        }

        private void tbtn_darkmode_CheckedChanged(object sender, EventArgs e)
        {

            if (tbtn_darkmode.Checked)
            {
                pn_2.BackColor = Color.Gray;
                pn_1.BackColor = Color.Gray;
                lbl_darkMode.ForeColor = Color.White;
                ptb_dangxuat.BackColor = Color.Gray;
                ptb_dangxuat.IconColor = Color.White;
                ptx_avata.BackColor = Color.Gray;
                lbl_user.ForeColor = Color.White;
                lbl_timer01.ForeColor = Color.White;

            }
            else
            {
                pn_2.BackColor = Color.DarkKhaki;
                pn_1.BackColor = Color.DarkKhaki;
                lbl_darkMode.ForeColor = Color.Black;
                ptb_dangxuat.BackColor = Color.DarkKhaki;
                ptb_dangxuat.IconColor = Color.Black;
                ptx_avata.BackColor = Color.DarkKhaki;
                lbl_user.ForeColor = Color.Black;
                lbl_timer01.ForeColor = Color.Black;


            }
        }

        private void ptb_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (rs == DialogResult.OK)
            {
                Thread thread = new Thread(new ThreadStart(ShowFormMenu)); //Tạo luồng mới
                thread.Start(); //Khởi chạy luồng
                this.Close();
            }
        }
        public void ShowFormMenu()
        {
            frm_Login mn = new frm_Login();
            mn.ShowDialog();
        }

        private void timer_01_Tick(object sender, EventArgs e)
        {
            lbl_timer01.Text =DateTime.Now.ToLongTimeString();
        }

        private void tvT_IconButton1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
