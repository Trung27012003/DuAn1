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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using QRCoder.Exceptions;
using AForge.Video.DirectShow;
using ZXing;

namespace _3_PL.Views
{
    public partial class SachForm : Form
    {
        public ISachServices _IsachServices;
        public ITheLoaiServices _ITheLoaiServices;
        public IPhieuMuonChiTietChiTietServices _IPhieuMuonChiTietChiTietServices;
        private int stt;
        private Guid _id;
        private Guid _idTL;
        public SachForm()
        {
            InitializeComponent();
            _IsachServices = new SachServices();
            _ITheLoaiServices = new TheLoaiServices();
            _IPhieuMuonChiTietChiTietServices = new PhieuMuonChiTietServices();
            LoadTocmb();
            
        }
        private void LoadTocmb()
        {
            cmb_theLoai.Items.Clear();
            foreach (var item in _ITheLoaiServices.GetAllTL())
            {
                cmb_theLoai.Items.Add(item.Name);
            }
        }
        private void LoadDS()
        {
            stt = 1;
            dtg_showsach.Rows.Clear();
            dtg_showsach.ColumnCount = 10;
            dtg_showsach.Columns[0].Name = "STT";
            dtg_showsach.Columns[1].Name = "Id";
            dtg_showsach.Columns[2].Name = "Mã Bar";
            dtg_showsach.Columns[3].Name = "Mã";
            dtg_showsach.Columns[4].Name = "Thể loại";
            dtg_showsach.Columns[5].Name = "Tác giả";
            dtg_showsach.Columns[6].Name = "NXB";
            dtg_showsach.Columns[7].Name = "Tên sách";
            dtg_showsach.Columns[8].Name = "Số lượng";
            dtg_showsach.Columns[9].Name = "Giá tiền";
            dtg_showsach.Columns[1].Visible = false;
            dtg_showsach.Columns[2].Visible = false;
            foreach (var x in _IsachServices.GetSach())
            {
                dtg_showsach.Rows.Add(
                    stt++, x.Id, x.BarCode, x.Ma, _ITheLoaiServices.GetAllTL().FirstOrDefault(c => c.Id == x.IdTL).Name, x.TG, x.NXB, x.Name, x.SoLuong, x.GiaTien);
            }
        }
        private void LoadTL()
        {
            stt=1;
            dtg_showtl.Rows.Clear();
            dtg_showtl.ColumnCount = 3;
            dtg_showtl.Columns[0].Name = "STT";
            dtg_showtl.Columns[1].Name = "Thể loại";
            dtg_showtl.Columns[2].Name = "";
            dtg_showtl.Columns[2].Visible = false;
            foreach (var x in _ITheLoaiServices.GetAllTL())
            {
                dtg_showtl.Rows.Add(stt++,x.Name ,x.Id);
            }
        }
        private SachView GetData()
        {
            SachView sachView = new SachView();
            {
                sachView.Id = _id;
                sachView.IdTL = _ITheLoaiServices.GetAllTL().FirstOrDefault(c => c.Name == cmb_theLoai.Text).Id;
                sachView.TG = tbt_tg.Text;
                sachView.Ma = tbx_ma.Text;
                sachView.BarCode = tbx_barcode.Text;
                sachView.NXB = tbt_NXB.Text;
                sachView.Name = tbt_tensach.Text;
                sachView.GhiChu = tbx_ghichu.Text;
                sachView.SoLuong =1;
                sachView.GiaTien = Convert.ToInt32(tbt_giatien.Text);
            }return sachView;
            
        }
        private void CheckNhap()
        {
            
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            
            int a;
            if(tbx_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã sách");
            }
            if (cmb_theLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thể loại");
            }
            else if (tbt_tg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tác giả");
            }
            else if (tbt_NXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nhà xuất bản");
            }
            else if (tbt_tensach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách");
            }
            else if (!int.TryParse(tbt_soluong.Text, out a))
            {
                MessageBox.Show("Số lượng phải là số");
            }
            else if (Convert.ToInt32(tbt_soluong.Text) < 0)
            {
                MessageBox.Show("Số lượng sách phải là số dương");
            }
            else if (!int.TryParse(tbt_giatien.Text, out a))
            {
                MessageBox.Show("Giá tiền phải là số");
            }
            else if (Convert.ToInt32(tbt_giatien.Text) < 0)
            {
                MessageBox.Show("Giá tiền phải là số dương");
            }
            else
            {
                var checktl = _ITheLoaiServices.GetAllTL().FirstOrDefault(c => c.Name == cmb_theLoai.Text);
                if (checktl==null)
                {
                    TheLoaiView cvv = new TheLoaiView()
                    {

                        Name = cmb_theLoai.Text,
                    };
                    _ITheLoaiServices.AddTL(cvv);
                    LoadTocmb();
                    DialogResult dialogs = MessageBox.Show("Bạn có muốn thêm sách mới không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogs == DialogResult.Yes)
                    {
                        MessageBox.Show(_IsachServices.AddTN(GetData()));
                        LoadDS();
                        LoadTL();
                    }
                    else
                    {
                        MessageBox.Show("Đã hủy");
                    }
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Bạn có muốn thêm sách mới không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        MessageBox.Show(_IsachServices.AddTN(GetData()));
                        LoadDS();
                        LoadTL();
                    }
                    else
                    {
                        MessageBox.Show("Đã hủy");
                    }
                }
              
            }

            
        }

        private void dtg_showtl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_theLoai.Text = dtg_showtl.CurrentRow.Cells[1].Value.ToString();
            _idTL = (Guid)dtg_showtl.CurrentRow.Cells[2].Value;
            var c = _IsachServices.GetSach().Where(x => x.IdTL.Equals(_idTL)).ToList();
            dtg_showsach.Rows.Clear();
            Loadsearch(c);
        }

        private void SachForm_Load(object sender, EventArgs e)
        {
            LoadTL();
            LoadDS();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            CaptureDevice = new VideoCaptureDevice();
            foreach (FilterInfo device in filterInfoCollection)
                cbb_chonanh.Items.Add(device.Name);
            cbb_chonanh.SelectedIndex = 0;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int a;
            var b = _IsachServices.GetSach().FirstOrDefault(x => x.Name.Equals(tbt_tensach.Text));
            if (cmb_theLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thể loại");
            }
            else if (tbt_tg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tác giả");
            }
            else if (tbt_NXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nhà xuất bản");
            }
            else if (tbt_tensach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách");
            }
            else if (b != null)
            {
                MessageBox.Show("Tên sách này đã tồn tại");
            }
            else if (!int.TryParse(tbt_soluong.Text, out a))
            {
                MessageBox.Show("Số lượng phải là số");
            }else if (Convert.ToInt32(tbt_soluong.Text) < 0) 
            {
                MessageBox.Show("Số lượng sách phải là số dương");
            }
            else if (!int.TryParse(tbt_giatien.Text, out a))
            {
                MessageBox.Show("Giá tiền phải là số");
            }
            else if (Convert.ToInt32(tbt_giatien.Text)<0)
            {
                MessageBox.Show("Giá tiền phải là số dương");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhập sách không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    MessageBox.Show(_IsachServices.UpdateTN(GetData()));
                    LoadDS();
                }
                else
                {
                    MessageBox.Show("Đã hủy");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var c = _IPhieuMuonChiTietChiTietServices.GetPhieuMuonChiTiet().FirstOrDefault(x => x.IdSach == _id && x.GhiChu.Contains("Chưa Trả") );
            var d = _IPhieuMuonChiTietChiTietServices.GetPhieuMuonChiTiet().FirstOrDefault(x => x.IdSach == _id && x.GhiChu.Contains("Đã Trả"));
            if (c != null)
            {
                MessageBox.Show("Sách này đang cho mượn,không thể xóa bỏ");
            }else if (d != null)
            {
                MessageBox.Show("Sách này đã tham gia cho mượn,không thể xóa bỏ");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa sách không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    MessageBox.Show(_IsachServices.RemoveTN(_id));
                    LoadDS();
                    LoadTL();
                }
                else
                {
                    MessageBox.Show("Đã hủy");
                }
            }
            
        }

        private void dtg_showsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            _id = (Guid)dtg_showsach.CurrentRow.Cells[1].Value;
            tbx_barcode.Text = dtg_showsach.CurrentRow.Cells[2].Value.ToString();
            tbx_ma.Text = dtg_showsach.CurrentRow.Cells[3].Value.ToString();
            cmb_theLoai.Text = dtg_showsach.CurrentRow.Cells[4].Value.ToString();
            tbt_tg.Text = dtg_showsach.CurrentRow.Cells[5].Value.ToString();
            tbt_NXB.Text = dtg_showsach.CurrentRow.Cells[6].Value.ToString();
            tbt_tensach.Text = dtg_showsach.CurrentRow.Cells[7].Value.ToString();
            tbt_soluong.Text = dtg_showsach.CurrentRow.Cells[8].Value.ToString();
            tbt_giatien.Text = dtg_showsach.CurrentRow.Cells[9].Value.ToString();
        }

        private void tbt_timkiem_TextChanged(object sender, EventArgs e)
        {
            var a = _IsachServices.GetSach().Where(x => x.Name.ToLower().Contains(tbt_timkiem.Text.ToLower())).ToList();
            dtg_showsach.Rows.Clear();
            Loadsearch(a);
        }
        
        private void Loadsearch(dynamic a)
        {
            stt = 1;
            dtg_showsach.Rows.Clear();
            dtg_showsach.Rows.Clear();
            dtg_showsach.ColumnCount = 10;
            dtg_showsach.Columns[0].Name = "STT";
            dtg_showsach.Columns[1].Name = "Id";
            dtg_showsach.Columns[2].Name = "Mã Bar";
            dtg_showsach.Columns[3].Name = "Mã";
            dtg_showsach.Columns[4].Name = "Thể loại";
            dtg_showsach.Columns[5].Name = "Tác giả";
            dtg_showsach.Columns[6].Name = "NXB";
            dtg_showsach.Columns[7].Name = "Tên sách";
            dtg_showsach.Columns[8].Name = "Số lượng";
            dtg_showsach.Columns[9].Name = "Giá tiền";
            dtg_showsach.Columns[1].Visible = false;
            dtg_showsach.Columns[2].Visible = false;
            dtg_showsach.Columns[1].Visible = false;
            foreach (var x in a)
            {
                dtg_showsach.Rows.Add(
                 stt++, x.Id, x.BarCode, x.Ma, _ITheLoaiServices.GetAllTL().FirstOrDefault(c => c.Id == x.IdTL).Name, x.TG, x.NXB, x.Name, x.SoLuong, x.GiaTien); ;
            }
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice CaptureDevice;
        private void btn_QR_Click(object sender, EventArgs e)
        {
            //QRCoder.QRCodeGenerator qrcode = new QRCodeGenerator();
            //var qrtext = "Tên Sách: " + tbt_tensach.Text + "\n" + "Nhà Xuất Bản: " + tbt_NXB.Text + "\n" + "Tác Giả: " + tbt_tg.Text + "\n" + "Thể Loại: " + cmb_theLoai.Text + "\n" +"Ghi Chú: " + tbx_ghichu.Text;
            //var data = qrcode.CreateQrCode(qrtext, QRCoder.QRCodeGenerator.ECCLevel.L);
            //var code = new QRCoder.QRCode(data);
            //ptb_QR.Image = code.GetGraphic(2);

            if (btn_start.Text == "Start")
            {
                CaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbb_chonanh.SelectedIndex].MonikerString);
                CaptureDevice.NewFrame += CaptureDevice_NewFrame;
                CaptureDevice.Start();
                btn_start.Text = "Stop";
            }

            else
            {
                CaptureDevice.SignalToStop();
                ptb_QR.Image = null;
                btn_start.Text = "Start";


            }
          
        }
        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();

            var result = reader.Decode(bitmap);
            if (result != null)
            {
                tbx_barcode.Invoke(new MethodInvoker(delegate ()
                {
                    tbx_barcode.Text = result.ToString();
                }));
            }
            ptb_QR.Image = bitmap;
        }


    }
}
