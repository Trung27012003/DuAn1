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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_muon = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_tongtien2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_thanhtoan = new WinFormsApp1.Custom_Controls.TvT_IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_idpm = new System.Windows.Forms.TextBox();
            this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrid_doncho = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgrid_danhsachsach = new System.Windows.Forms.DataGridView();
            this.cmb_dieukien_frm1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tongtien1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_phieumuonchitiet = new System.Windows.Forms.DataGridView();
            this.btn_them = new WinFormsApp1.Custom_Controls.TvT_IconButton();
            this.btn_reset = new WinFormsApp1.Custom_Controls.TvT_IconButton();
            this.btn_sua = new WinFormsApp1.Custom_Controls.TvT_IconButton();
            this.btn_xoa = new WinFormsApp1.Custom_Controls.TvT_IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tp_muon.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_doncho)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_danhsachsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_phieumuonchitiet)).BeginInit();
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
            this.tp_muon.Controls.Add(this.groupBox3);
            this.tp_muon.Controls.Add(this.groupBox2);
            this.tp_muon.Controls.Add(this.groupBox1);
            this.tp_muon.Controls.Add(this.label9);
            this.tp_muon.Controls.Add(this.label8);
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
            this.groupBox4.Controls.Add(this.lbl_tongtien2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbx_thanhtoan);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbx_idpm);
            this.groupBox4.Controls.Add(this.dtp_ngaytra);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(626, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 226);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thanh Toán";
            // 
            // lbl_tongtien2
            // 
            this.lbl_tongtien2.AutoSize = true;
            this.lbl_tongtien2.Location = new System.Drawing.Point(101, 124);
            this.lbl_tongtien2.Name = "lbl_tongtien2";
            this.lbl_tongtien2.Size = new System.Drawing.Size(42, 20);
            this.lbl_tongtien2.TabIndex = 35;
            this.lbl_tongtien2.Text = "tien1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tổng Tiền :";
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
            this.tbx_thanhtoan.Location = new System.Drawing.Point(134, 160);
            this.tbx_thanhtoan.Name = "tbx_thanhtoan";
            this.tbx_thanhtoan.Size = new System.Drawing.Size(160, 60);
            this.tbx_thanhtoan.TabIndex = 33;
            this.tbx_thanhtoan.Text = "Thanh Toán";
            this.tbx_thanhtoan.TextColor = System.Drawing.Color.Black;
            this.tbx_thanhtoan.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày trả";
            // 
            // tbx_idpm
            // 
            this.tbx_idpm.Location = new System.Drawing.Point(107, 26);
            this.tbx_idpm.Name = "tbx_idpm";
            this.tbx_idpm.Size = new System.Drawing.Size(245, 27);
            this.tbx_idpm.TabIndex = 14;
            // 
            // dtp_ngaytra
            // 
            this.dtp_ngaytra.Location = new System.Drawing.Point(107, 72);
            this.dtp_ngaytra.Name = "dtp_ngaytra";
            this.dtp_ngaytra.Size = new System.Drawing.Size(245, 27);
            this.dtp_ngaytra.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID PM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrid_doncho);
            this.groupBox3.Location = new System.Drawing.Point(613, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 291);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đơn chờ";
            // 
            // dgrid_doncho
            // 
            this.dgrid_doncho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_doncho.Location = new System.Drawing.Point(13, 22);
            this.dgrid_doncho.Name = "dgrid_doncho";
            this.dgrid_doncho.RowHeadersWidth = 51;
            this.dgrid_doncho.RowTemplate.Height = 29;
            this.dgrid_doncho.Size = new System.Drawing.Size(379, 263);
            this.dgrid_doncho.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dgrid_danhsachsach);
            this.groupBox2.Controls.Add(this.cmb_dieukien_frm1);
            this.groupBox2.Location = new System.Drawing.Point(7, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 276);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Sách";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 27);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgrid_danhsachsach
            // 
            this.dgrid_danhsachsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_danhsachsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgrid_danhsachsach.Location = new System.Drawing.Point(6, 56);
            this.dgrid_danhsachsach.Name = "dgrid_danhsachsach";
            this.dgrid_danhsachsach.RowHeadersWidth = 51;
            this.dgrid_danhsachsach.RowTemplate.Height = 29;
            this.dgrid_danhsachsach.Size = new System.Drawing.Size(581, 214);
            this.dgrid_danhsachsach.TabIndex = 33;
            // 
            // cmb_dieukien_frm1
            // 
            this.cmb_dieukien_frm1.FormattingEnabled = true;
            this.cmb_dieukien_frm1.Location = new System.Drawing.Point(422, 22);
            this.cmb_dieukien_frm1.Name = "cmb_dieukien_frm1";
            this.cmb_dieukien_frm1.Size = new System.Drawing.Size(151, 28);
            this.cmb_dieukien_frm1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tongtien1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgrid_phieumuonchitiet);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 256);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu mượn chi tiết";
            // 
            // lbl_tongtien1
            // 
            this.lbl_tongtien1.AutoSize = true;
            this.lbl_tongtien1.Location = new System.Drawing.Point(201, 208);
            this.lbl_tongtien1.Name = "lbl_tongtien1";
            this.lbl_tongtien1.Size = new System.Drawing.Size(42, 20);
            this.lbl_tongtien1.TabIndex = 35;
            this.lbl_tongtien1.Text = "tien2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tổng Tiền :";
            // 
            // dgrid_phieumuonchitiet
            // 
            this.dgrid_phieumuonchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_phieumuonchitiet.Location = new System.Drawing.Point(4, 22);
            this.dgrid_phieumuonchitiet.Name = "dgrid_phieumuonchitiet";
            this.dgrid_phieumuonchitiet.RowHeadersWidth = 51;
            this.dgrid_phieumuonchitiet.RowTemplate.Height = 29;
            this.dgrid_phieumuonchitiet.Size = new System.Drawing.Size(428, 183);
            this.dgrid_phieumuonchitiet.TabIndex = 31;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_them.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btn_them.BorderColor = System.Drawing.Color.Gray;
            this.btn_them.BorderRadius = 15;
            this.btn_them.BorderSize = 1;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_them.IconColor = System.Drawing.Color.Black;
            this.btn_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_them.Location = new System.Drawing.Point(438, 15);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(162, 43);
            this.btn_them.TabIndex = 27;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.Black;
            this.btn_them.UseVisualStyleBackColor = false;
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
            this.btn_reset.Location = new System.Drawing.Point(438, 162);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(162, 43);
            this.btn_reset.TabIndex = 30;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextColor = System.Drawing.Color.Black;
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_sua.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btn_sua.BorderColor = System.Drawing.Color.Gray;
            this.btn_sua.BorderRadius = 15;
            this.btn_sua.BorderSize = 1;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_sua.IconColor = System.Drawing.Color.Black;
            this.btn_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sua.Location = new System.Drawing.Point(438, 64);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(162, 43);
            this.btn_sua.TabIndex = 28;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Black;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.tvT_IconButton2_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btn_xoa.BorderColor = System.Drawing.Color.Gray;
            this.btn_xoa.BorderRadius = 15;
            this.btn_xoa.BorderSize = 1;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_xoa.IconColor = System.Drawing.Color.Black;
            this.btn_xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_xoa.Location = new System.Drawing.Point(438, 113);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(162, 43);
            this.btn_xoa.TabIndex = 29;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Điều kiện";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mã Sách";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TRẢ SÁCH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "STT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thể loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tác giả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thể loại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // MuonTraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 582);
            this.Controls.Add(this.tabControl1);
            this.Name = "MuonTraForm";
            this.Text = "MuonTraForm";
            this.tabControl1.ResumeLayout(false);
            this.tp_muon.ResumeLayout(false);
            this.tp_muon.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_doncho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_danhsachsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_phieumuonchitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tp_muon;
        private TabPage tabPage2;
        private ComboBox cmb_dieukien_frm1;
        private Label label9;
        private Label label8;
        private TextBox tbx_idpm;
        private Label label6;
        private DateTimePicker dtp_ngaytra;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private WinFormsApp1.Custom_Controls.TvT_IconButton btn_reset;
        private WinFormsApp1.Custom_Controls.TvT_IconButton btn_xoa;
        private WinFormsApp1.Custom_Controls.TvT_IconButton btn_sua;
        private WinFormsApp1.Custom_Controls.TvT_IconButton btn_them;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private WinFormsApp1.Custom_Controls.TvT_IconButton tbx_thanhtoan;
        private Label label2;
        private GroupBox groupBox3;
        private DataGridView dgrid_doncho;
        private TextBox textBox1;
        private DataGridView dgrid_danhsachsach;
        private Label label1;
        private DataGridView dgrid_phieumuonchitiet;
        private Label lbl_tongtien2;
        private Label label3;
        private Label lbl_tongtien1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}