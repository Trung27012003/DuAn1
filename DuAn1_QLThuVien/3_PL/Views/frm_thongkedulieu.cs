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
    public partial class frm_thongkedulieu : Form
    {
        ISachServices _ISachServices;
        ITheLoaiServices _ITheLoaiServices;
        IPhieuMuonChiTietChiTietServices _IPhieuMuonChiTietChiTietServices;
        IPhieuTraChiTietServices _IPhieuTraChiTietServices;
        IPhieuMuonServices _IPhieuMuonServices;
        IPhieuTraServices _IPhieuTraServices;
        ITheThanhVienServices _ITheThanhVienServices;
        INhanVienServices _INhanVienServices;
        List<PhieuMuonChiTietView> _lstPMCT;
        List<PhieuTraChiTietView> _lstPTCT;
        List<PhieuTraView> _lstPT;
        List<PhieuMuonView> _lstPM;
        List<SachView> _lstSach;
        Guid _CurrentId;
        
        public frm_thongkedulieu()
        {
            InitializeComponent();
            LoadToCmb();
            _ISachServices = new SachServices();
            _ITheLoaiServices = new TheLoaiServices();
            _IPhieuMuonChiTietChiTietServices = new PhieuMuonChiTietServices();
            _IPhieuTraChiTietServices = new PhieuTraChiTietServices();
            _IPhieuMuonServices = new PhieuMuonServices();
            _IPhieuTraServices = new PhieuTraServices();
            _ITheThanhVienServices = new TheThanhVienServices();
            _INhanVienServices = new NhanVienServices();
            _lstPMCT = new List<PhieuMuonChiTietView>();
            _lstPTCT = new List<PhieuTraChiTietView>();
            _lstPM = new List<PhieuMuonView>();
            _lstPT = new List<PhieuTraView>();
            _lstSach = new List<SachView>();
            _lstPMCT = _IPhieuMuonChiTietChiTietServices.GetPhieuMuonChiTiet();
            _lstPTCT = _IPhieuTraChiTietServices.GetPhieuTraChiTiet();
            _lstPM = _IPhieuMuonServices.GetPhieuMuon();
            _lstPT = _IPhieuTraServices.GetPhieuTra();
            _lstSach = _ISachServices.GetSach();
        }
        public void LoadToCmb()
        {
            cmb_loc.Items.Clear();
            cmb_locpm.Items.Clear();    
            cmb_loc.Items.Add("Số sách tồn");
            cmb_loc.Items.Add("Số sách đã cho mượn");
            cmb_loc.Items.Add("Số sách từng cho mượn");
            cmb_locpm.Items.Add("Phiếu mượn");
            cmb_locpm.Items.Add("Phiếu Trả");


        }
        public void LoadToGridShow1(dynamic lst)
        {
            
            int stt = 1;
            dgrid_show2.Rows.Clear();
            dgrid_show2.ColumnCount = 7;
            dgrid_show2.Columns[0].Name = "Id";
            dgrid_show2.Columns[1].Name = "STT";
            dgrid_show2.Columns[2].Name = "Tên sách";
            dgrid_show2.Columns[3].Name = "Tác giả";
            dgrid_show2.Columns[4].Name = "Thể loại";
            dgrid_show2.Columns[5].Name = "NXB";
            dgrid_show2.Columns[6].Name = "Số lượng";
            dgrid_show2.Columns[0].Visible = false;
            dgrid_show2.Columns[1].Width = 50;
            //dgrid_show2.Columns[2].Width = 200;
            //dgrid_show2.Columns[3].Width = 200;
            //dgrid_show2.Columns[4].Width = 200;
            //dgrid_show2.Columns[5].Width = 200;
            //dgrid_show2.Columns[6].Width = 200;
            dgrid_show2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_show2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgrid_show2.AllowUserToResizeColumns = false;
            foreach (var item in lst)
            {
                if (item.SoLuong>0)
                {
                    var sach = _ISachServices.GetSach().FirstOrDefault(c => c.Id == item.IdSach);
                    var tl = _ITheLoaiServices.GetAllTL().FirstOrDefault(c => c.Id == sach.IdTL).Name;
                    dgrid_show2.Rows.Add(item.Id, stt++, sach.Name, sach.TG, tl, sach.NXB, item.SoLuong);
                }
            }
        }
        public void LoadToGridSach(List<SachView> lst)
        {

            int stt = 1;
            dgrid_show2.Rows.Clear();
            dgrid_show2.ColumnCount = 7;
            dgrid_show2.Columns[0].Name = "Id";
            dgrid_show2.Columns[1].Name = "STT";
            dgrid_show2.Columns[2].Name = "Tên sách";
            dgrid_show2.Columns[3].Name = "Tác giả";
            dgrid_show2.Columns[4].Name = "Thể loại";
            dgrid_show2.Columns[5].Name = "NXB";
            dgrid_show2.Columns[6].Name = "Số lượng";
            dgrid_show2.Columns[0].Visible = false;
            dgrid_show2.Columns[1].Width = 50;
            dgrid_show2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_show2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgrid_show2.AllowUserToResizeColumns = false;
            foreach (var item in lst)
            {
                if (item.SoLuong > 0)
                {
                   
                    var tl = _ITheLoaiServices.GetAllTL().FirstOrDefault(c => c.Id == item.IdTL).Name;
                    dgrid_show2.Rows.Add(item.Id, stt++, item.Name, item.TG, tl, item.NXB, item.SoLuong);
                }
            }
        }

        private void cmb_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_loc.SelectedIndex ==0)
            {
                LoadToGridSach(_lstSach);
                dgrid_show1.Rows.Clear();
            }
            if (cmb_loc.SelectedIndex ==1)
            {
                LoadToGridShow1(_lstPMCT);
                dgrid_show1.Rows.Clear();
            }
            if (cmb_loc.SelectedIndex ==2)
            {
                LoadToGridShow1(_lstPTCT);
                dgrid_show1.Rows.Clear();
            }
           
        }

        private void tbx_locpm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_locpm.SelectedIndex==0)
            {
                LoadToGrid_pm(_lstPM);
                
            }
            if (cmb_locpm.SelectedIndex==1)
            {
                LoadToGrid_pt(_lstPT);

            }
            
        }
        public void LoadToGrid_pm(List<PhieuMuonView> lst)
        {

            int stt = 1;
            dgrid_show1.Rows.Clear();
            dgrid_show1.ColumnCount = 6;
            dgrid_show1.Columns[0].Name = "Id";
            dgrid_show1.Columns[1].Name = "STT";
            dgrid_show1.Columns[2].Name = "Tên Người mượn";
            dgrid_show1.Columns[3].Name = "Tên nhân viên";
            dgrid_show1.Columns[4].Name = "Ngày mượn";
            dgrid_show1.Columns[5].Name = "Ghi chú";
            dgrid_show1.Columns[0].Visible = false;
            dgrid_show1.Columns[1].Width = 50;
            dgrid_show1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_show1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            foreach (var item in lst)
            {
                var a = _ITheThanhVienServices.GetTheThanhVien().FirstOrDefault(c=>c.Id==item.IdTheTV).TenThanhVien;
                var b = _INhanVienServices.GetAllNv().FirstOrDefault(c=>c.Id==item.IdNV).Name;
                dgrid_show1.Rows.Add(item.Id, stt++, a, b, item.NgayMuon, item.GhiChu);
            }
        }
        public void LoadToGrid_pt(List<PhieuTraView> lst)
        {

            int stt = 1;
            dgrid_show1.Rows.Clear();
            dgrid_show1.ColumnCount = 6;
            dgrid_show1.Columns[0].Name = "Id";
            dgrid_show1.Columns[1].Name = "STT";
            dgrid_show1.Columns[2].Name = "Tên Người mượn";
            dgrid_show1.Columns[3].Name = "Tên nhân viên";
            dgrid_show1.Columns[4].Name = "Ngày trả";
            dgrid_show1.Columns[5].Name = "Ghi chú";
            dgrid_show1.Columns[0].Visible = false;
            dgrid_show1.Columns[1].Width = 50;
            dgrid_show1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_show1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgrid_show1.AllowUserToResizeColumns = false;
            foreach (var item in lst)
            {
                var tentv =_ITheThanhVienServices.GetTheThanhVien().FirstOrDefault(c=>c.Id == _IPhieuMuonServices.GetPhieuMuon().FirstOrDefault(c => c.Id == item.IdPM).IdTheTV).TenThanhVien;
                var tennv = _INhanVienServices.GetAllNv().FirstOrDefault(c => c.Id == _IPhieuMuonServices.GetPhieuMuon().FirstOrDefault(c => c.Id == item.IdPM).IdNV).Name;
                dgrid_show1.Rows.Add(item.Id, stt++, tentv, tennv, item.NgayTra, item.GhiChu);  
            }
        }

        private void dgrid_show1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _CurrentId = Guid.Parse(dgrid_show1.CurrentRow.Cells[0].Value.ToString());
            if (cmb_locpm.SelectedIndex==0)
            {
                _lstPMCT = _IPhieuMuonChiTietChiTietServices.GetPhieuMuonChiTiet().FindAll(c => c.IdPM == _CurrentId);
                LoadToGridShow1(_lstPMCT);
            }
            if (cmb_locpm.SelectedIndex == 1)
            {
                _lstPTCT = _IPhieuTraChiTietServices.GetPhieuTraChiTiet().FindAll(c => c.IdPT == _CurrentId);
                LoadToGridShow1(_lstPTCT);
            }
        }
    }
}
