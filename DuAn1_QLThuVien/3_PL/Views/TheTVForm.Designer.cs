namespace _3_PL.Views
{
    partial class TheTVForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheTVForm));
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbt_tenthanhvien = new System.Windows.Forms.TextBox();
            this.tbt_timkiem = new System.Windows.Forms.TextBox();
            this.tbt_sdt = new System.Windows.Forms.TextBox();
            this.tbt_diachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_ghichu = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lb_tenthanhvien = new System.Windows.Forms.Label();
            this.lb_diacchi = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(15, 415);
            this.dtg_show.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.Size = new System.Drawing.Size(1125, 284);
            this.dtg_show.TabIndex = 0;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên thành viên";
            // 
            // tbt_tenthanhvien
            // 
            this.tbt_tenthanhvien.Location = new System.Drawing.Point(145, 46);
            this.tbt_tenthanhvien.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_tenthanhvien.Name = "tbt_tenthanhvien";
            this.tbt_tenthanhvien.Size = new System.Drawing.Size(298, 31);
            this.tbt_tenthanhvien.TabIndex = 2;
            this.tbt_tenthanhvien.TextChanged += new System.EventHandler(this.tbt_tenthanhvien_TextChanged);
            // 
            // tbt_timkiem
            // 
            this.tbt_timkiem.Location = new System.Drawing.Point(618, 355);
            this.tbt_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_timkiem.Name = "tbt_timkiem";
            this.tbt_timkiem.Size = new System.Drawing.Size(522, 31);
            this.tbt_timkiem.TabIndex = 3;
            this.tbt_timkiem.TextChanged += new System.EventHandler(this.tbt_timkiem_TextChanged);
            // 
            // tbt_sdt
            // 
            this.tbt_sdt.Location = new System.Drawing.Point(145, 170);
            this.tbt_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_sdt.Name = "tbt_sdt";
            this.tbt_sdt.Size = new System.Drawing.Size(298, 31);
            this.tbt_sdt.TabIndex = 5;
            this.tbt_sdt.TextChanged += new System.EventHandler(this.tbt_sdt_TextChanged);
            // 
            // tbt_diachi
            // 
            this.tbt_diachi.Location = new System.Drawing.Point(145, 109);
            this.tbt_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_diachi.Name = "tbt_diachi";
            this.tbt_diachi.Size = new System.Drawing.Size(298, 31);
            this.tbt_diachi.TabIndex = 6;
            this.tbt_diachi.TextChanged += new System.EventHandler(this.tbt_diachi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày kết thúc";
            // 
            // rtb_ghichu
            // 
            this.rtb_ghichu.Location = new System.Drawing.Point(155, 290);
            this.rtb_ghichu.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_ghichu.Name = "rtb_ghichu";
            this.rtb_ghichu.Size = new System.Drawing.Size(260, 98);
            this.rtb_ghichu.TabIndex = 13;
            this.rtb_ghichu.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ảnh đại diện";
            // 
            // dtp_ngaybatdau
            // 
            this.dtp_ngaybatdau.Location = new System.Drawing.Point(618, 40);
            this.dtp_ngaybatdau.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
            this.dtp_ngaybatdau.Size = new System.Drawing.Size(312, 31);
            this.dtp_ngaybatdau.TabIndex = 15;
            // 
            // dtp_ngayketthuc
            // 
            this.dtp_ngayketthuc.Location = new System.Drawing.Point(618, 104);
            this.dtp_ngayketthuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
            this.dtp_ngayketthuc.Size = new System.Drawing.Size(312, 31);
            this.dtp_ngayketthuc.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(618, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 172);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 364);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tìm kiếm";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(959, 40);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(181, 64);
            this.btn_them.TabIndex = 19;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(959, 130);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(181, 64);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(959, 226);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(181, 64);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(145, 234);
            this.dtp_ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(298, 31);
            this.dtp_ngaysinh.TabIndex = 22;
            // 
            // lb_tenthanhvien
            // 
            this.lb_tenthanhvien.AutoSize = true;
            this.lb_tenthanhvien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_tenthanhvien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_tenthanhvien.Location = new System.Drawing.Point(155, 49);
            this.lb_tenthanhvien.Name = "lb_tenthanhvien";
            this.lb_tenthanhvien.Size = new System.Drawing.Size(69, 25);
            this.lb_tenthanhvien.TabIndex = 23;
            this.lb_tenthanhvien.Text = "label10";
            // 
            // lb_diacchi
            // 
            this.lb_diacchi.AutoSize = true;
            this.lb_diacchi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_diacchi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_diacchi.Location = new System.Drawing.Point(155, 112);
            this.lb_diacchi.Name = "lb_diacchi";
            this.lb_diacchi.Size = new System.Drawing.Size(69, 25);
            this.lb_diacchi.TabIndex = 24;
            this.lb_diacchi.Text = "label10";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_sdt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_sdt.Location = new System.Drawing.Point(283, 173);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(69, 25);
            this.lb_sdt.TabIndex = 25;
            this.lb_sdt.Text = "label11";
            // 
            // TheTVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 705);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_diacchi);
            this.Controls.Add(this.lb_tenthanhvien);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_ngayketthuc);
            this.Controls.Add(this.dtp_ngaybatdau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtb_ghichu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbt_diachi);
            this.Controls.Add(this.tbt_sdt);
            this.Controls.Add(this.tbt_timkiem);
            this.Controls.Add(this.tbt_tenthanhvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_show);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TheTVForm";
            this.Text = "TheTVForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_show;
        private Label label1;
        private TextBox tbt_tenthanhvien;
        private TextBox tbt_timkiem;
        private TextBox tbt_sdt;
        private TextBox tbt_diachi;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox rtb_ghichu;
        private Label label8;
        private DateTimePicker dtp_ngaybatdau;
        private DateTimePicker dtp_ngayketthuc;
        private PictureBox pictureBox1;
        private Label label9;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private DateTimePicker dtp_ngaysinh;
        private Label lb_tenthanhvien;
        private Label lb_diacchi;
        private Label lb_sdt;
    }
}