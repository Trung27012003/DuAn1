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
            dtg_showtl.ColumnCount = 1;
            dtg_showtl.Columns[1].Name = "Thể loại";
            foreach(var x in _IsachServices.GetSach())
            {
                dtg_showtl.Rows.Add(x.TL);
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
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thêm sách mới không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes) { }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
