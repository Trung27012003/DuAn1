using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using AForge.Video.DirectShow;
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
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

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
        FilterInfoCollection infoCollection;
        VideoCaptureDevice device;
        
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
            if(tbx_tencv.Text == "")
            {
                tbx_tencv.BackColor = Color.Yellow;
                MessageBox.Show("Không để trống tên chức vụ, vui lòng nhập chức vụ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ChucVuView cvv = new ChucVuView()
                {

                    Name = tbx_tencv.Text,
                };
                DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_ChucVuServices.AddTN(cvv));
                    _lstChucVuViews = _ChucVuServices.GetTheNgay();
                    LoadToGridCv(_lstChucVuViews);
                }
                Loadtocbb();
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ChucVuView cvv = new ChucVuView()
            {
                Id = _IdCv,
                Name = tbx_tencv.Text,
            };
            DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
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

            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
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
            var checkcv = _ChucVuServices.GetTheNgay().FirstOrDefault(c => c.Name == cbb_tenchucvu.Text);
            //bool checkname = Regex.IsMatch(tbx_tennv.Text, "[a-zA-Z]");
            //bool checktext = Regex.IsMatch(tbx_diachi.Text, "");
            bool sdt = Regex.IsMatch(tbx_sdt.Text, "^0[0-9]{9}$");

            if (cbb_tenchucvu.Text == "")
            {
                cbb_tenchucvu.BackColor = Color.Red;
                MessageBox.Show("Không để trống chức vụ, vui lòng chọn chức vụ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (checkcv == null)
            {
                DialogResult dr = MessageBox.Show($"Chức vụ bạn chọn không tồn tại, bạn có muốn thêm mới chức vụ '{cbb_tenchucvu.Text}' không", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ChucVuView cv = new ChucVuView()
                    {
                        Name = cbb_tenchucvu.Text,
                    };
                    _ChucVuServices.AddTN(cv);
                    Loadtocbb();

                    NhanVienView cvv = new NhanVienView()
                    {
                        Name = tbx_tennv.Text,
                        NgaySinh = DateTime.Now,
                        DiaChi = tbx_diachi.Text,
                        SDT = tbx_sdt.Text,
                        IdCV = _ChucVuServices.GetTheNgay().FirstOrDefault(c => c.Name == cbb_tenchucvu.Text).Id
                    };
                    DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        MessageBox.Show(_NhanVienServices.AddTN(cvv));
                        _lstNhanVienView = _NhanVienServices.GetAllNv();
                        LoadToGridNv(_lstNhanVienView);
                    }
                }
            }
            else if (tbx_tennv.Text == "")
            {
                tbx_tennv.BackColor = Color.Red;
                MessageBox.Show("Không để trống tên nhân viên, vui lòng nhập tên nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tbx_diachi.Text == "")
            {
                tbx_diachi.BackColor = Color.Red;
                MessageBox.Show("Không để trống địa chỉ, vui lòng nhập đại chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tbx_sdt.Text == "")
            {
                tbx_sdt.BackColor = Color.Red;
                MessageBox.Show("Không để trống SDT, vui lòng nhập SDT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!sdt)
            {
                tbx_sdt.BackColor = Color.Red;
                MessageBox.Show("Sai định dạng SDT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                NhanVienView cvv = new NhanVienView()
                {
                    Name = tbx_tennv.Text,
                    NgaySinh = DateTime.Now,
                    DiaChi = tbx_diachi.Text,
                    SDT = tbx_sdt.Text,
                    IdCV = _ChucVuServices.GetTheNgay().FirstOrDefault(c => c.Name == cbb_tenchucvu.Text).Id
                };
                DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_NhanVienServices.AddTN(cvv));
                    _lstNhanVienView = _NhanVienServices.GetAllNv();
                    LoadToGridNv(_lstNhanVienView);
                }
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

        private void tbx_tencv_TextChanged(object sender, EventArgs e)
        {
            tbx_tencv.BackColor = Color.White;
        }

        private void cbb_tenchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_tenchucvu.BackColor = Color.White;
        }

        private void tbx_tennv_TextChanged(object sender, EventArgs e)
        {
            tbx_tennv.BackColor = Color.White;
        }

        private void tbx_diachi_TextChanged(object sender, EventArgs e)
        {
            tbx_diachi.BackColor = Color.White;
        }

        private void tbx_sdt_TextChanged(object sender, EventArgs e)
        {
            tbx_sdt.BackColor = Color.White;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            if (btn_Show.Text == "HIỂN THỊ")
            {
                grb_Anh.Visible = true;
                btn_Show.Text = "ẨN";
            }
            else
            {               
                grb_Anh.Visible = false;
                btn_Show.Text = "HIỂN THỊ";
            }
        }

        private void TheNVForm_Load_1(object sender, EventArgs e)
        {
            grb_Anh.Visible = false;
            
        }


        private void device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            ptb_Anh.Image= bitmap;
        }
        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (tbx_tennv.Text == "")
            {
                MessageBox.Show("Cần nhập tên nhân viên trước khi lựa chọn ảnh");
            }
            else
            {
                tabControl1.SelectedIndex = 2;
                btn_take.Text = "Chụp ảnh";
                infoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo info in infoCollection)
                {
                    cbb_Camera.Items.Add(info.Name);
                }
                cbb_Camera.SelectedIndex = 0;
                RunCamera();
            }
            

        }
        private void RunCamera()
        {
            device = new VideoCaptureDevice();
            device = new VideoCaptureDevice(infoCollection[cbb_Camera.SelectedIndex].MonikerString);
            device.NewFrame += device_NewFrame;
            device.Start();
        }
        private void TakePicture()
        {
            device = new VideoCaptureDevice();
            device = new VideoCaptureDevice(infoCollection[cbb_Camera.SelectedIndex].MonikerString);
            device.SnapshotFrame += device_SnapshotFrame;
            device.Start();
        }

        private void device_SnapshotFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            ptb_Anh.Image = bitmap;
        }

        private void btn_take_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btn_take.Text == "Chụp ảnh")
                {                    
                    btn_take.Text = "Chụp lại";
                    btn_Again.Text = "Lưu và thoát";
                    TakePicture();
                    device.SignalToStop();
                    Bitmap anhT = ResizeImage(ptb_Anh.Image, 900, 464);
                    Bitmap anh = ResizeImage(ptb_Anh.Image, 235, 207);
                    ptb_Anh.Image = anhT;
                    ptb_AnhNV.Image = anh;
                }
                else
                {                    
                    btn_take.Text = "Chụp ảnh";
                    btn_Again.Text = "Quay lại";
                    RunCamera();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Again_Click(object sender, EventArgs e)
        {
            if (btn_Again.Text == "Lưu và thoát")
            {
                    device.SignalToStop();
                    string path = @"C:\Users\VHC\Dropbox\PC\Desktop\Du an 1\Ảnh";
                    string ten = path + @"\" + tbx_tennv.Text + ".jpg";
                    ptb_Anh.Image.Save(path + @"\" + tbx_tennv.Text + ".jpg", ImageFormat.Jpeg);
                    btn_take.Text = "Chụp ảnh";
                    ptb_Anh.Dispose();
                    tabControl1.SelectedIndex = 0;                                   
            }
            else
            {
                device.Stop();
                ptb_AnhNV.Dispose();
                tabControl1.SelectedIndex = 0;
            }
            
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void cbb_Camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
//Vẫn chưa tắt được cam
