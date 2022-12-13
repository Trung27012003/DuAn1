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
            this.ptb_AnhNV = new System.Windows.Forms.PictureBox();
            this.btn_Change = new System.Windows.Forms.Button();
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
            this.tp_Anh = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Again = new System.Windows.Forms.Button();
            this.ptb_Anh = new System.Windows.Forms.PictureBox();
            this.cbb_Camera = new System.Windows.Forms.ComboBox();
            this.btn_take = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grb_Anh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AnhNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_shownv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).BeginInit();
            this.tp_Anh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tp_Anh);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 547);
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
            this.tabPage1.Size = new System.Drawing.Size(914, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(742, 14);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(142, 49);
            this.btn_Show.TabIndex = 19;
            this.btn_Show.Text = "HIỂN THỊ";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // grb_Anh
            // 
            this.grb_Anh.Controls.Add(this.ptb_AnhNV);
            this.grb_Anh.Controls.Add(this.btn_Change);
            this.grb_Anh.Location = new System.Drawing.Point(397, 2);
            this.grb_Anh.Name = "grb_Anh";
            this.grb_Anh.Size = new System.Drawing.Size(247, 279);
            this.grb_Anh.TabIndex = 18;
            this.grb_Anh.TabStop = false;
            this.grb_Anh.Text = "Ảnh";
            // 
            // ptb_AnhNV
            // 
            this.ptb_AnhNV.Location = new System.Drawing.Point(6, 25);
            this.ptb_AnhNV.Name = "ptb_AnhNV";
            this.ptb_AnhNV.Size = new System.Drawing.Size(235, 207);
            this.ptb_AnhNV.TabIndex = 17;
            this.ptb_AnhNV.TabStop = false;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(76, 238);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(94, 29);
            this.btn_Change.TabIndex = 16;
            this.btn_Change.Text = "Đổi ảnh";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // cbb_tenchucvu
            // 
            this.cbb_tenchucvu.FormattingEnabled = true;
            this.cbb_tenchucvu.Location = new System.Drawing.Point(129, 27);
            this.cbb_tenchucvu.Name = "cbb_tenchucvu";
            this.cbb_tenchucvu.Size = new System.Drawing.Size(222, 28);
            this.cbb_tenchucvu.TabIndex = 17;
            this.cbb_tenchucvu.SelectedIndexChanged += new System.EventHandler(this.cbb_tenchucvu_SelectedIndexChanged);
            // 
            // tbx_searchnv
            // 
            this.tbx_searchnv.Location = new System.Drawing.Point(686, 254);
            this.tbx_searchnv.Name = "tbx_searchnv";
            this.tbx_searchnv.Size = new System.Drawing.Size(222, 27);
            this.tbx_searchnv.TabIndex = 16;
            this.tbx_searchnv.TextChanged += new System.EventHandler(this.tbx_searchnv_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(836, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm Kiếm";
            // 
            // dgrid_shownv
            // 
            this.dgrid_shownv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_shownv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_shownv.Location = new System.Drawing.Point(7, 287);
            this.dgrid_shownv.Name = "dgrid_shownv";
            this.dgrid_shownv.RowHeadersWidth = 51;
            this.dgrid_shownv.RowTemplate.Height = 29;
            this.dgrid_shownv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_shownv.Size = new System.Drawing.Size(901, 221);
            this.dgrid_shownv.TabIndex = 13;
            this.dgrid_shownv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_shownv_CellClick);
            // 
            // btn_xoanv
            // 
            this.btn_xoanv.Location = new System.Drawing.Point(742, 182);
            this.btn_xoanv.Name = "btn_xoanv";
            this.btn_xoanv.Size = new System.Drawing.Size(142, 43);
            this.btn_xoanv.TabIndex = 12;
            this.btn_xoanv.Text = "XÓA";
            this.btn_xoanv.UseVisualStyleBackColor = true;
            this.btn_xoanv.Click += new System.EventHandler(this.btn_xoanv_Click);
            // 
            // btn_suanv
            // 
            this.btn_suanv.Location = new System.Drawing.Point(742, 124);
            this.btn_suanv.Name = "btn_suanv";
            this.btn_suanv.Size = new System.Drawing.Size(142, 52);
            this.btn_suanv.TabIndex = 11;
            this.btn_suanv.Text = "SỬA";
            this.btn_suanv.UseVisualStyleBackColor = true;
            this.btn_suanv.Click += new System.EventHandler(this.btn_suanv_Click);
            // 
            // btn_themnv
            // 
            this.btn_themnv.Location = new System.Drawing.Point(742, 69);
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
            this.label5.Location = new System.Drawing.Point(27, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
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
            this.tbx_sdt.TextChanged += new System.EventHandler(this.tbx_sdt_TextChanged);
            // 
            // tbx_diachi
            // 
            this.tbx_diachi.Location = new System.Drawing.Point(129, 121);
            this.tbx_diachi.Name = "tbx_diachi";
            this.tbx_diachi.Size = new System.Drawing.Size(222, 27);
            this.tbx_diachi.TabIndex = 2;
            this.tbx_diachi.TextChanged += new System.EventHandler(this.tbx_diachi_TextChanged);
            // 
            // tbx_tennv
            // 
            this.tbx_tennv.Location = new System.Drawing.Point(129, 69);
            this.tbx_tennv.Name = "tbx_tennv";
            this.tbx_tennv.Size = new System.Drawing.Size(222, 27);
            this.tbx_tennv.TabIndex = 1;
            this.tbx_tennv.TextChanged += new System.EventHandler(this.tbx_tennv_TextChanged);
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
            this.tabPage2.Size = new System.Drawing.Size(914, 514);
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
            this.tbx_tencv.Size = new System.Drawing.Size(191, 27);
            this.tbx_tencv.TabIndex = 4;
            this.tbx_tencv.TextChanged += new System.EventHandler(this.tbx_tencv_TextChanged);
            // 
            // dgrid_show
            // 
            this.dgrid_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Location = new System.Drawing.Point(7, 281);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_show.Size = new System.Drawing.Size(807, 208);
            this.dgrid_show.TabIndex = 3;
            this.dgrid_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(656, 75);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(158, 61);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(656, 141);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(158, 61);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(656, 5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(158, 61);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tp_Anh
            // 
            this.tp_Anh.Controls.Add(this.label8);
            this.tp_Anh.Controls.Add(this.btn_Again);
            this.tp_Anh.Controls.Add(this.ptb_Anh);
            this.tp_Anh.Controls.Add(this.cbb_Camera);
            this.tp_Anh.Controls.Add(this.btn_take);
            this.tp_Anh.Location = new System.Drawing.Point(4, 29);
            this.tp_Anh.Name = "tp_Anh";
            this.tp_Anh.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Anh.Size = new System.Drawing.Size(914, 514);
            this.tp_Anh.TabIndex = 2;
            this.tp_Anh.Text = "Chụp ảnh";
            this.tp_Anh.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(602, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Máy ảnh";
            // 
            // btn_Again
            // 
            this.btn_Again.Location = new System.Drawing.Point(107, 6);
            this.btn_Again.Name = "btn_Again";
            this.btn_Again.Size = new System.Drawing.Size(94, 29);
            this.btn_Again.TabIndex = 21;
            this.btn_Again.Text = "Quay lại";
            this.btn_Again.UseVisualStyleBackColor = true;
            this.btn_Again.Click += new System.EventHandler(this.btn_Again_Click);
            // 
            // ptb_Anh
            // 
            this.ptb_Anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Anh.Location = new System.Drawing.Point(7, 41);
            this.ptb_Anh.Name = "ptb_Anh";
            this.ptb_Anh.Size = new System.Drawing.Size(901, 464);
            this.ptb_Anh.TabIndex = 20;
            this.ptb_Anh.TabStop = false;
            // 
            // cbb_Camera
            // 
            this.cbb_Camera.FormattingEnabled = true;
            this.cbb_Camera.Location = new System.Drawing.Point(673, 6);
            this.cbb_Camera.Name = "cbb_Camera";
            this.cbb_Camera.Size = new System.Drawing.Size(235, 28);
            this.cbb_Camera.TabIndex = 19;
            this.cbb_Camera.SelectedIndexChanged += new System.EventHandler(this.cbb_Camera_SelectedIndexChanged);
            // 
            // btn_take
            // 
            this.btn_take.Location = new System.Drawing.Point(7, 6);
            this.btn_take.Name = "btn_take";
            this.btn_take.Size = new System.Drawing.Size(94, 29);
            this.btn_take.TabIndex = 18;
            this.btn_take.Text = "Chụp ảnh";
            this.btn_take.UseVisualStyleBackColor = true;
            this.btn_take.Click += new System.EventHandler(this.btn_take_Click_1);
            // 
            // TheNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "TheNVForm";
            this.Text = "TheTVForm";
            this.Load += new System.EventHandler(this.TheNVForm_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grb_Anh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AnhNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_shownv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).EndInit();
            this.tp_Anh.ResumeLayout(false);
            this.tp_Anh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).EndInit();
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
        private Label label6;
        private Label label7;
        private TextBox tbx_tencv;
        private DataGridView dgrid_show;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_them;
        private ComboBox cbb_tenchucvu;
        private SaveFileDialog saveFileDialog1;
        private Button btn_Show;
        private GroupBox grb_Anh;
        private PictureBox ptb_AnhNV;
        private Button btn_Change;
        private TabPage tp_Anh;
        private Label label8;
        private Button btn_Again;
        private PictureBox ptb_Anh;
        private ComboBox cbb_Camera;
        private Button btn_take;
    }
}