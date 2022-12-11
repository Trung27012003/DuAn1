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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.IO;
using ZXing.Aztec;
using AForge;
using ZXing.QrCode;
using _1_DAL.Models;

namespace _3_PL.Views
{
    public partial class MuonTraForm : Form
    {
        ISachServices _IsachServices;
        ITheLoaiServices _ITheLoaiServices;
        ITheThanhVienServices _ITheThanhVienServices;
        IPhieuMuonServices _IPhieuMuonServices;
        IPhieuMuonChiTietChiTietServices _IPhieuMuonChiTietChiTietServices;
        IPhieuTraServices _IPhieuTraServices;
        IPhieuTraChiTietServices _IPhieuTraChiTietServices;
        INhanVienServices _INhanVienServices;

        List<SachView> _lstSachView;
        List<SachView> _lstSachView1;
        List<PhieuMuonChiTietView> _lstPMCT;
        List<PhieuMuonChiTietView> _lstPM;
        List<PhieuTraChiTietView> _lstPTCT;
        Guid _IDSach;
        Guid _IdPMCT;
        Guid _IDPM;
        Guid _IDPT;
        Label text;
        public MuonTraForm()
        {
            InitializeComponent();
            _IsachServices = new SachServices();
            _ITheLoaiServices = new TheLoaiServices();
            _ITheThanhVienServices = new TheThanhVienServices();
            _IPhieuMuonServices = new PhieuMuonServices();
            _IPhieuMuonChiTietChiTietServices = new PhieuMuonChiTietServices();
            _IPhieuTraServices = new PhieuTraServices();
            _IPhieuTraChiTietServices = new PhieuTraChiTietServices();
            _INhanVienServices = new NhanVienServices();
            _lstSachView1 = new List<SachView>();
            _lstSachView = new List<SachView>();
            _lstPMCT = new List<PhieuMuonChiTietView>();
            _lstPM = new List<PhieuMuonChiTietView>();
            _lstPTCT = new List<PhieuTraChiTietView>();

            _lstSachView = _IsachServices.GetSach();
            Loadtogrid_PhieuTra();
            LoadToGrid_Sach(_lstSachView);
            LoadToCmbTL();
            btn_resets_Click(null,null);

        }

        // ============FORM MƯỢN =============================================//

        public void TongTien1(Label a, dynamic lst)
        {
            if (_lstPMCT != null)
            {
                double tongtien = 0;
                foreach (var item in lst)
                {
                    tongtien += (double)(item.TienTheChan);
                }
                a.Text = tongtien.ToString();
            }
            else
            {
                lbl_tongtien1.Text = "";
            }
        }
        public void LoadToCmbTL()
        {
            cmb_loc.Items.Clear();
            cmb_loc.Items.Add("Tất cả");
            foreach (var item in _ITheLoaiServices.GetAllTL())
            {
                cmb_loc.Items.Add(item.Name);
            }
            cmb_tenkh.Items.Clear();
            foreach (var item in _ITheThanhVienServices.GetTheThanhVien())
            {
                cmb_tenkh.Items.Add(item.TenThanhVien);
            }
            cmb_nhanvien.Items.Clear();
            foreach (var item in _INhanVienServices.GetAllNv())
            {
                cmb_nhanvien.Items.Add(item.Name);
            }
        }
        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            if (cmb_loc.Text == "" || cmb_loc.Text == "Tất cả")
            {
                _lstSachView = _IsachServices.GetSach().FindAll(c => c.Name.ToLower().Contains(tbx_search.Text.ToLower()));
                LoadToGrid_Sach(_lstSachView);
            }
            else
            {
                var a = _lstSachView1.FindAll(c => c.Name.ToLower().Contains(tbx_search.Text.ToLower()));
                LoadToGrid_Sach(a);
            }
        }
        private void cmb_loc_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_loc.Text == "Tất cả")
            {
                _lstSachView = _IsachServices.GetSach();
                LoadToGrid_Sach(_lstSachView);
            }
            else
            {
                var getId = _ITheLoaiServices.GetAllTL().FirstOrDefault(x => x.Name == cmb_loc.Text).Id;
                _lstSachView1 = _IsachServices.GetSach().FindAll(c => c.IdTL == getId);
                LoadToGrid_Sach(_lstSachView1);
            }

        }
        public void LoadToGrid_Sach(List<SachView> s)
        {

            dgrid_danhsachsach.Rows.Clear();
            dgrid_danhsachsach.ColumnCount = 7;
            dgrid_danhsachsach.Columns[0].Name = "Id";
            dgrid_danhsachsach.Columns[1].Name = "STT";
            dgrid_danhsachsach.Columns[2].Name = "Tên sách";
            dgrid_danhsachsach.Columns[3].Name = "Mã sách";
            dgrid_danhsachsach.Columns[4].Name = "Thể loại";
            dgrid_danhsachsach.Columns[5].Name = "Tác giả";
            dgrid_danhsachsach.Columns[6].Name = "Số lượng";
            dgrid_danhsachsach.Columns[0].Visible = false;
            dgrid_danhsachsach.Columns[1].Width = 50;
            dgrid_danhsachsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_danhsachsach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgrid_danhsachsach.AllowUserToResizeColumns = false;
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "Add";
                button.HeaderText = "Add";

                button.Text = ("Add");
                button.UseColumnTextForButtonValue = true;
                dgrid_danhsachsach.Columns.Add(button);
            }
            int stt = 1;
            foreach (var x in s)
            {
                if (x.SoLuong != 0)
                {
                    dgrid_danhsachsach.Rows.Add(
                    x.Id, stt++, x.Name, x.Ma, _ITheLoaiServices.GetAllTL().FirstOrDefault(c => c.Id == x.IdTL).Name, x.TG, x.SoLuong);
                }
            }
        }
        public void LoadToPhieuMuonCT()
        {
            {
                dgrid_phieumuonchitiet.Rows.Clear();
                dgrid_phieumuonchitiet.ColumnCount = 7;
                dgrid_phieumuonchitiet.Columns[0].Name = "Id";
                dgrid_phieumuonchitiet.Columns[1].Name = "STT";
                dgrid_phieumuonchitiet.Columns[2].Name = "Tên sách";
                dgrid_phieumuonchitiet.Columns[3].Name = "Mã sách";
                dgrid_phieumuonchitiet.Columns[4].Name = "Số lượng";
                dgrid_phieumuonchitiet.Columns[5].Name = "Điều kiện";
                dgrid_phieumuonchitiet.Columns[6].Name = "Tiền thế chân";
                dgrid_phieumuonchitiet.Columns[0].Visible = false;
                dgrid_phieumuonchitiet.Columns[1].Width = 50;
                dgrid_phieumuonchitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgrid_phieumuonchitiet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgrid_phieumuonchitiet.AllowUserToResizeColumns = false;
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "Delete";
                    button.HeaderText = "Delete";
                    button.Text = ("Delete");
                    button.UseColumnTextForButtonValue = true;
                    dgrid_phieumuonchitiet.Columns.Add(button);
                }
                int stt = 1;
                foreach (var item in _lstPMCT)
                {
                    dgrid_phieumuonchitiet.Rows.Add(
                        item.Id,
                        stt++,
                        _IsachServices.GetSach().FirstOrDefault(c => c.Id == item.IdSach).Name,
                       _IsachServices.GetSach().FirstOrDefault(c => c.Id == item.IdSach).Ma,
                        item.SoLuong,
                        item.DieuKien,
                        item.TienTheChan);
                }
                TongTien1(lbl_tongtien1, _lstPMCT);
            }

        }
        public void AddPMCT(Guid Id)
        {

            var sach = _IsachServices.GetSach().FirstOrDefault(c => c.Id == Id);
            var data = _lstPMCT.FirstOrDefault(c => c.IdSach == sach.Id);
            
            if (data != null)
            {
                foreach (var item in _lstPMCT)
                {
                    soluong += Convert.ToInt32(item.SoLuong);
                }
                if (sach.SoLuong == 0)
                {
                    MessageBox.Show("Sản phẩm đã hết");
                }
                else if (soluong > 3)
                {
                    MessageBox.Show("Mỗi thành viên chỉ được mượn tối đa 3 quyển");
                    //var a = _lstPMCT.Find(c => c.SoLuong < c.SoLuong || c.SoLuong == 1);
                    //_lstPMCT.Remove(a);
                    //LoadToPhieuMuonCT();
                    soluong = 3;
                }
                else if (data.SoLuong == sach.SoLuong)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                    //var a = _lstPMCT.Find(c => c.SoLuong < c.SoLuong || c.SoLuong == 1);
                    //_lstPMCT.RemoveAll(c => c.SoLuong < c.SoLuong || c.SoLuong == 1);
                    //LoadToPhieuMuonCT();
                    soluong = 3;
                }
                else
                {
                    data.SoLuong++;
                    data.TienTheChan = sach.GiaTien * data.SoLuong / 2;
                    //_lstPMCT.RemoveAll(c => c.SoLuong < c.SoLuong || c.SoLuong == 1);

                    LoadToPhieuMuonCT();
                }
            }
            else
            {
                foreach (var item in _lstPMCT)
                {
                    soluong += Convert.ToInt32(item.SoLuong);
                }
                if (soluong <= 3)
                {
                    PhieuMuonChiTietView pmctv = new PhieuMuonChiTietView()
                    {
                        IdSach = sach.Id,
                        DieuKien = sach.GhiChu,
                        SoLuong = 1,
                        TienTheChan = sach.GiaTien / 2,
                    };
                    _lstPMCT.Add(pmctv);
                }
                else
                {
                    MessageBox.Show("Mỗi thành viên chỉ được mượn tối đa 3 quyển");
                }
            }
            LoadToPhieuMuonCT();
        }
        private void tvT_IconButton2_Click(object sender, EventArgs e)
        {

        }
        int soluong = 0;
        private void dgrid_danhsachsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _IDSach = Guid.Parse(dgrid_danhsachsach.CurrentRow.Cells[0].Value.ToString());
            var indexColumn = e.ColumnIndex;
            if (indexColumn == 7)
            {
                    AddPMCT(_IDSach);
            }

        }

        private void dgrid_phieumuonchitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var tensach = dgrid_phieumuonchitiet.CurrentRow.Cells[2].Value.ToString();
            var ids = _IsachServices.GetSach().FirstOrDefault(c => c.Name == tensach);
            var indexColumn = e.ColumnIndex;
            if (indexColumn == 7)
            {
                
                foreach (var item in _lstPMCT)
                {
                    soluong -= Convert.ToInt32(item.SoLuong);
                }
                var pmct = _lstPMCT.FirstOrDefault(c => c.IdSach == ids.Id);
                if (pmct != null)
                {
                    _lstPMCT.Remove(pmct);
                    LoadToPhieuMuonCT();
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {

            var pm = _lstPM.FirstOrDefault(c => c.Id == _IDPM);
            var pmct = _lstPMCT.FirstOrDefault(c => c.Id == _IdPMCT);
            if (_IdPMCT != null)
            {
                _lstPMCT.Remove(pmct);
                LoadToPhieuMuonCT();
            }

        }

   

        private void btn_resets_Click(object sender, EventArgs e)
        {
  

            soluong = 0;
            lbl_tongtien1.Text = "";
            _lstPM.Clear();
            _lstPMCT.Clear();


            LoadToPhieuMuonCT();
            LoadToGrid_Sach(_IsachServices.GetSach());
            tbx_search.Text = "";
            cmb_loc.Text = "";
            tbx_tinhtrang.Text = "";
            cmb_nhanvien.Text = "";
            cmb_tenkh.Text = "";
            tbx_mapm.Text = "";
            dtp_ngaytra.Value = DateTime.Now + TimeSpan.FromDays(7);
            Loadtogrid_PhieuTra();

        }
        private void btn_reset_Click(object sender, EventArgs e)
        {

            lbl_tongtien1.Text = "";
            _lstPM.Clear();
            _lstPMCT.Clear();
            LoadToPhieuMuonCT();
            LoadToGrid_Sach(_IsachServices.GetSach());
            tbx_search.Text = "";
            cmb_loc.Text = "";
            cmb_tenkh.Text = "";
            tbx_mapm.Text = "";
            dtp_ngaytra.Value = DateTime.Now + TimeSpan.FromDays(7);
            Loadtogrid_PhieuTra();
            LoadToPhieuTraCT();

        }
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            tbx_mapm.Text ="PM"+ DateTime.Now.ToString("yyMMddHHmmss");
            var mapm = _IPhieuMuonServices.GetPhieuMuon();
            var idtv = _ITheThanhVienServices.GetTheThanhVien().FirstOrDefault(c => c.TenThanhVien == cmb_tenkh.Text);
            if (idtv != null)
            {
                mapm = _IPhieuMuonServices.GetPhieuMuon().FindAll(c => c.IdTheTV == idtv.Id&&c.GhiChu!= "Đã Trả");
            }
            if (_lstPMCT.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách");
                return;
            }
            else if (cmb_nhanvien.Text=="")
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
                return;
            }
            else if (cmb_tenkh.Text=="")
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
                return;
            }
            else if (tbx_mapm.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu mượn");
                return;
            }
            else if (mapm.Count>0)
            {
                MessageBox.Show("Bạn cần trả sách trước khi mượn");
                return;
            }
            else
            {
                var pm = new PhieuMuonView()
                {
                    IdTheTV = _ITheThanhVienServices.GetTheThanhVien().FirstOrDefault(c => c.TenThanhVien == cmb_tenkh.Text).Id,
                    IdNV = _INhanVienServices.GetAllNv().FirstOrDefault(c => c.Name == cmb_nhanvien.Text).Id,
                    MaPm = tbx_mapm.Text,
                    NgayMuon = DateTime.Now,
                    NgayTra = dtp_ngaytra.Value,
                    GhiChu = "Chưa Trả",
                };
                _IPhieuMuonServices.AddTN(pm);
                _IDPM = _IPhieuMuonServices.GetPhieuMuon().FirstOrDefault(c => c.MaPm == tbx_mapm.Text).Id;
                foreach (var item in _lstPMCT)
                {
                    item.IdPM = _IDPM;
                    item.IdSach = item.IdSach;
                    item.SoLuong = item.SoLuong;
                    item.DieuKien = item.DieuKien;
                    item.TienTheChan = item.TienTheChan;
                    item.GhiChu = "Chưa Trả";
                    _IPhieuMuonChiTietChiTietServices.AddTN(item);
                    var x = _IsachServices.GetSach().FirstOrDefault(c => c.Id == item.IdSach);
                    x.SoLuong = x.SoLuong - item.SoLuong;
                    _IsachServices.UpdateTN(x);
                }
                MessageBox.Show("Mượn sách thành công, Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!!!");
                btn_resets_Click(null, null);
            }
            //btn_resets_Click(null, null);
        }
        private void tbx_thanhtoan_Click(object sender, EventArgs e)
        {
            if (_lstPMCT.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách");
            }
            else
            {
                var pm = new PhieuMuonView()
                {
                    IdTheTV = _ITheThanhVienServices.GetTheThanhVien().FirstOrDefault(c => c.TenThanhVien == cmb_tenkh.Text).Id,
                    IdNV = _INhanVienServices.GetAllNv().FirstOrDefault(c => c.Name == cmb_nhanvien.Text).Id,
                    MaPm = tbx_mapm.Text,
                    NgayMuon = DateTime.Now,
                    NgayTra = dtp_ngaytra.Value,
                    GhiChu = "Chưa Trả",
                };
                _IPhieuMuonServices.AddTN(pm);
                _IDPM = _IPhieuMuonServices.GetPhieuMuon().FirstOrDefault(c => c.MaPm == tbx_mapm.Text).Id;
                tbx_search.Text = _IDPM.ToString();
                foreach (var item in _lstPMCT)
                {
                    item.IdPM = _IDPM;
                    item.IdSach = item.IdSach;
                    item.SoLuong = item.SoLuong;
                    item.DieuKien = item.DieuKien;
                    item.TienTheChan = item.TienTheChan;
                    item.GhiChu = "Chưa Trả";
                    _IPhieuMuonChiTietChiTietServices.AddTN(item);
                    var x = _IsachServices.GetSach().FirstOrDefault(c => c.Id == item.IdSach);
                    x.SoLuong = x.SoLuong - item.SoLuong;
                    _IsachServices.UpdateTN(x);
                }
                MessageBox.Show("Thêm thành công");
                btn_resets_Click(null,null) ;
            }
        }

        // ====================== FORM TRẢ ================================//

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice CaptureDevice;

        private void btn_batmay_Click(object sender, EventArgs e)
        {
            //if (btn_batmay.Text == "Start")
            //{
            //    CaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbb_chonanh.SelectedIndex].MonikerString);
            //    CaptureDevice.NewFrame += CaptureDevice_NewFrame;
            //    CaptureDevice.Start();
            //    timer1.Start();
            //    btn_batmay.Text = "Stop";
            //}

            //else
            //{
            //    CaptureDevice.SignalToStop();
            //    timer1.Stop();
            //    ptb_camera.Image = null;
            //    btn_batmay.Text = "Start";
            //}
            //FormCheckQR formCheckQR = new FormCheckQR();
            //formCheckQR.ShowDialog();
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();

            var result = reader.Decode(bitmap);
            if (result != null)
            {
                text.Invoke(new MethodInvoker(delegate ()
                {
                    text.Text = result.ToString();
                }));
            }
            ptb_camera.Image = bitmap;

        }

        private void MuonTraForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            CaptureDevice = new VideoCaptureDevice();
            foreach (FilterInfo device in filterInfoCollection)
                cbb_chonanh.Items.Add(device.Name);
            cbb_chonanh.SelectedIndex = 0;
        }

        private void MuonTraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CaptureDevice.IsRunning == true)
                CaptureDevice.SignalToStop();
        }

        public void Loadtogrid_PhieuTra()
        {
            
            int stt = 1;
            dgrid_phieutra.Rows.Clear();
            dgrid_phieutra.ColumnCount = 8;
            dgrid_phieutra.Columns[0].Name = "ID";
            dgrid_phieutra.Columns[0].Visible = false;
            dgrid_phieutra.Columns[1].Name = "STT";
            dgrid_phieutra.Columns[2].Name = "Tên thành viên";
            dgrid_phieutra.Columns[3].Name = "Tên nhân viên";
            dgrid_phieutra.Columns[4].Name = "Mã phiếu mượn";
            dgrid_phieutra.Columns[5].Name = "Ngày mượn";
            dgrid_phieutra.Columns[6].Name = "ngày trả";
            dgrid_phieutra.Columns[7].Name = "Ghi chú";
            dgrid_phieutra.Columns[1].Width = 50;
            dgrid_phieutra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_phieutra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgrid_phieutra.AllowUserToResizeColumns = false;
            foreach (var item in _IPhieuMuonServices.GetPhieuMuon())
            {
                int so = 0;
                var a = _IPhieuMuonChiTietChiTietServices.GetPhieuMuonChiTiet().FindAll(c => c.IdPM == item.Id);
                foreach (var x in a)
                {
                    if (x.GhiChu=="Chưa Trả")
                    {
                        so++;
                    }
                }
                if (so==0)
                {
                    
                    item.GhiChu = "Đã Trả";
                    _IPhieuMuonServices.UpdateTN(item);
                }
                if (item.GhiChu=="Chưa Trả")
                {
                    var tentv = _ITheThanhVienServices.GetTheThanhVien().FirstOrDefault(c => c.Id == item.IdTheTV).TenThanhVien;
                    var tennv = _INhanVienServices.GetAllNv().FirstOrDefault(c => c.Id == item.IdNV).Name;
                    dgrid_phieutra.Rows.Add(item.Id, stt++, tentv, tennv, item.MaPm, item.NgayMuon, item.NgayTra, item.GhiChu);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void dgrid_phieutra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _IDPT = Guid.Parse(dgrid_phieutra.CurrentRow.Cells[0].Value.ToString());
            LoadToPhieuTraCT();
        }
        public void LoadToPhieuTraCT()
        {
            int stt = 1;
            _lstPMCT= _IPhieuMuonChiTietChiTietServices.GetPhieuMuonChiTiet().FindAll(c => c.IdPM == _IDPT);
            dgrid_phieutract.Rows.Clear();
            dgrid_phieutract.ColumnCount = 9;
            dgrid_phieutract.Columns[0].Name = "ID";
            dgrid_phieutract.Columns[0].Visible = false;
            dgrid_phieutract.Columns[1].Name = "IDPM";
            dgrid_phieutract.Columns[1].Visible = false;
            dgrid_phieutract.Columns[2].Name = "STT";
            dgrid_phieutract.Columns[3].Name = "Tên sách";
            dgrid_phieutract.Columns[4].Name = "Mã sách";
            dgrid_phieutract.Columns[5].Name = "Số lượng";
            dgrid_phieutract.Columns[6].Name = "Điều kiện";
            dgrid_phieutract.Columns[7].Name = "Tiền thế chân";
            dgrid_phieutract.Columns[8].Name = "Ghi chú";
            dgrid_phieutract.Columns[2].Width = 50;
            dgrid_phieutract.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_phieutract.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgrid_phieutract.AllowUserToResizeColumns = false;
            DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            {
                cb.Name = "Xác nhận";
                dgrid_phieutract.Columns.Add(cb);
            }
            foreach (var item in _lstPMCT)
            {
                if (item.GhiChu == "Chưa Trả")
                {
                    var sach = _IsachServices.GetSach().FirstOrDefault(c => c.Id == item.IdSach);
                    dgrid_phieutract.Rows.Add(item.Id, item.IdPM, stt++, sach.Name,sach.Ma, item.SoLuong, item.DieuKien, item.TienTheChan, item.GhiChu);
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "Start")
            {
                CaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbb_chonanh.SelectedIndex].MonikerString);
                CaptureDevice.NewFrame += CaptureDevice_NewFrame;
                CaptureDevice.Start();
                timer1.Start();
                btn_start.Text = "Stop";
            }

            else
            {
                CaptureDevice.SignalToStop();
                timer1.Stop();
                ptb_camera.Image = null;
                btn_start.Text = "Start";
            }
        }

        private void dgrid_phieutract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            _IdPMCT = Guid.Parse(dgrid_phieutract.CurrentRow.Cells[0].Value.ToString());
            var a = _IPhieuMuonChiTietChiTietServices.GetPhieuMuonChiTiet().FirstOrDefault(c => c.Id == _IdPMCT);
            bool isChecked = (bool)dgrid_phieutract.CurrentRow.Cells[9].EditedFormattedValue;
            if (isChecked)
            {
                dgrid_phieutract.CurrentRow.Cells[9].Value = false;
                _lstPM.RemoveAll(c => c.Id == _IdPMCT);
            }
            if (isChecked==false)
            {
                dgrid_phieutract.CurrentRow.Cells[9].Value = true;
                _lstPM.Add(a);
            }
        }

        private void dgrid_phieutract_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_trasach_Click(object sender, EventArgs e)
        {

            if (_lstPM.Count==0)
            {
                MessageBox.Show("Bạn chưa chọn sách trả");
            }
            else if (tbx_tinhtrang.Text=="")
            {

                MessageBox.Show("Bạn chưa nhập tình trạng sách");

            }
            else
            {
                var pm = new PhieuTraView()
                {
                    IdPM = _IDPT,
                    NgayTra = DateTime.Now,
                    GhiChu = "Đã Trả",
                };
                _IPhieuTraServices.AddTN(pm);
                var getIdPT = _IPhieuTraServices.GetPhieuTra().FirstOrDefault(c => c.IdPM == _IDPT).Id;
                foreach (var item in _lstPM)
                {
                    var ptct = new PhieuTraChiTietView()
                    {
                        IdPT = getIdPT,
                        IdSach = item.IdSach,
                        SoLuong = item.SoLuong,
                        TinhTrang = tbx_tinhtrang.Text,
                        GhiChu = "Đã Trả",
                    };
                    item.GhiChu = "Đã Trả";
                    _IPhieuMuonChiTietChiTietServices.UpdateTN(item);
                    _lstPTCT.Add(ptct);
                    _IPhieuTraChiTietServices.AddTN(ptct);
                    var x = _IsachServices.GetSach().FirstOrDefault(c => c.Id == item.IdSach);
                    x.SoLuong = x.SoLuong + item.SoLuong;
                    _IsachServices.UpdateTN(x);
                }
                MessageBox.Show("Trả thành công");
                btn_resets_Click(null, null);
            }

        }

        private void lb_code_TextChanged(object sender, EventArgs e)
        {
            var a = _IsachServices.GetSach().FirstOrDefault(c => c.BarCode == lb_code.Text).Id;
            var b = _IPhieuMuonChiTietChiTietServices.GetPhieuMuonChiTiet().FirstOrDefault(c => c.IdSach == a);
            if (lb_code.Text != null)
            {
                cb_xacnhan.Checked = true;
            }
        }

        private void dgrid_phieutract_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_phieumuonchitiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
