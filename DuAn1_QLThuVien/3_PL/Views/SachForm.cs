﻿using _2_BUS.IServices;
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
            dtg_showsach.Columns[2].Name = "Tác giả";
            dtg_showsach.Columns[3].Name = "NXB";
            dtg_showsach.Columns[4].Name = "Tên sách";
            dtg_showsach.Columns[5].Name = "Số lượng";
            dtg_showsach.Columns[6].Name = "Giá tiền";
            dtg_showsach.Columns[7].Name = "Ghi chú";
            dtg_showsach.Columns[1].Visible = false;
            foreach (var x in _IsachServices.GetSach())
            {
                dtg_showsach.Rows.Add(
                    stt++,x.Id,x.TG,x.NXB,x.Name,x.SoLuong,x.GiaTien , x.GhiChu);
            }
        }
        private void LoadTL()
        {
            int stt = 0;
            dtg_showtl.Rows.Clear();
            dtg_showtl.ColumnCount = 2;
            dtg_showtl.Columns[0].Name = "STT";
            dtg_showtl.Columns[1].Name = "Thể loại";
            foreach(var x in _IsachServices.GetSach())
            {
                dtg_showtl.Rows.Add(stt++, x.TL);
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
                sachView.SoLuong =Convert.ToInt32(tbt_soluong.Text);
                sachView.GiaTien = Convert.ToInt32(tbt_giatien.Text);
            }return sachView;
            
        }
        private void CheckNhap()
        {
            
        }
        private void btn_them_Click(object sender, EventArgs e)
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
            
            tbt_tg.Text = dtg_showsach.CurrentRow.Cells[2].Value.ToString();
            tbt_NXB.Text = dtg_showsach.CurrentRow.Cells[3].Value.ToString();
            tbt_tensach.Text = dtg_showsach.CurrentRow.Cells[4].ToString();
            tbt_soluong.Text = dtg_showsach.CurrentRow.Cells[5].Value.ToString();
            tbt_giatien.Text = dtg_showsach.CurrentRow.Cells[6].Value.ToString();
            rtb_ghichu.Text = dtg_showsach.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
