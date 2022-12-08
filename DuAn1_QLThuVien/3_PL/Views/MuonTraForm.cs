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
namespace _3_PL.Views
{
    public partial class MuonTraForm : Form
    {
        ISachServices _IsachServices;
        ITheLoaiServices _ITheLoaiServices;
        ITheThanhVienServices _ITheThanhVienServices;
        List<SachView> _lstSachView;
        List<SachView> _lstSachView1;
        List<PhieuMuonChiTietView> _lstPMCT;
        List<PhieuMuonChiTietView> _lstPM;
        Guid _IDSach;
        Guid _IdPMCT;
        Guid _IDPM;
        public MuonTraForm()
        {
            InitializeComponent();
            _IsachServices = new SachServices();
            _ITheLoaiServices = new TheLoaiServices();
            _ITheThanhVienServices = new TheThanhVienServices();
            _lstSachView1 = new List<SachView>();
            _lstSachView = new List<SachView>();
            _lstPMCT = new List<PhieuMuonChiTietView>();
            _lstPM = new List<PhieuMuonChiTietView>();
            _lstSachView = _IsachServices.GetSach();
            LoadToGrid_Sach(_lstSachView);
            LoadToCmbTL();

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
                     x.Id, stt++,_ITheLoaiServices.GetAllTL().FirstOrDefault(c=>c.Id==x.IdTL).Name, x.TG, x.Name, x.SoLuong);
            }

        }
        public void LoadToPhieuMuonCT()
        {
            {
                dgrid_phieumuonchitiet.Rows.Clear();
                dgrid_phieumuonchitiet.ColumnCount = 6;
                dgrid_phieumuonchitiet.Columns[0].Name = "Id";
                dgrid_phieumuonchitiet.Columns[1].Name = "STT";
                dgrid_phieumuonchitiet.Columns[2].Name = "Tên sách";
                dgrid_phieumuonchitiet.Columns[3].Name = "Số lượng";
                dgrid_phieumuonchitiet.Columns[4].Name = "Điều kiện";
                dgrid_phieumuonchitiet.Columns[5].Name = "Tiền thế chân";
                dgrid_phieumuonchitiet.Columns[0].Visible = false;
                int stt = 1;
                foreach (var item in _lstPMCT)
                {
                    dgrid_phieumuonchitiet.Rows.Add(
                        item.Id,
                        stt++,
                        _IsachServices.GetSach().FirstOrDefault(c => c.Id == item.IdSach).Name,
                        item.SoLuong,
                        item.DieuKien,
                        item.TienTheChan);
                }
                TongTien1(lbl_tongtien1, _lstPMCT);
            }

        }

        public void LoadToPhieuMuon()
        {
            {
                dgrid_doncho.Rows.Clear();
                dgrid_doncho.ColumnCount = 6;
                dgrid_doncho.Columns[0].Name = "Id";
                dgrid_doncho.Columns[1].Name = "STT";
                dgrid_doncho.Columns[2].Name = "Tên sách";
                dgrid_doncho.Columns[3].Name = "Số lượng";
                dgrid_doncho.Columns[4].Name = "Điều kiện";
                dgrid_doncho.Columns[5].Name = "Tiền thế chân";
                dgrid_doncho.Columns[0].Visible = false;
                int stt = 1;
                foreach (var item in _lstPM)
                {
                    dgrid_doncho.Rows.Add(
                        item.Id,
                        stt++,
                        _IsachServices.GetSach().FirstOrDefault(c => c.Id == item.IdSach).Name,
                        item.SoLuong,
                        item.DieuKien,
                        item.TienTheChan);
                }
                TongTien1(lbl_tongtien2, _lstPM);
            }

        }

        public void AddPMCT(Guid Id)
        {

            var sach = _IsachServices.GetSach().FirstOrDefault(c => c.Id == Id);
            var data = _lstPMCT.FirstOrDefault(c => c.IdSach == sach.Id);

            PhieuMuonChiTietView pmctv = new PhieuMuonChiTietView()
            {
                IdSach = sach.Id,
                DieuKien = sach.GhiChu,
                SoLuong = 1,
                TienTheChan = sach.GiaTien / 2,
            };
            _lstPMCT.Add(pmctv);
            if (data != null)

            {
                if (data.SoLuong == sach.SoLuong)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                    var a = _lstPMCT.Find(c => c.SoLuong < c.SoLuong || c.SoLuong == 1);
                    _lstPMCT.Remove(a);
                    LoadToPhieuMuonCT();
                }
                else
                {
                    data.SoLuong++;
                    data.TienTheChan = sach.GiaTien * data.SoLuong / 2;
                    var a = _lstPMCT.Find(c => c.SoLuong < c.SoLuong || c.SoLuong == 1);
                    _lstPMCT.Remove(a);
                    LoadToPhieuMuonCT();
                }
            }
            LoadToPhieuMuonCT();


        }
        private void tvT_IconButton2_Click(object sender, EventArgs e)
        {

        }

        private void dgrid_danhsachsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _IDSach = Guid.Parse(dgrid_danhsachsach.CurrentRow.Cells[0].Value.ToString());
            AddPMCT(_IDSach);
        }

        private void dgrid_phieumuonchitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _IdPMCT = Guid.Parse(dgrid_phieumuonchitiet.CurrentRow.Cells[0].Value.ToString());

        }

        private void dgrid_doncho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _IDPM = Guid.Parse(dgrid_doncho.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (_lstPMCT.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sách!");
            }
            else
            {
                _lstPM = _lstPMCT;
                LoadToPhieuMuon();
                LoadToPhieuMuonCT();
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
            if (_IDPM != null)
            {
                _lstPM.Remove(pm);
                LoadToPhieuMuon();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            lbl_tongtien1.Text = "";
            lbl_tongtien2.Text = "";
            _lstPM.Clear();
            _lstPMCT.Clear();
            LoadToPhieuMuon();
            LoadToPhieuMuonCT();
            LoadToGrid_Sach(_IsachServices.GetSach());
            tbx_search.Text = "";
            cmb_loc.Text = "";
            cmb_tenkh.Text = "";
            dtp_ngaytra.Value = DateTime.Now + TimeSpan.FromDays(7);

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
            FormCheckQR formCheckQR = new FormCheckQR();
            formCheckQR.ShowDialog();
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            ptb_camera.Image = (Bitmap)eventArgs.Frame.Clone();
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

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ptb_camera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result resul = reader.Decode((Bitmap)ptb_camera.Image);
                if (resul != null)
                {

                    if (CaptureDevice.IsRunning == true)
                    {
                        rtb_show.Text = resul.ToString();
                        timer1.Stop();

                    }
                }
            }
        }


    }
}
