﻿namespace _3_PL.Views
{
    partial class SachForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbt_tg = new System.Windows.Forms.TextBox();
            this.tbt_giatien = new System.Windows.Forms.TextBox();
            this.tbt_tensach = new System.Windows.Forms.TextBox();
            this.tbt_soluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.tbt_timkiem = new System.Windows.Forms.TextBox();
            this.dtg_showtl = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_ghichu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbt_NXB = new System.Windows.Forms.TextBox();
            this.tbt_TL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtg_showsach = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_QR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_QR = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showtl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showsach)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QR)).BeginInit();
            this.SuspendLayout();
            // 
            // tbt_tg
            // 
            this.tbt_tg.Location = new System.Drawing.Point(99, 47);
            this.tbt_tg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_tg.Name = "tbt_tg";
            this.tbt_tg.Size = new System.Drawing.Size(191, 23);
            this.tbt_tg.TabIndex = 1;
            // 
            // tbt_giatien
            // 
            this.tbt_giatien.Location = new System.Drawing.Point(99, 183);
            this.tbt_giatien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_giatien.Name = "tbt_giatien";
            this.tbt_giatien.Size = new System.Drawing.Size(191, 23);
            this.tbt_giatien.TabIndex = 4;
            // 
            // tbt_tensach
            // 
            this.tbt_tensach.Location = new System.Drawing.Point(99, 117);
            this.tbt_tensach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_tensach.Name = "tbt_tensach";
            this.tbt_tensach.Size = new System.Drawing.Size(191, 23);
            this.tbt_tensach.TabIndex = 5;
            // 
            // tbt_soluong
            // 
            this.tbt_soluong.Location = new System.Drawing.Point(99, 152);
            this.tbt_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_soluong.Name = "tbt_soluong";
            this.tbt_soluong.Size = new System.Drawing.Size(191, 23);
            this.tbt_soluong.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "NXB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giá tiền";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(561, 13);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(101, 33);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(694, 13);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(101, 33);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(561, 55);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(101, 33);
            this.btn_xoa.TabIndex = 19;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // tbt_timkiem
            // 
            this.tbt_timkiem.Location = new System.Drawing.Point(5, 20);
            this.tbt_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_timkiem.Name = "tbt_timkiem";
            this.tbt_timkiem.Size = new System.Drawing.Size(235, 23);
            this.tbt_timkiem.TabIndex = 20;
            this.tbt_timkiem.TextChanged += new System.EventHandler(this.tbt_timkiem_TextChanged);
            // 
            // dtg_showtl
            // 
            this.dtg_showtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtg_showtl.Location = new System.Drawing.Point(5, 20);
            this.dtg_showtl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_showtl.Name = "dtg_showtl";
            this.dtg_showtl.RowHeadersWidth = 51;
            this.dtg_showtl.RowTemplate.Height = 29;
            this.dtg_showtl.Size = new System.Drawing.Size(181, 203);
            this.dtg_showtl.TabIndex = 22;
            this.dtg_showtl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showtl_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_ghichu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbt_NXB);
            this.groupBox1.Controls.Add(this.tbt_TL);
            this.groupBox1.Controls.Add(this.tbt_tg);
            this.groupBox1.Controls.Add(this.tbt_giatien);
            this.groupBox1.Controls.Add(this.tbt_tensach);
            this.groupBox1.Controls.Add(this.tbt_soluong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(214, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(337, 244);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // tbx_ghichu
            // 
            this.tbx_ghichu.Location = new System.Drawing.Point(99, 208);
            this.tbx_ghichu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_ghichu.Name = "tbx_ghichu";
            this.tbx_ghichu.Size = new System.Drawing.Size(191, 23);
            this.tbx_ghichu.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ghi chú";
            // 
            // tbt_NXB
            // 
            this.tbt_NXB.Location = new System.Drawing.Point(99, 84);
            this.tbt_NXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_NXB.Name = "tbt_NXB";
            this.tbt_NXB.Size = new System.Drawing.Size(191, 23);
            this.tbt_NXB.TabIndex = 18;
            // 
            // tbt_TL
            // 
            this.tbt_TL.Location = new System.Drawing.Point(99, 15);
            this.tbt_TL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_TL.Name = "tbt_TL";
            this.tbt_TL.Size = new System.Drawing.Size(191, 23);
            this.tbt_TL.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_showtl);
            this.groupBox2.Location = new System.Drawing.Point(10, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(199, 228);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thể Loại";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtg_showsach);
            this.groupBox3.Location = new System.Drawing.Point(10, 252);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(791, 146);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dtg_showsach
            // 
            this.dtg_showsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showsach.Location = new System.Drawing.Point(5, 20);
            this.dtg_showsach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_showsach.Name = "dtg_showsach";
            this.dtg_showsach.RowHeadersWidth = 51;
            this.dtg_showsach.RowTemplate.Height = 29;
            this.dtg_showsach.Size = new System.Drawing.Size(780, 132);
            this.dtg_showsach.TabIndex = 0;
            this.dtg_showsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showsach_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbt_timkiem);
            this.groupBox4.Location = new System.Drawing.Point(556, 189);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(245, 48);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btn_QR
            // 
            this.btn_QR.Location = new System.Drawing.Point(694, 55);
            this.btn_QR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QR.Name = "btn_QR";
            this.btn_QR.Size = new System.Drawing.Size(101, 33);
            this.btn_QR.TabIndex = 27;
            this.btn_QR.Text = "QR";
            this.btn_QR.UseVisualStyleBackColor = true;
            this.btn_QR.Click += new System.EventHandler(this.btn_QR_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptb_QR);
            this.panel1.Location = new System.Drawing.Point(556, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 90);
            this.panel1.TabIndex = 28;
            // 
            // ptb_QR
            // 
            this.ptb_QR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_QR.Location = new System.Drawing.Point(0, 0);
            this.ptb_QR.Name = "ptb_QR";
            this.ptb_QR.Size = new System.Drawing.Size(245, 90);
            this.ptb_QR.TabIndex = 0;
            this.ptb_QR.TabStop = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "STT";
            this.Column2.Name = "Column2";
            this.Column2.Width = 45;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thể Loại";
            this.Column3.Name = "Column3";
            // 
            // SachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_QR);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SachForm";
            this.Text = "SachForm";
            this.Load += new System.EventHandler(this.SachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showtl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showsach)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox tbt_tg;
        private TextBox tbt_giatien;
        private TextBox tbt_tensach;
        private TextBox tbt_soluong;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private TextBox tbt_timkiem;
        private DataGridView dtg_showtl;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dtg_showsach;
        private GroupBox groupBox4;
        private TextBox tbt_NXB;
        private TextBox tbt_TL;
        private TextBox tbx_ghichu;
        private Label label7;
        private Button btn_QR;
        private Panel panel1;
        private PictureBox ptb_QR;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn ID;
    }
}