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
            theNgayViews = _ITheNgayServices.GetTheNgay();
            LoadToDTG(theNgayViews);
            LoadTocbb();
        }
        private void LoadToDTG(List<TheNgayView> list)
        {
            dtg_show.Rows.Clear();
            int stt = 1;
            dtg_show.ColumnCount = 6;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";         
            dtg_show.Columns[2].Name = "Tên Nhân viên";
            dtg_show.Columns[3].Name = "Ngày bắt đầu";
            dtg_show.Columns[4].Name = "Ngày kết thúc";
            dtg_show.Columns[5].Name = "Ghi chú";
            dtg_show.Columns[1].Width = 50;
            dtg_show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_show.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtg_show.AllowUserToResizeColumns = false;

            foreach (var view in list)
            {
                dtg_show.Rows.Add(view.Id, stt++, (_NhanVienServices.GetAllNv().FirstOrDefault(p => p.Id == view.IdNV).Name), view.StartTime, view.EndTime , view.GhiChu);
            }

        }

        private void LoadTocbb()
        {
            cbb_nhanvien.Items.Clear();
            foreach (var item in _NhanVienServices.GetAllNv())
            {
                cbb_nhanvien.Items.Add(item.Name);
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đi mua cái máy in về đây rồi tính tiếp !!!");
          
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            TheNgayView tnv = new TheNgayView();
            {
                tnv.IdNV = Guid.Parse(tbt_idnv.Text);
                tnv.NameNV = cbb_nhanvien.Text;
                tnv.StartTime = DateTime.Now;
                tnv.EndTime = DateTime.Now.AddDays(1);
                tnv.GhiChu = rtb_ghichu.Text;
            }
            DialogResult rs = MessageBox.Show("Bạn có muốn thêm >?", "Thông báo ", MessageBoxButtons.OKCancel);
            if (rs == DialogResult.OK)
            {
                MessageBox.Show(_ITheNgayServices.AddTN(tnv));
                theNgayViews = _ITheNgayServices.GetTheNgay();
                LoadToDTG(theNgayViews);
            }
        }

        private void cbb_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_nhanvien.Text == "")
            {
                MessageBox.Show("Không để trống tên nhân viên, vui lòng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                tbt_idnv.Text = _NhanVienServices.GetAllNv().FirstOrDefault(p => p.Name == cbb_nhanvien.Text).Id.ToString();
                tbt_idnv.Enabled = false;  
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            var lst = _ITheNgayServices.GetTheNgay().Where(p => p.StartTime >= dtp_starts.Value && p.EndTime <= dtp_ends.Value).ToList();
            if (dtp_starts.Value> dtp_ends.Value)
            {
                MessageBox.Show("Ngày bắt đầu và kết thúc không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
              
                if (lst.Count!=0)
                {
                    LoadToDTG(lst.ToList());
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadToDTG(theNgayViews);
                }
            }

        }
    }
}
