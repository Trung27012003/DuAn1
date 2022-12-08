namespace _3_PL.Views
{
    partial class MuonTraForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_muon = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_tongtien1 = new System.Windows.Forms.Label();
            this.cmb_nhanvien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_tenkh = new System.Windows.Forms.ComboBox();
            this.tbx_thanhtoan = new WinFormsApp1.Custom_Controls.TvT_IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.dgrid_danhsachsach = new System.Windows.Forms.DataGridView();
            this.cmb_loc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrid_phieumuonchitiet = new System.Windows.Forms.DataGridView();
            this.btn_reset = new WinFormsApp1.Custom_Controls.TvT_IconButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbb_chonanh = new System.Windows.Forms.ComboBox();
            this.rtb_show = new System.Windows.Forms.RichTextBox();
            this.btn_batmay = new WinFormsApp1.Custom_Controls.TvT_IconButton();
            this.ptb_camera = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgrid_phieutract = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgrid_phieutra = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbx_mapm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tp_muon.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_danhsachsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_phieumuonchitiet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_camera)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_phieutract)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_phieutra)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_muon);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_muon
            // 
            this.tp_muon.Controls.Add(this.groupBox4);
            this.tp_muon.Controls.Add(this.groupBox2);
            this.tp_muon.Controls.Add(this.groupBox1);
            this.tp_muon.Location = new System.Drawing.Point(4, 29);
            this.tp_muon.Name = "tp_muon";
            this.tp_muon.Padding = new System.Windows.Forms.Padding(3);
            this.tp_muon.Size = new System.Drawing.Size(1017, 544);
            this.tp_muon.TabIndex = 0;
            this.tp_muon.Text = "MƯỢN SÁCH";
            this.tp_muon.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbx_mapm);
            this.groupBox4.Controls.Add(this.lbl_tongtien1);
            this.groupBox4.Controls.Add(this.btn_reset);
            this.groupBox4.Controls.Add(this.cmb_nhanvien);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmb_tenkh);
            this.groupBox4.Controls.Add(this.tbx_thanhtoan);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dtp_ngaytra);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(626, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 307);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thanh Toán";
            // 
            // lbl_tongtien1
            // 
            this.lbl_tongtien1.AutoSize = true;
            this.lbl_tongtien1.Location = new System.Drawing.Point(115, 202);
            this.lbl_tongtien1.Name = "lbl_tongtien1";
            this.lbl_tongtien1.Size = new System.Drawing.Size(42, 20);
            this.lbl_tongtien1.TabIndex = 35;
            this.lbl_tongtien1.Text = "tien2";
            // 
            // cmb_nhanvien
            // 
            this.cmb_nhanvien.FormattingEnabled = true;
            this.cmb_nhanvien.Location = new System.Drawing.Point(113, 26);
            this.cmb_nhanvien.Name = "cmb_nhanvien";
            this.cmb_nhanvien.Size = new System.Drawing.Size(248, 28);
            this.cmb_nhanvien.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tổng Tiền :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nhân viên";
            // 
            // cmb_tenkh
            // 
            this.cmb_tenkh.FormattingEnabled = true;
            this.cmb_tenkh.Location = new System.Drawing.Point(113, 76);
            this.cmb_tenkh.Name = "cmb_tenkh";
            this.cmb_tenkh.Size = new System.Drawing.Size(248, 28);
            this.cmb_tenkh.TabIndex = 36;
            // 
            // tbx_thanhtoan
            // 
            this.tbx_thanhtoan.BackColor = System.Drawing.Color.SkyBlue;
            this.tbx_thanhtoan.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.tbx_thanhtoan.BorderColor = System.Drawing.Color.Gray;
            this.tbx_thanhtoan.BorderRadius = 15;
            this.tbx_thanhtoan.BorderSize = 1;
            this.tbx_thanhtoan.FlatAppearance.BorderSize = 0;
            this.tbx_thanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbx_thanhtoan.ForeColor = System.Drawing.Color.Black;
            this.tbx_thanhtoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tbx_thanhtoan.IconColor = System.Drawing.Color.Black;
            this.tbx_thanhtoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tbx_thanhtoan.Location = new System.Drawing.Point(207, 241);
            this.tbx_thanhtoan.Name = "tbx_thanhtoan";
            this.tbx_thanhtoan.Size = new System.Drawing.Size(160, 60);
            this.tbx_thanhtoan.TabIndex = 33;
            this.tbx_thanhtoan.Text = "Thanh Toán";
            this.tbx_thanhtoan.TextColor = System.Drawing.Color.Black;
            this.tbx_thanhtoan.UseVisualStyleBackColor = false;
            this.tbx_thanhtoan.Click += new System.EventHandler(this.tbx_thanhtoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày trả";
            // 
            // dtp_ngaytra
            // 
            this.dtp_ngaytra.Location = new System.Drawing.Point(113, 122);
            this.dtp_ngaytra.Name = "dtp_ngaytra";
            this.dtp_ngaytra.Size = new System.Drawing.Size(248, 27);
            this.dtp_ngaytra.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Người mượn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_search);
            this.groupBox2.Controls.Add(this.dgrid_danhsachsach);
            this.groupBox2.Controls.Add(this.cmb_loc);
            this.groupBox2.Location = new System.Drawing.Point(13, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 276);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Sách";
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(239, 23);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(269, 27);
            this.tbx_search.TabIndex = 27;
            this.tbx_search.TextChanged += new System.EventHandler(this.tbx_search_TextChanged);
            // 
            // dgrid_danhsachsach
            // 
            this.dgrid_danhsachsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_danhsachsach.Location = new System.Drawing.Point(6, 56);
            this.dgrid_danhsachsach.Name = "dgrid_danhsachsach";
            this.dgrid_danhsachsach.RowHeadersWidth = 51;
            this.dgrid_danhsachsach.RowTemplate.Height = 29;
            this.dgrid_danhsachsach.Size = new System.Drawing.Size(986, 213);
            this.dgrid_danhsachsach.TabIndex = 33;
            this.dgrid_danhsachsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_danhsachsach_CellClick);
            // 
            // cmb_loc
            // 
            this.cmb_loc.FormattingEnabled = true;
            this.cmb_loc.Location = new System.Drawing.Point(820, 22);
            this.cmb_loc.Name = "cmb_loc";
            this.cmb_loc.Size = new System.Drawing.Size(151, 28);
            this.cmb_loc.TabIndex = 20;
            this.cmb_loc.SelectedIndexChanged += new System.EventHandler(this.cmb_loc_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrid_phieumuonchitiet);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 305);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu mượn chi tiết";
            // 
            // dgrid_phieumuonchitiet
            // 
            this.dgrid_phieumuonchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_phieumuonchitiet.Location = new System.Drawing.Point(5, 21);
            this.dgrid_phieumuonchitiet.Name = "dgrid_phieumuonchitiet";
            this.dgrid_phieumuonchitiet.RowHeadersWidth = 51;
            this.dgrid_phieumuonchitiet.RowTemplate.Height = 29;
            this.dgrid_phieumuonchitiet.Size = new System.Drawing.Size(589, 278);
            this.dgrid_phieumuonchitiet.TabIndex = 31;
            this.dgrid_phieumuonchitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_phieumuonchitiet_CellClick);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_reset.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btn_reset.BorderColor = System.Drawing.Color.Gray;
            this.btn_reset.BorderRadius = 15;
            this.btn_reset.BorderSize = 1;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_reset.IconColor = System.Drawing.Color.Black;
            this.btn_reset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reset.Location = new System.Drawing.Point(15, 241);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(162, 60);
            this.btn_reset.TabIndex = 30;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextColor = System.Drawing.Color.Black;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TRẢ SÁCH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbb_chonanh);
            this.groupBox8.Controls.Add(this.rtb_show);
            this.groupBox8.Controls.Add(this.btn_batmay);
            this.groupBox8.Controls.Add(this.ptb_camera);
            this.groupBox8.Location = new System.Drawing.Point(315, 263);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(453, 259);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "CAMERA";
            // 
            // cbb_chonanh
            // 
            this.cbb_chonanh.FormattingEnabled = true;
            this.cbb_chonanh.Location = new System.Drawing.Point(269, 208);
            this.cbb_chonanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_chonanh.Name = "cbb_chonanh";
            this.cbb_chonanh.Size = new System.Drawing.Size(177, 28);
            this.cbb_chonanh.TabIndex = 4;
            // 
            // rtb_show
            // 
            this.rtb_show.Location = new System.Drawing.Point(218, 29);
            this.rtb_show.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_show.Name = "rtb_show";
            this.rtb_show.Size = new System.Drawing.Size(227, 159);
            this.rtb_show.TabIndex = 3;
            this.rtb_show.Text = "";
            // 
            // btn_batmay
            // 
            this.btn_batmay.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_batmay.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btn_batmay.BorderColor = System.Drawing.Color.Gray;
            this.btn_batmay.BorderRadius = 20;
            this.btn_batmay.BorderSize = 1;
            this.btn_batmay.FlatAppearance.BorderSize = 0;
            this.btn_batmay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batmay.ForeColor = System.Drawing.Color.Black;
            this.btn_batmay.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_batmay.IconColor = System.Drawing.Color.Black;
            this.btn_batmay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_batmay.Location = new System.Drawing.Point(37, 198);
            this.btn_batmay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_batmay.Name = "btn_batmay";
            this.btn_batmay.Size = new System.Drawing.Size(201, 49);
            this.btn_batmay.TabIndex = 1;
            this.btn_batmay.Text = "Start";
            this.btn_batmay.TextColor = System.Drawing.Color.Black;
            this.btn_batmay.UseVisualStyleBackColor = false;
            this.btn_batmay.Click += new System.EventHandler(this.btn_batmay_Click);
            // 
            // ptb_camera
            // 
            this.ptb_camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_camera.Location = new System.Drawing.Point(7, 29);
            this.ptb_camera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_camera.Name = "ptb_camera";
            this.ptb_camera.Size = new System.Drawing.Size(205, 160);
            this.ptb_camera.TabIndex = 0;
            this.ptb_camera.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(775, 9);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(225, 512);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Xác Nhận Trả";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgrid_phieutract);
            this.groupBox6.Location = new System.Drawing.Point(315, 9);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(453, 253);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Phiếu Trả Chi Tiết";
            // 
            // dgrid_phieutract
            // 
            this.dgrid_phieutract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_phieutract.Location = new System.Drawing.Point(7, 29);
            this.dgrid_phieutract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgrid_phieutract.Name = "dgrid_phieutract";
            this.dgrid_phieutract.RowHeadersWidth = 51;
            this.dgrid_phieutract.RowTemplate.Height = 25;
            this.dgrid_phieutract.Size = new System.Drawing.Size(439, 216);
            this.dgrid_phieutract.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.dgrid_phieutra);
            this.groupBox5.Location = new System.Drawing.Point(7, 7);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(302, 515);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tìm Kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 27);
            this.textBox1.TabIndex = 1;
            // 
            // dgrid_phieutra
            // 
            this.dgrid_phieutra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_phieutra.Location = new System.Drawing.Point(0, 64);
            this.dgrid_phieutra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgrid_phieutra.Name = "dgrid_phieutra";
            this.dgrid_phieutra.RowHeadersWidth = 51;
            this.dgrid_phieutra.RowTemplate.Height = 25;
            this.dgrid_phieutra.Size = new System.Drawing.Size(295, 439);
            this.dgrid_phieutra.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbx_mapm
            // 
            this.tbx_mapm.Location = new System.Drawing.Point(113, 167);
            this.tbx_mapm.Name = "tbx_mapm";
            this.tbx_mapm.Size = new System.Drawing.Size(245, 27);
            this.tbx_mapm.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mã PM";
            // 
            // MuonTraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1028, 633);
            this.Controls.Add(this.tabControl1);
            this.Name = "MuonTraForm";
            this.Text = "MuonTraForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MuonTraForm_FormClosing);
            this.Load += new System.EventHandler(this.MuonTraForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_muon.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_danhsachsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_phieumuonchitiet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_camera)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_phieutract)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_phieutra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tp_muon;
        private TabPage tabPage2;
        private ComboBox cmb_loc;
        private Label label6;
        private DateTimePicker dtp_ngaytra;
        private WinFormsApp1.Custom_Controls.TvT_IconButton btn_reset;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private WinFormsApp1.Custom_Controls.TvT_IconButton tbx_thanhtoan;
        private Label label2;
        private TextBox tbx_search;
        private DataGridView dgrid_danhsachsach;
        private Label label1;
        private DataGridView dgrid_phieumuonchitiet;
        private Label lbl_tongtien1;
        private DataGridView dgrid_phieutra;
        private GroupBox groupBox6;
        private DataGridView dgrid_phieutract;
        private GroupBox groupBox5;
        private Label label4;
        private TextBox textBox1;
        private GroupBox groupBox8;
        private GroupBox groupBox7;
        private RichTextBox rtb_show;
        private WinFormsApp1.Custom_Controls.TvT_IconButton btn_batmay;
        private PictureBox ptb_camera;
        private ComboBox cbb_chonanh;
        private System.Windows.Forms.Timer timer1;
        private ComboBox cmb_tenkh;
        private ComboBox cmb_nhanvien;
        private Label label5;
        private Label label3;
        private TextBox tbx_mapm;
    }
}