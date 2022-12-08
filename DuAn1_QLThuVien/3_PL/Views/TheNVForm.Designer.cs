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
            this.cbb_tenchucvu = new System.Windows.Forms.ComboBox();
            this.tbx_searchnv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbb_tenchucvu);
            this.tabPage1.Controls.Add(this.tbx_searchnv);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.pictureBox1);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(799, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbb_tenchucvu
            // 
            this.cbb_tenchucvu.FormattingEnabled = true;
            this.cbb_tenchucvu.Location = new System.Drawing.Point(113, 20);
            this.cbb_tenchucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_tenchucvu.Name = "cbb_tenchucvu";
            this.cbb_tenchucvu.Size = new System.Drawing.Size(195, 23);
            this.cbb_tenchucvu.TabIndex = 17;
            this.cbb_tenchucvu.SelectedIndexChanged += new System.EventHandler(this.cbb_tenchucvu_SelectedIndexChanged);
            // 
            // tbx_searchnv
            // 
            this.tbx_searchnv.Location = new System.Drawing.Point(592, 178);
            this.tbx_searchnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_searchnv.Name = "tbx_searchnv";
            this.tbx_searchnv.Size = new System.Drawing.Size(195, 23);
            this.tbx_searchnv.TabIndex = 16;
            this.tbx_searchnv.TextChanged += new System.EventHandler(this.tbx_searchnv_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm Kiếm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(372, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 136);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dgrid_shownv
            // 
            this.dgrid_shownv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_shownv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_shownv.Location = new System.Drawing.Point(6, 203);
            this.dgrid_shownv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_shownv.Name = "dgrid_shownv";
            this.dgrid_shownv.RowHeadersWidth = 51;
            this.dgrid_shownv.RowTemplate.Height = 29;
            this.dgrid_shownv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_shownv.Size = new System.Drawing.Size(788, 178);
            this.dgrid_shownv.TabIndex = 13;
            this.dgrid_shownv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_shownv_CellClick);
            // 
            // btn_xoanv
            // 
            this.btn_xoanv.Location = new System.Drawing.Point(649, 107);
            this.btn_xoanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoanv.Name = "btn_xoanv";
            this.btn_xoanv.Size = new System.Drawing.Size(124, 46);
            this.btn_xoanv.TabIndex = 12;
            this.btn_xoanv.Text = "XÓA";
            this.btn_xoanv.UseVisualStyleBackColor = true;
            this.btn_xoanv.Click += new System.EventHandler(this.btn_xoanv_Click);
            // 
            // btn_suanv
            // 
            this.btn_suanv.Location = new System.Drawing.Point(649, 57);
            this.btn_suanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_suanv.Name = "btn_suanv";
            this.btn_suanv.Size = new System.Drawing.Size(124, 46);
            this.btn_suanv.TabIndex = 11;
            this.btn_suanv.Text = "SỬA";
            this.btn_suanv.UseVisualStyleBackColor = true;
            this.btn_suanv.Click += new System.EventHandler(this.btn_suanv_Click);
            // 
            // btn_themnv
            // 
            this.btn_themnv.Location = new System.Drawing.Point(649, 7);
            this.btn_themnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themnv.Name = "btn_themnv";
            this.btn_themnv.Size = new System.Drawing.Size(124, 46);
            this.btn_themnv.TabIndex = 10;
            this.btn_themnv.Text = "THÊM";
            this.btn_themnv.UseVisualStyleBackColor = true;
            this.btn_themnv.Click += new System.EventHandler(this.btn_themnv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên chức vụ";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(113, 155);
            this.dtp_ngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(195, 23);
            this.dtp_ngaysinh.TabIndex = 4;
            // 
            // tbx_sdt
            // 
            this.tbx_sdt.Location = new System.Drawing.Point(113, 123);
            this.tbx_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_sdt.Name = "tbx_sdt";
            this.tbx_sdt.Size = new System.Drawing.Size(195, 23);
            this.tbx_sdt.TabIndex = 3;
            this.tbx_sdt.TextChanged += new System.EventHandler(this.tbx_sdt_TextChanged);
            // 
            // tbx_diachi
            // 
            this.tbx_diachi.Location = new System.Drawing.Point(113, 91);
            this.tbx_diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_diachi.Name = "tbx_diachi";
            this.tbx_diachi.Size = new System.Drawing.Size(195, 23);
            this.tbx_diachi.TabIndex = 2;
            this.tbx_diachi.TextChanged += new System.EventHandler(this.tbx_diachi_TextChanged);
            // 
            // tbx_tennv
            // 
            this.tbx_tennv.Location = new System.Drawing.Point(113, 52);
            this.tbx_tennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_tennv.Name = "tbx_tennv";
            this.tbx_tennv.Size = new System.Drawing.Size(195, 23);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(799, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chức vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên chức vụ";
            // 
            // tbx_tencv
            // 
            this.tbx_tencv.Location = new System.Drawing.Point(127, 37);
            this.tbx_tencv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_tencv.Name = "tbx_tencv";
            this.tbx_tencv.Size = new System.Drawing.Size(168, 23);
            this.tbx_tencv.TabIndex = 4;
            this.tbx_tencv.TextChanged += new System.EventHandler(this.tbx_tencv_TextChanged);
            // 
            // dgrid_show
            // 
            this.dgrid_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Location = new System.Drawing.Point(6, 211);
            this.dgrid_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_show.Size = new System.Drawing.Size(706, 156);
            this.dgrid_show.TabIndex = 3;
            this.dgrid_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(574, 56);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(138, 46);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(574, 106);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(138, 46);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(574, 4);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(138, 46);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // TheNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 409);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TheNVForm";
            this.Text = "TheTVForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox tbx_tencv;
        private DataGridView dgrid_show;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_them;
        private ComboBox cbb_tenchucvu;
        private SaveFileDialog saveFileDialog1;
    }
}