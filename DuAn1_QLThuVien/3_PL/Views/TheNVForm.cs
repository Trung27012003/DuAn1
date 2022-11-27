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
    public partial class TheNVForm : Form
    {
        Guid _IdCv;
        Guid _IdNv;
        List<ChucVuView> _lstChucVuViews;
        List<NhanVienView> _lstNhanVienView;
        ChucVuServices _ChucVuServices;
        NhanVienServices _NhanVienServices;

        public TheNVForm()
        {
            
            InitializeComponent();
            _ChucVuServices = new ChucVuServices();
            _lstChucVuViews = new List<ChucVuView>();
            _lstNhanVienView = new List<NhanVienView>();
            _lstChucVuViews = _ChucVuServices.GetTheNgay();
            //_lstNhanVienView = _NhanVienServices.GetAllNv();
            //LoadToGridNv(_lstNhanVienView);
            LoadToGridCv(_lstChucVuViews);


            Loadtocbb();

        }
        private void Loadtocbb()
        {
            cbb_tenchucvu.Items.Clear();
            foreach (var item in _ChucVuServices.GetTheNgay())
            {
                cbb_tenchucvu.Items.Add(item.Name);
            }
        }
        //private void LoadToGridNv(List<NhanVienView> lst)
        //{
        //    int stt = 1;
        //    dgrid_show.Rows.Clear();
        //    dgrid_show.ColumnCount = 7;
        //    dgrid_show.Columns[0].Name = "ID";
        //    dgrid_show.Columns[0].Visible = false;
        //    dgrid_show.Columns[1].Name = "STT";
        //    dgrid_show.Columns[2].Name = "Tên";
        //    dgrid_show.Columns[3].Name = "Chức vụ";
        //    dgrid_show.Columns[4].Name = "Địa chỉ";
        //    dgrid_show.Columns[5].Name = "Sdt";
        //    dgrid_show.Columns[6].Name = "Ngày sinh";
        //    foreach (var item in lst)
        //    {
        //        dgrid_shownv.Rows.Add(
        //            item.Id,
        //            stt++, 
        //            item.Name,
        //            _ChucVuServices.GetTheNgay().FirstOrDefault(c=>c.Id==item.IdCV).Name,
        //            item.DiaChi,
        //            item.SDT,
        //            item.NgaySinh
        //            );
        //    }
        //}
        private void LoadToGridCv(List<ChucVuView> lst)
        {
            int stt = 1;
            dgrid_show.Rows.Clear();
            dgrid_show.ColumnCount = 3;
            dgrid_show.Columns[0].Name = "ID";
            dgrid_show.Columns[0].Visible = false;
            dgrid_show.Columns[1].Name = "STT";
            dgrid_show.Columns[2].Name = "Name";
            foreach (var item in lst)
            {
                dgrid_show.Rows.Add(item.Id,stt++,item.Name);
            }
        }

        private void dgrid_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _IdCv = (Guid)dgrid_show.CurrentRow.Cells[0].Value;
            tbx_tencv.Text = dgrid_show.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ChucVuView cvv = new ChucVuView()
            {
               
                Name = tbx_tencv.Text,
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_ChucVuServices.AddTN(cvv));
                _lstChucVuViews = _ChucVuServices.GetTheNgay();
                LoadToGridCv(_lstChucVuViews);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ChucVuView cvv = new ChucVuView()
            {
                Id = _IdCv,
                Name = tbx_tencv.Text,
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_ChucVuServices.UpdateTN(cvv));
                _lstChucVuViews = _ChucVuServices.GetTheNgay();
                LoadToGridCv(_lstChucVuViews);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_ChucVuServices.RemoveTN(_IdCv));
                _lstChucVuViews = _ChucVuServices.GetTheNgay();
                LoadToGridCv(_lstChucVuViews);
            }
        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {

        }
    }
}
