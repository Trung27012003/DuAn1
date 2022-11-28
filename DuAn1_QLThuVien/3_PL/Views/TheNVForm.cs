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
        IChucVuServices _ChucVuServices;
        INhanVienServices _NhanVienServices;

        public TheNVForm()
        {
            
            InitializeComponent();
            _ChucVuServices = new ChucVuServices();
            _NhanVienServices = new NhanVienServices();
            _lstChucVuViews = new List<ChucVuView>();
            _lstNhanVienView = new List<NhanVienView>();
            _lstChucVuViews = _ChucVuServices.GetTheNgay();
            _lstNhanVienView = _NhanVienServices.GetAllNv();
            LoadToGridNv(_lstNhanVienView);
            LoadToGridCv(_lstChucVuViews);
            Loadtocbb();

        }
       public void LoadToGridNv(List<NhanVienView> lst)
        {

            dgrid_shownv.Rows.Clear();
            int stt = 1;
            dgrid_shownv.ColumnCount = 7;
            dgrid_shownv.Columns[0].Name = "Id";
            dgrid_shownv.Columns[0].Visible = false;
            dgrid_shownv.Columns[1].Name = "Stt";
            dgrid_shownv.Columns[2].Name = "Tên";
            dgrid_shownv.Columns[3].Name = "Chức vụ";
            dgrid_shownv.Columns[4].Name = "Địa Chỉ";
            dgrid_shownv.Columns[5].Name = "SDT";
            dgrid_shownv.Columns[6].Name = "Ngày Sinh";
            foreach (var item in lst)
            {
                dgrid_shownv.Rows.Add(
                    item.Id,
                    stt++,
                    item.Name,
                    (item.IdCV!=null)?_ChucVuServices.GetTheNgay().FirstOrDefault(c=>c.Id==item.IdCV).Name:" ",
                    item.DiaChi,
                    item.SDT,
                    item.NgaySinh
                    );
            }
        }


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
        private void Loadtocbb()
        {
            cbb_tenchucvu.Items.Clear();
            foreach (var item in _ChucVuServices.GetTheNgay())
            {
                cbb_tenchucvu.Items.Add(item.Name);
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
            Loadtocbb();
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
            Loadtocbb();
            _lstNhanVienView = _NhanVienServices.GetAllNv();
            LoadToGridNv(_lstNhanVienView);
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
            Loadtocbb();
            _lstNhanVienView = _NhanVienServices.GetAllNv();
            LoadToGridNv(_lstNhanVienView);
        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            NhanVienView cvv = new NhanVienView()
            {
                
                Name = tbx_tennv.Text,
                NgaySinh = DateTime.Now,
                DiaChi = tbx_diachi.Text,
                SDT = tbx_sdt.Text,
                IdCV =_ChucVuServices.GetTheNgay().FirstOrDefault(c=>c.Name==cbb_tenchucvu.Text).Id 
            };
            DialogResult dg = MessageBox.Show("bạn có chắc chắn muốn thêm không ?", "thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_NhanVienServices.AddTN(cvv));
                _lstNhanVienView = _NhanVienServices.GetAllNv();
                LoadToGridNv(_lstNhanVienView);
            }
        }

       

        private void btn_suanv_Click(object sender, EventArgs e)
        {

            NhanVienView cvv = new NhanVienView()
            {
                Id= _IdNv,
                Name = tbx_tennv.Text,
                NgaySinh = DateTime.Now,
                DiaChi = tbx_diachi.Text,
                SDT = tbx_sdt.Text,
                IdCV = _ChucVuServices.GetTheNgay().FirstOrDefault(c => c.Name == cbb_tenchucvu.Text).Id
            };
            DialogResult dg = MessageBox.Show("bạn có chắc chắn muốn sửa không ?", "thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_NhanVienServices.UpdateTN(cvv));
                _lstNhanVienView = _NhanVienServices.GetAllNv();
                LoadToGridNv(_lstNhanVienView);
            }
        }

        private void btn_xoanv_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("bạn có chắc chắn muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_NhanVienServices.RemoveTN(_IdNv));
                _lstNhanVienView = _NhanVienServices.GetAllNv();
                LoadToGridNv(_lstNhanVienView);
            }
        }

        private void tbx_searchnv_TextChanged(object sender, EventArgs e)
        {
            var search = _NhanVienServices.GetAllNv().FindAll(c => c.Name.ToLower().Contains(tbx_searchnv.Text.ToLower()) ||c.DiaChi.ToLower().Contains(tbx_searchnv.Text.ToLower()));
            if (search != null)
            {
                LoadToGridNv(search);
            }
        }

        private void TheNVForm_Load(object sender, EventArgs e)
        {

        }

        private void dgrid_shownv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _IdNv = Guid.Parse(dgrid_shownv.CurrentRow.Cells[0].Value.ToString());
            tbx_tennv.Text = dgrid_shownv.CurrentRow.Cells[2].Value.ToString();
            cbb_tenchucvu.Text = dgrid_shownv.CurrentRow.Cells[3].Value.ToString();
            tbx_diachi.Text = dgrid_shownv.CurrentRow.Cells[4].Value.ToString();
            tbx_sdt.Text = dgrid_shownv.CurrentRow.Cells[5].Value.ToString();
            dtp_ngaysinh.Text = dgrid_shownv.CurrentRow.Cells[6].Value.ToString();
            

        }
    }
}

