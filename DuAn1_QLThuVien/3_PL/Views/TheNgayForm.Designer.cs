namespace _3_PL.Views
{
    partial class TheNgayForm
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
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_starts = new System.Windows.Forms.DateTimePicker();
            this.rtb_ghichu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_ends = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.tbt_idnv = new System.Windows.Forms.TextBox();
            this.cbb_nhanvien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_loc = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(133, 148);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(334, 27);
            this.dtp_start.TabIndex = 0;
            // 
            // dtp_starts
            // 
            this.dtp_starts.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_starts.Location = new System.Drawing.Point(128, 284);
            this.dtp_starts.Name = "dtp_starts";
            this.dtp_starts.Size = new System.Drawing.Size(113, 27);
            this.dtp_starts.TabIndex = 1;
            // 
            // rtb_ghichu
            // 
            this.rtb_ghichu.Location = new System.Drawing.Point(494, 73);
            this.rtb_ghichu.Name = "rtb_ghichu";
            this.rtb_ghichu.Size = new System.Drawing.Size(262, 161);
            this.rtb_ghichu.TabIndex = 2;
            this.rtb_ghichu.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi chú";
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtg_show.Location = new System.Drawing.Point(14, 336);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.Size = new System.Drawing.Size(1003, 292);
            this.dtg_show.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            this.Column1.Width = 50;
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
            this.Column3.HeaderText = "Tên Nhân Viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Bắt Đầu";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày Kết Thúc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ghi Chú";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên nhân viên ";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(810, 47);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(175, 72);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(810, 148);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(175, 68);
            this.btn_in.TabIndex = 10;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tìm kiếm";
            // 
            // dtp_ends
            // 
            this.dtp_ends.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ends.Location = new System.Drawing.Point(287, 284);
            this.dtp_ends.Name = "dtp_ends";
            this.dtp_ends.Size = new System.Drawing.Size(124, 27);
            this.dtp_ends.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "đến";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(133, 207);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(334, 27);
            this.dtp_end.TabIndex = 15;
            // 
            // tbt_idnv
            // 
            this.tbt_idnv.Location = new System.Drawing.Point(133, 36);
            this.tbt_idnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_idnv.Name = "tbt_idnv";
            this.tbt_idnv.Size = new System.Drawing.Size(338, 27);
            this.tbt_idnv.TabIndex = 18;
            // 
            // cbb_nhanvien
            // 
            this.cbb_nhanvien.FormattingEnabled = true;
            this.cbb_nhanvien.Location = new System.Drawing.Point(133, 91);
            this.cbb_nhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_nhanvien.Name = "cbb_nhanvien";
            this.cbb_nhanvien.Size = new System.Drawing.Size(338, 28);
            this.cbb_nhanvien.TabIndex = 16;
            this.cbb_nhanvien.SelectedIndexChanged += new System.EventHandler(this.cbb_nhanvien_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã nhân viên ";
            // 
            // btn_loc
            // 
            this.btn_loc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_loc.IconColor = System.Drawing.Color.Black;
            this.btn_loc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_loc.Location = new System.Drawing.Point(433, 284);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(97, 33);
            this.btn_loc.TabIndex = 19;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // TheNgayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 629);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.tbt_idnv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbb_nhanvien);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_ends);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtg_show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_ghichu);
            this.Controls.Add(this.dtp_starts);
            this.Controls.Add(this.dtp_start);
            this.Name = "TheNgayForm";
            this.Text = "TheNgayForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_start;
        private DateTimePicker dtp_starts;
        private RichTextBox rtb_ghichu;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dtg_show;
        private Label label4;
        private Button btn_them;
        private Button btn_in;
        private Label label5;
        private DateTimePicker dtp_ends;
        private Label label6;
        private DateTimePicker dtp_end;
        private TextBox tbt_idnv;
        private ComboBox cbb_nhanvien;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private FontAwesome.Sharp.IconButton btn_loc;
    }
}