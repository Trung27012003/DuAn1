namespace _3_PL.Views
{
    partial class TheNVForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Show = new System.Windows.Forms.Button();
            this.grb_Anh = new System.Windows.Forms.GroupBox();
            this.cbb_DSCamera = new System.Windows.Forms.ComboBox();
            this.btn_Chup = new System.Windows.Forms.Button();
            this.ptb_Anh = new System.Windows.Forms.PictureBox();
            this.cbb_tenchucvu = new System.Windows.Forms.ComboBox();
            this.tbx_searchnv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgrid_shownv = new System.Windows.Forms.DataGridView();
            this.btn_xoanv = new System.Windows.Forms.Button();
            this.btn_suanv = new System.Windows.Forms.Button();
            this.btn_themnv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tbx_sdt = new System.Windows.Forms.TextBox();
            this.tbx_diachi = new System.Windows.Forms.TextBox();
            this.tbx_tennv = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_tencv = new System.Windows.Forms.TextBox();
            this.dgrid_show = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grb_Anh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_shownv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Show);
            this.tabPage1.Controls.Add(this.grb_Anh);
            this.tabPage1.Controls.Add(this.cbb_tenchucvu);
            this.tabPage1.Controls.Add(this.tbx_searchnv);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dgrid_shownv);
            this.tabPage1.Controls.Add(this.btn_xoanv);
            this.tabPage1.Controls.Add(this.btn_suanv);
            this.tabPage1.Controls.Add(this.btn_themnv);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtp_ngaysinh);
            this.tabPage1.Controls.Add(this.tbx_sdt);
            this.tabPage1.Controls.Add(this.tbx_diachi);
            this.tabPage1.Controls.Add(this.tbx_tennv);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(742, 6);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(142, 43);
            this.btn_Show.TabIndex = 21;
            this.btn_Show.Text = "HIỂN THỊ";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.button1_Click);
            // 
            // grb_Anh
            // 
            this.grb_Anh.Controls.Add(this.btn_Save);
            this.grb_Anh.Controls.Add(this.cbb_DSCamera);
            this.grb_Anh.Controls.Add(this.btn_Chup);
            this.grb_Anh.Controls.Add(this.ptb_Anh);
            this.grb_Anh.Location = new System.Drawing.Point(412, 6);
            this.grb_Anh.Name = "grb_Anh";
            this.grb_Anh.Size = new System.Drawing.Size(209, 259);
            this.grb_Anh.TabIndex = 18;
            this.grb_Anh.TabStop = false;
            this.grb_Anh.Text = "Ảnh";
            // 
            // cbb_DSCamera
            // 
            this.cbb_DSCamera.FormattingEnabled = true;
            this.cbb_DSCamera.Location = new System.Drawing.Point(6, 191);
            this.cbb_DSCamera.Name = "cbb_DSCamera";
            this.cbb_DSCamera.Size = new System.Drawing.Size(196, 28);
            this.cbb_DSCamera.TabIndex = 23;
            // 
            // btn_Chup
            // 
            this.btn_Chup.Location = new System.Drawing.Point(6, 225);
            this.btn_Chup.Name = "btn_Chup";
            this.btn_Chup.Size = new System.Drawing.Size(94, 29);
            this.btn_Chup.TabIndex = 22;
            this.btn_Chup.Text = "Chụp";
            this.btn_Chup.UseVisualStyleBackColor = true;
            this.btn_Chup.Click += new System.EventHandler(this.btn__Click);
            // 
            // ptb_Anh
            // 
            this.ptb_Anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Anh.Location = new System.Drawing.Point(6, 19);
            this.ptb_Anh.Name = "ptb_Anh";
            this.ptb_Anh.Size = new System.Drawing.Size(196, 166);
            this.ptb_Anh.TabIndex = 20;
            this.ptb_Anh.TabStop = false;
            // 
            // cbb_tenchucvu
            // 
            this.cbb_tenchucvu.FormattingEnabled = true;
            this.cbb_tenchucvu.Location = new System.Drawing.Point(129, 26);
            this.cbb_tenchucvu.Name = "cbb_tenchucvu";
            this.cbb_tenchucvu.Size = new System.Drawing.Size(222, 28);
            this.cbb_tenchucvu.TabIndex = 17;
            // 
            // tbx_searchnv
            // 
            this.tbx_searchnv.Location = new System.Drawing.Point(686, 238);
            this.tbx_searchnv.Name = "tbx_searchnv";
            this.tbx_searchnv.Size = new System.Drawing.Size(222, 27);
            this.tbx_searchnv.TabIndex = 16;
            this.tbx_searchnv.TextChanged += new System.EventHandler(this.tbx_searchnv_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(836, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm Kiếm";
            // 
            // dgrid_shownv
            // 
            this.dgrid_shownv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_shownv.Location = new System.Drawing.Point(13, 271);
            this.dgrid_shownv.Name = "dgrid_shownv";
            this.dgrid_shownv.RowHeadersWidth = 51;
            this.dgrid_shownv.RowTemplate.Height = 29;
            this.dgrid_shownv.Size = new System.Drawing.Size(901, 234);
            this.dgrid_shownv.TabIndex = 13;
            this.dgrid_shownv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_shownv_CellClick);
            // 
            // btn_xoanv
            // 
            this.btn_xoanv.Location = new System.Drawing.Point(742, 164);
            this.btn_xoanv.Name = "btn_xoanv";
            this.btn_xoanv.Size = new System.Drawing.Size(142, 48);
            this.btn_xoanv.TabIndex = 12;
            this.btn_xoanv.Text = "XÓA";
            this.btn_xoanv.UseVisualStyleBackColor = true;
            this.btn_xoanv.Click += new System.EventHandler(this.btn_xoanv_Click);
            // 
            // btn_suanv
            // 
            this.btn_suanv.Location = new System.Drawing.Point(742, 111);
            this.btn_suanv.Name = "btn_suanv";
            this.btn_suanv.Size = new System.Drawing.Size(142, 47);
            this.btn_suanv.TabIndex = 11;
            this.btn_suanv.Text = "SỬA";
            this.btn_suanv.UseVisualStyleBackColor = true;
            this.btn_suanv.Click += new System.EventHandler(this.btn_suanv_Click);
            // 
            // btn_themnv
            // 
            this.btn_themnv.Location = new System.Drawing.Point(742, 56);
            this.btn_themnv.Name = "btn_themnv";
            this.btn_themnv.Size = new System.Drawing.Size(142, 49);
            this.btn_themnv.TabIndex = 10;
            this.btn_themnv.Text = "THÊM";
            this.btn_themnv.UseVisualStyleBackColor = true;
            this.btn_themnv.Click += new System.EventHandler(this.btn_themnv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên chức vụ";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(129, 207);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(222, 27);
            this.dtp_ngaysinh.TabIndex = 4;
            // 
            // tbx_sdt
            // 
            this.tbx_sdt.Location = new System.Drawing.Point(129, 164);
            this.tbx_sdt.Name = "tbx_sdt";
            this.tbx_sdt.Size = new System.Drawing.Size(222, 27);
            this.tbx_sdt.TabIndex = 3;
            // 
            // tbx_diachi
            // 
            this.tbx_diachi.Location = new System.Drawing.Point(129, 121);
            this.tbx_diachi.Name = "tbx_diachi";
            this.tbx_diachi.Size = new System.Drawing.Size(222, 27);
            this.tbx_diachi.TabIndex = 2;
            // 
            // tbx_tennv
            // 
            this.tbx_tennv.Location = new System.Drawing.Point(129, 70);
            this.tbx_tennv.Name = "tbx_tennv";
            this.tbx_tennv.Size = new System.Drawing.Size(222, 27);
            this.tbx_tennv.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbx_tencv);
            this.tabPage2.Controls.Add(this.dgrid_show);
            this.tabPage2.Controls.Add(this.btn_sua);
            this.tabPage2.Controls.Add(this.btn_xoa);
            this.tabPage2.Controls.Add(this.btn_them);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chức vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên chức vụ";
            // 
            // tbx_tencv
            // 
            this.tbx_tencv.Location = new System.Drawing.Point(145, 49);
            this.tbx_tencv.Name = "tbx_tencv";
            this.tbx_tencv.Size = new System.Drawing.Size(192, 27);
            this.tbx_tencv.TabIndex = 4;
            // 
            // dgrid_show
            // 
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Location = new System.Drawing.Point(7, 281);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.Size = new System.Drawing.Size(807, 208);
            this.dgrid_show.TabIndex = 3;
            this.dgrid_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(656, 74);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(158, 62);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(656, 142);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(158, 62);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(656, 6);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(158, 62);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(109, 225);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 29);
            this.btn_Save.TabIndex = 24;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // TheNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "TheNVForm";
            this.Text = "Nhan vien";
            this.Load += new System.EventHandler(this.TheNVForm_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grb_Anh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_shownv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgrid_shownv;
        private Button btn_xoanv;
        private Button btn_suanv;
        private Button btn_themnv;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtp_ngaysinh;
        private TextBox tbx_sdt;
        private TextBox tbx_diachi;
        private TextBox tbx_tennv;
        private TabPage tabPage2;
        private TextBox tbx_searchnv;
        private Label label7;
        private TextBox tbx_tencv;
        private DataGridView dgrid_show;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_them;
        private ComboBox cbb_tenchucvu;
        private SaveFileDialog saveFileDialog1;
        private Button btn_Chup;
        private Button btn_Show;
        private GroupBox grb_Anh;
        private PictureBox ptb_Anh;
        private Label label6;
        private ComboBox cbb_DSCamera;
        private Button btn_Save;
    }
}