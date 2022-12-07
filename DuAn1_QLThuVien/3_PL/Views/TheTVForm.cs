
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.Utilities;
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

namespace _3_PL.Views
{
    public partial class TheTVForm : Form
    {
        Guid _idTv;
        List<TheThanhVienView> _lstTheThanhVienView;
        ITheThanhVienServices _TheThanhVienServices;
        Validates _Validates;
        public TheTVForm()
        {
            InitializeComponent();
            _lstTheThanhVienView = new List<TheThanhVienView>();
            _TheThanhVienServices = new TheThanhVienServices();
            _lstTheThanhVienView = _TheThanhVienServices.GetTheThanhVien();
            _Validates = new Validates();
            LoadToGrid(_lstTheThanhVienView);
        }
        public void LoadToGrid(List<TheThanhVienView> lst)
        {
            dtg_show.Rows.Clear();
            int stt = 1;
            dtg_show.ColumnCount = 9;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Stt";
            dtg_show.Columns[2].Name = "Tên thành viên";
            dtg_show.Columns[3].Name = "Ngày bắt đầu";
            dtg_show.Columns[4].Name = "Ngày hết hạn";
            dtg_show.Columns[5].Name = "SDT";
            dtg_show.Columns[6].Name = "Địa Chỉ";
            dtg_show.Columns[7].Name = "Ngày Sinh";
            dtg_show.Columns[8].Name = "Ghi chú";
            foreach (var item in lst)
            {
                dtg_show.Rows.Add(
                    item.Id,
                    stt++,
                    item.TenThanhVien,
                    item.NgayDangKi,
                    item.NgayHetHan,
                    item.SDT,
                    item.DiaChi,
                    item.NgaySinh,
                    item.GhiChu
                    );
            }
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
              
            
                TheThanhVienView ttv = new TheThanhVienView()
                {
                    TenThanhVien = tbt_tenthanhvien.Text,
                    NgayDangKi = DateTime.Now,
                    NgayHetHan = DateTime.Now,
                    SDT = tbt_sdt.Text,
                    DiaChi = tbt_diachi.Text,
                    NgaySinh = DateTime.Now,
                    GhiChu = rtb_ghichu.Text
                };

                DialogResult dg = MessageBox.Show("bạn có chắc chắn muốn thêm không ?", "thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_TheThanhVienServices.AddTN(ttv));
                    _lstTheThanhVienView = _TheThanhVienServices.GetTheThanhVien();
                    LoadToGrid(_lstTheThanhVienView);
                }

            



        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            TheThanhVienView ttv = new TheThanhVienView()
            {
                Id = _idTv,
                TenThanhVien = tbt_tenthanhvien.Text,
                NgayDangKi = DateTime.Now,
                NgayHetHan = DateTime.Now,
                SDT = tbt_sdt.Text,
                DiaChi = tbt_diachi.Text,
                NgaySinh = DateTime.Now,
                GhiChu = rtb_ghichu.Text
            };
            DialogResult dg = MessageBox.Show("bạn có chắc chắn muốn sửa không ?", "thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_TheThanhVienServices.UpdateTN(ttv));
                _lstTheThanhVienView = _TheThanhVienServices.GetTheThanhVien();
                LoadToGrid(_lstTheThanhVienView);
            }

        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idTv = Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString());
            tbt_tenthanhvien.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            dtp_ngaybatdau.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            dtp_ngayketthuc.Text = dtg_show.CurrentRow.Cells[4].Value.ToString();
            tbt_sdt.Text = dtg_show.CurrentRow.Cells[5].Value.ToString();
            tbt_diachi.Text = dtg_show.CurrentRow.Cells[6].Value.ToString();
            dtp_ngaysinh.Text = dtg_show.CurrentRow.Cells[7].Value.ToString();
            rtb_ghichu.Text = dtg_show.CurrentRow.Cells[8].Value.ToString();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("bạn có chắc chắn muốn xoá không ?", "thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_TheThanhVienServices.RemoveTN(_idTv));
                _lstTheThanhVienView = _TheThanhVienServices.GetTheThanhVien();
                LoadToGrid(_lstTheThanhVienView);
            }

        }

        private void tbt_timkiem_TextChanged(object sender, EventArgs e)
        {
            var a = _TheThanhVienServices.GetTheThanhVien().Where(c => c.TenThanhVien.ToLower().Contains(tbt_timkiem.Text.ToLower())).ToList();
            if (a == null)
            {
                MessageBox.Show("Không tìm thấy kết quả");
            }
            LoadToGrid(a);

        }

        private void tbt_tenthanhvien_TextChanged(object sender, EventArgs e)
        {
            lb_tenthanhvien.Text = _Validates.checkRong(tbt_tenthanhvien.Text);
            lb_tenthanhvien.ForeColor = Color.Red;
        }

        private void tbt_diachi_TextChanged(object sender, EventArgs e)
        {
           lb_diacchi.Text = _Validates.checkRong(tbt_diachi.Text);
            lb_diacchi.ForeColor = Color.Red;
        }

        private void tbt_sdt_TextChanged(object sender, EventArgs e)
        {
            lb_sdt.Text = _Validates.checkSDT(tbt_sdt.Text);
            lb_sdt.ForeColor = Color.Red;
        }
    } 
}
