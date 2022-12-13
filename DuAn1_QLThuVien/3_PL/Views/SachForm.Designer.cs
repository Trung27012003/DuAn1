namespace _3_PL.Views
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_barcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_ma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_theLoai = new System.Windows.Forms.ComboBox();
            this.tbx_ghichu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbt_NXB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_QR = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtg_showsach = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_chonanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showtl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QR)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showsach)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbt_tg
            // 
            this.tbt_tg.Location = new System.Drawing.Point(113, 151);
            this.tbt_tg.Name = "tbt_tg";
            this.tbt_tg.Size = new System.Drawing.Size(218, 27);
            this.tbt_tg.TabIndex = 1;
            // 
            // tbt_giatien
            // 
            this.tbt_giatien.Location = new System.Drawing.Point(113, 328);
            this.tbt_giatien.Name = "tbt_giatien";
            this.tbt_giatien.Size = new System.Drawing.Size(218, 27);
            this.tbt_giatien.TabIndex = 4;
            // 
            // tbt_tensach
            // 
            this.tbt_tensach.Location = new System.Drawing.Point(113, 240);
            this.tbt_tensach.Name = "tbt_tensach";
            this.tbt_tensach.Size = new System.Drawing.Size(218, 27);
            this.tbt_tensach.TabIndex = 5;
            // 
            // tbt_soluong
            // 
            this.tbt_soluong.Location = new System.Drawing.Point(113, 287);
            this.tbt_soluong.Name = "tbt_soluong";
            this.tbt_soluong.ReadOnly = true;
            this.tbt_soluong.Size = new System.Drawing.Size(218, 27);
            this.tbt_soluong.TabIndex = 6;
            this.tbt_soluong.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "NXB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giá tiền";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(641, 17);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 44);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(793, 17);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 44);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(641, 73);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 44);
            this.btn_xoa.TabIndex = 19;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // tbt_timkiem
            // 
            this.tbt_timkiem.Location = new System.Drawing.Point(6, 27);
            this.tbt_timkiem.Name = "tbt_timkiem";
            this.tbt_timkiem.Size = new System.Drawing.Size(268, 27);
            this.tbt_timkiem.TabIndex = 20;
            this.tbt_timkiem.TextChanged += new System.EventHandler(this.tbt_timkiem_TextChanged);
            // 
            // dtg_showtl
            // 
            this.dtg_showtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.dtg_showtl.Location = new System.Drawing.Point(6, 27);
            this.dtg_showtl.Name = "dtg_showtl";
            this.dtg_showtl.RowHeadersWidth = 51;
            this.dtg_showtl.RowTemplate.Height = 29;
            this.dtg_showtl.Size = new System.Drawing.Size(207, 271);
            this.dtg_showtl.TabIndex = 22;
            this.dtg_showtl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showtl_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "STT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 45;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thể Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_barcode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbx_ma);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_theLoai);
            this.groupBox1.Controls.Add(this.tbx_ghichu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbt_NXB);
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
            this.groupBox1.Location = new System.Drawing.Point(250, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 417);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // tbx_barcode
            // 
            this.tbx_barcode.Location = new System.Drawing.Point(112, 108);
            this.tbx_barcode.Name = "tbx_barcode";
            this.tbx_barcode.Size = new System.Drawing.Size(218, 27);
            this.tbx_barcode.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mã vạch";
            // 
            // tbx_ma
            // 
            this.tbx_ma.Location = new System.Drawing.Point(113, 65);
            this.tbx_ma.Name = "tbx_ma";
            this.tbx_ma.Size = new System.Drawing.Size(218, 27);
            this.tbx_ma.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mã sách";
            // 
            // cmb_theLoai
            // 
            this.cmb_theLoai.FormattingEnabled = true;
            this.cmb_theLoai.Location = new System.Drawing.Point(112, 21);
            this.cmb_theLoai.Name = "cmb_theLoai";
            this.cmb_theLoai.Size = new System.Drawing.Size(218, 28);
            this.cmb_theLoai.TabIndex = 21;
            // 
            // tbx_ghichu
            // 
            this.tbx_ghichu.Location = new System.Drawing.Point(113, 373);
            this.tbx_ghichu.Name = "tbx_ghichu";
            this.tbx_ghichu.Size = new System.Drawing.Size(218, 27);
            this.tbx_ghichu.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ghi chú";
            // 
            // tbt_NXB
            // 
            this.tbt_NXB.Location = new System.Drawing.Point(113, 196);
            this.tbt_NXB.Name = "tbt_NXB";
            this.tbt_NXB.Size = new System.Drawing.Size(218, 27);
            this.tbt_NXB.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptb_QR);
            this.panel1.Location = new System.Drawing.Point(651, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 140);
            this.panel1.TabIndex = 28;
            // 
            // ptb_QR
            // 
            this.ptb_QR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptb_QR.Location = new System.Drawing.Point(2, 4);
            this.ptb_QR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_QR.Name = "ptb_QR";
            this.ptb_QR.Size = new System.Drawing.Size(263, 140);
            this.ptb_QR.TabIndex = 0;
            this.ptb_QR.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_showtl);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 304);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thể Loại";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtg_showsach);
            this.groupBox3.Location = new System.Drawing.Point(19, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 195);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dtg_showsach
            // 
            this.dtg_showsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showsach.Location = new System.Drawing.Point(6, 27);
            this.dtg_showsach.Name = "dtg_showsach";
            this.dtg_showsach.RowHeadersWidth = 51;
            this.dtg_showsach.RowTemplate.Height = 29;
            this.dtg_showsach.Size = new System.Drawing.Size(891, 176);
            this.dtg_showsach.TabIndex = 0;
            this.dtg_showsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showsach_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbt_timkiem);
            this.groupBox4.Location = new System.Drawing.Point(651, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 64);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(793, 73);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(115, 44);
            this.btn_start.TabIndex = 27;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_QR_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // cbb_chonanh
            // 
            this.cbb_chonanh.FormattingEnabled = true;
            this.cbb_chonanh.Location = new System.Drawing.Point(772, 151);
            this.cbb_chonanh.Name = "cbb_chonanh";
            this.cbb_chonanh.Size = new System.Drawing.Size(144, 28);
            this.cbb_chonanh.TabIndex = 29;
            // 
            // SachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 647);
            this.Controls.Add(this.cbb_chonanh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Name = "SachForm";
            this.Text = "SachForm";
            this.Load += new System.EventHandler(this.SachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showtl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QR)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showsach)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private TextBox tbx_ghichu;
        private Label label7;
        private Button btn_start;
        private Panel panel1;
        private PictureBox ptb_QR;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ComboBox cmb_theLoai;
        private TextBox tbx_barcode;
        private Label label9;
        private TextBox tbx_ma;
        private Label label8;
        private ComboBox cbb_chonanh;
    }
}