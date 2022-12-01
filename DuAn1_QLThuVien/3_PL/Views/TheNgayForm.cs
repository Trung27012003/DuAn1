using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
namespace _3_PL.Views
{
    public partial class TheNgayForm : Form
    {
        Guid id;
        List<TheNgayView> theNgayViews;
        List<NhanVienView> _nvviews;
        INhanVienServices _NhanVienServices;
        ITheNgayServices _ITheNgayServices;
        public TheNgayForm()
        {
            InitializeComponent();
            _ITheNgayServices = new TheNgayServices();
            _NhanVienServices = new NhanVienServices();
            _nvviews = new List<NhanVienView>();
            theNgayViews = new List<TheNgayView>();
            LoadToDTG(theNgayViews);
            LoadTocbb();
        }
        private void LoadToDTG(List<TheNgayView> list)
        {
            dtg_show.Rows.Clear();
            int stt = 1;
            dtg_show.ColumnCount = 5;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "MÃ Nhân viên";
            dtg_show.Columns[3].Name = "Ngày bắt đầu";
            dtg_show.Columns[4].Name = "Ngày kết thúc";

            foreach(var view in list)
            {
                dtg_show.Rows.Add(view.Id, stt++, (view.IdNV != null) ? _NhanVienServices.GetAllNv().FirstOrDefault(c => c.Id == view.IdNV).Name : " ", view.StartTime, view.EndTime);
            }

        }

        private void LoadTocbb()
        {
            cbb_nhanvien.Items.Clear();
            foreach(var item in _NhanVienServices.GetAllNv())
            {
                cbb_nhanvien.Items.Add(item.Name);
            }
        }
        private void btn_in_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đi mua cái máy in về đây rồi tính tiếp !!!");
        }
    }
}
