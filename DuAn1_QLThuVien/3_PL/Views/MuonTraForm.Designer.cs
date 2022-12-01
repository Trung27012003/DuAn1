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
            this.dtg_pc = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtg_ds = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_uppm = new System.Windows.Forms.Button();
            this.btn_xoapm = new System.Windows.Forms.Button();
            this.btn_suapm = new System.Windows.Forms.Button();
            this.btn_thempm = new System.Windows.Forms.Button();
            this.dtg_pmct = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tp_muon.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pc)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ds)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pmct)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_muon);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_muon
            // 
            this.tp_muon.Controls.Add(this.groupBox4);
            this.tp_muon.Controls.Add(this.groupBox3);
            this.tp_muon.Controls.Add(this.groupBox2);
            this.tp_muon.Controls.Add(this.groupBox1);
            this.tp_muon.Location = new System.Drawing.Point(4, 24);
            this.tp_muon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_muon.Name = "tp_muon";
            this.tp_muon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_muon.Size = new System.Drawing.Size(898, 468);
            this.tp_muon.TabIndex = 0;
            this.tp_muon.Text = "MƯỢN SÁCH";
            this.tp_muon.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtg_pc);
            this.groupBox4.Location = new System.Drawing.Point(628, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 296);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đơn chờ";
            // 
            // dtg_pc
            // 
            this.dtg_pc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_pc.Location = new System.Drawing.Point(6, 22);
            this.dtg_pc.Name = "dtg_pc";
            this.dtg_pc.RowTemplate.Height = 25;
            this.dtg_pc.Size = new System.Drawing.Size(252, 268);
            this.dtg_pc.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_thanhtoan);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(628, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 23);
            this.textBox3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID PM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dtg_ds);
            this.groupBox2.Location = new System.Drawing.Point(7, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Sách";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 23);
            this.textBox1.TabIndex = 1;
            // 
            // dtg_ds
            // 
            this.dtg_ds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dtg_ds.Location = new System.Drawing.Point(6, 51);
            this.dtg_ds.Name = "dtg_ds";
            this.dtg_ds.RowTemplate.Height = 25;
            this.dtg_ds.Size = new System.Drawing.Size(603, 152);
            this.dtg_ds.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_uppm);
            this.groupBox1.Controls.Add(this.btn_xoapm);
            this.groupBox1.Controls.Add(this.btn_suapm);
            this.groupBox1.Controls.Add(this.btn_thempm);
            this.groupBox1.Controls.Add(this.dtg_pmct);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Mượn Chi Tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(157, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền : ";
            // 
            // btn_uppm
            // 
            this.btn_uppm.Location = new System.Drawing.Point(506, 157);
            this.btn_uppm.Name = "btn_uppm";
            this.btn_uppm.Size = new System.Drawing.Size(103, 39);
            this.btn_uppm.TabIndex = 6;
            this.btn_uppm.Text = "Cập nhật";
            this.btn_uppm.UseVisualStyleBackColor = true;
            // 
            // btn_xoapm
            // 
            this.btn_xoapm.Location = new System.Drawing.Point(506, 112);
            this.btn_xoapm.Name = "btn_xoapm";
            this.btn_xoapm.Size = new System.Drawing.Size(103, 39);
            this.btn_xoapm.TabIndex = 5;
            this.btn_xoapm.Text = "Xóa";
            this.btn_xoapm.UseVisualStyleBackColor = true;
            // 
            // btn_suapm
            // 
            this.btn_suapm.Location = new System.Drawing.Point(506, 67);
            this.btn_suapm.Name = "btn_suapm";
            this.btn_suapm.Size = new System.Drawing.Size(103, 39);
            this.btn_suapm.TabIndex = 4;
            this.btn_suapm.Text = "Sửa";
            this.btn_suapm.UseVisualStyleBackColor = true;
            // 
            // btn_thempm
            // 
            this.btn_thempm.Location = new System.Drawing.Point(506, 22);
            this.btn_thempm.Name = "btn_thempm";
            this.btn_thempm.Size = new System.Drawing.Size(103, 39);
            this.btn_thempm.TabIndex = 3;
            this.btn_thempm.Text = "Thêm phiếu mượn";
            this.btn_thempm.UseVisualStyleBackColor = true;
            // 
            // dtg_pmct
            // 
            this.dtg_pmct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_pmct.Location = new System.Drawing.Point(6, 22);
            this.dtg_pmct.Name = "dtg_pmct";
            this.dtg_pmct.RowTemplate.Height = 25;
            this.dtg_pmct.Size = new System.Drawing.Size(494, 172);
            this.dtg_pmct.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(898, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TRẢ SÁCH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(90, 106);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(103, 39);
            this.btn_thanhtoan.TabIndex = 8;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thể Loại";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tác Giả";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            // 
            // MuonTraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(911, 499);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MuonTraForm";
            this.Text = "MuonTraForm";
            this.tabControl1.ResumeLayout(false);
            this.tp_muon.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pmct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage tp_muon;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private DataGridView dtg_pc;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private DataGridView dtg_ds;
        private Label label4;
        private Label label3;
        private Button btn_uppm;
        private Button btn_xoapm;
        private Button btn_suapm;
        private Button btn_thempm;
        private DataGridView dtg_pmct;
        private Button btn_thanhtoan;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}