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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_thoigian.Text = DateTime.Now.ToString("F");
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
            pn_body.Controls.Add(panel);
            pn_body.Tag = panel;
            panel.BringToFront();
            panel.Show();
        }

        private void btn_muontra_Click(object sender, EventArgs e)
        {
            OpenPanel(new MuonTraForm());

        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            OpenPanel(new SachForm());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (CurrentPanel != null)
            {
                CurrentPanel.Close();
            }
        }
    }
}
