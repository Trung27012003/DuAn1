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

namespace _3_PL.Views
{
    public partial class SachForm : Form
    {
        public ISachServices _IsachServices;
        private int stt;
        private Guid _id;
        public SachForm()
        {
            InitializeComponent();
            _IsachServices = new SachServices();
        }
        private void LoadDS()
        {
            stt = 1;
            dtg_showsach.Rows.Clear();
            dtg_showsach.ColumnCount = 8;
            dtg_showsach.Columns[0].Name = "STT";
            dtg_showsach.Columns[1].Name = "Id";
            dtg_showsach.Columns[2].Name = "Thể loại";
            dtg_showsach.Columns[3].Name = "Tác giả";
            dtg_showsach.Columns[4].Name = "NXB";
            dtg_showsach.Columns[5].Name = "Tên sách";
            dtg_showsach.Columns[6].Name = "Số lượng";
            dtg_showsach.Columns[7].Name = "Giá tiền";
            dtg_showsach.Columns[1].Visible = false;
            foreach (var x in _IsachServices.GetSach())
            {
                dtg_showsach.Rows.Add(
                    stt++,x.Id,x.TL,x.TG,x.NXB,x.Name,x.SoLuong,x.GiaTien);
            }
        }
        private void LoadTL()
        {
            dtg_showtl.Rows.Clear();
            int stt = 1;
            dtg_showtl.ColumnCount = 2;
            dtg_showtl.Columns[0].Name = "STT";
            dtg_showtl.Columns[1].Name = "Thể loại";
            foreach(var x in _IsachServices.GetSach())
            {
                dtg_showtl.Rows.Add(stt++,x.TL);
            }
        }
        private SachView GetData()
        {
            SachView sachView = new SachView();
            {
                sachView.Id = _id;
                sachView.TL = tbt_TL.Text;
                sachView.TG = tbt_tg.Text;
                sachView.NXB = tbt_NXB.Text;
                sachView.Name = tbt_tensach.Text;
                sachView.GhiChu = tbx_ghichu.Text;
                sachView.SoLuong =Convert.ToInt32(tbt_soluong.Text);
                sachView.GiaTien = Convert.ToInt32(tbt_giatien.Text);
            }return sachView;
            
        }
        private void CheckNhap()
        {
            
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            
            int a;
            if (tbt_TL.Text == "")
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
            else if (!int.TryParse(tbt_giatien.Text, out a))
            {
                MessageBox.Show("Giá tiền phải là số");
            }
            
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm sách mới không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    MessageBox.Show(_IsachServices.AddTN(GetData()));
                    LoadDS();
                }
                else
                {
                    MessageBox.Show("Đã hủy");
                }
            }

            
        }

        private void dtg_showtl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbt_TL.Text = dtg_showtl.CurrentCell.Value.ToString();
        }

        private void SachForm_Load(object sender, EventArgs e)
        {
            LoadTL();
            LoadDS();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa sách không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_IsachServices.RemoveTN(_id));
                LoadDS();
            }
            else
            {
                MessageBox.Show("Đã hủy");
            }
        }

        private void dtg_showsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            _id = (Guid)dtg_showsach.CurrentRow.Cells[1].Value;
            tbt_TL.Text = dtg_showsach.CurrentRow.Cells[2].Value.ToString();
            tbt_tg.Text = dtg_showsach.CurrentRow.Cells[3].Value.ToString();
            tbt_NXB.Text = dtg_showsach.CurrentRow.Cells[4].Value.ToString();
            tbt_tensach.Text = dtg_showsach.CurrentRow.Cells[5].Value.ToString();
            tbt_soluong.Text = dtg_showsach.CurrentRow.Cells[6].Value.ToString();
            tbt_giatien.Text = dtg_showsach.CurrentRow.Cells[7].Value.ToString();
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
            dtg_showsach.ColumnCount = 8;
            dtg_showsach.Columns[0].Name = "STT";
            dtg_showsach.Columns[1].Name = "Id";
            dtg_showsach.Columns[2].Name = "Thể loại";
            dtg_showsach.Columns[3].Name = "Tác giả";
            dtg_showsach.Columns[4].Name = "NXB";
            dtg_showsach.Columns[5].Name = "Tên sách";
            dtg_showsach.Columns[6].Name = "Số lượng";
            dtg_showsach.Columns[7].Name = "Giá tiền";
            dtg_showsach.Columns[1].Visible = false;
            foreach (var x in a)
            {
                dtg_showsach.Rows.Add(
                    stt++, x.Id, x.TL, x.TG, x.NXB, x.Name, x.SoLuong, x.GiaTien);
            }
        }

        private void btn_QR_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qrcode = new QRCodeGenerator();
            var qrtext = "Tên Sách: " + tbt_tensach.Text + "\n" + "Nhà Xuất Bản: " + tbt_NXB.Text + "\n" + "Tác Giả: " + tbt_tg.Text + "\n" + "Thể Loại: " + tbt_TL.Text + "\n" +"Ghi Chú: " + tbx_ghichu.Text;
            var data = qrcode.CreateQrCode(qrtext, QRCoder.QRCodeGenerator.ECCLevel.L);
            var code = new QRCoder.QRCode(data);
            ptb_QR.Image = code.GetGraphic(20);
        }
    }
}
