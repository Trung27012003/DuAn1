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
    public partial class MuonTraForm : Form
    {
        ISachServices _IsachServices;
        List<SachView> _lstSachView;
        public MuonTraForm()
        {
            InitializeComponent();
            _IsachServices = new SachServices();
            _lstSachView = new List<SachView>();
            _lstSachView = _IsachServices.GetSach();
            LoadToGrid_Sach(_lstSachView);

        }
        public void LoadToGrid_Sach(List<SachView> s)
        {
            
                dgrid_danhsachsach.Rows.Clear();
                dgrid_danhsachsach.ColumnCount = 6;
                dgrid_danhsachsach.Columns[0].Name = "Id";
                dgrid_danhsachsach.Columns[1].Name = "STT";
                dgrid_danhsachsach.Columns[2].Name = "Thể loại";
                dgrid_danhsachsach.Columns[3].Name = "Tác giả";
                dgrid_danhsachsach.Columns[4].Name = "Tên sách";
                dgrid_danhsachsach.Columns[5].Name = "Số lượng";
                dgrid_danhsachsach.Columns[0].Visible = false;
                int stt = 1;
                foreach (var x in s)
                {
                    dgrid_danhsachsach.Rows.Add(
                         x.Id, stt++, x.TL, x.TG, x.Name, x.SoLuong);
                }
            
        }
        private void tvT_IconButton2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //  public void LoadToGrid
    }
}
