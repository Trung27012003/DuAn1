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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.rtb_ghichu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.cbb_nhanvien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbt_idnv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(119, 112);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(210, 23);
            this.dtp_start.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(116, 215);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 23);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // rtb_ghichu
            // 
            this.rtb_ghichu.Location = new System.Drawing.Point(367, 89);
            this.rtb_ghichu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtb_ghichu.Name = "rtb_ghichu";
            this.rtb_ghichu.Size = new System.Drawing.Size(215, 91);
            this.rtb_ghichu.TabIndex = 2;
            this.rtb_ghichu.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi chú";
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(5, 254);
            this.dtg_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.Size = new System.Drawing.Size(802, 123);
            this.dtg_show.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên nhân viên ";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(646, 50);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(153, 54);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(646, 126);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(153, 51);
            this.btn_in.TabIndex = 10;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tìm kiếm";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(388, 215);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(210, 23);
            this.dateTimePicker3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "đến";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(120, 157);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(210, 23);
            this.dtp_end.TabIndex = 15;
            // 
            // cbb_nhanvien
            // 
            this.cbb_nhanvien.FormattingEnabled = true;
            this.cbb_nhanvien.Location = new System.Drawing.Point(116, 61);
            this.cbb_nhanvien.Name = "cbb_nhanvien";
            this.cbb_nhanvien.Size = new System.Drawing.Size(213, 23);
            this.cbb_nhanvien.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã nhân viên ";
            // 
            // tbt_idnv
            // 
            this.tbt_idnv.Location = new System.Drawing.Point(116, 27);
            this.tbt_idnv.Name = "tbt_idnv";
            this.tbt_idnv.Size = new System.Drawing.Size(213, 23);
            this.tbt_idnv.TabIndex = 18;
            // 
            // TheNgayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 386);
            this.Controls.Add(this.tbt_idnv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbb_nhanvien);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtg_show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_ghichu);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dtp_start);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TheNgayForm";
            this.Text = "TheNgayForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_start;
        private DateTimePicker dateTimePicker2;
        private RichTextBox rtb_ghichu;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dtg_show;
        private Label label4;
        private Button btn_them;
        private Button btn_in;
        private Label label5;
        private DateTimePicker dateTimePicker3;
        private Label label6;
        private DateTimePicker dtp_end;
        private ComboBox cbb_nhanvien;
        private Label label7;
        private TextBox tbt_idnv;
    }
}