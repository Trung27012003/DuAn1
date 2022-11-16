namespace _3_PL.Views
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pn_body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_thethanhvien = new System.Windows.Forms.Button();
            this.ptb_daidien = new System.Windows.Forms.PictureBox();
            this.btn_sach = new System.Windows.Forms.Button();
            this.lb_thoigian = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_muontra = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_daidien)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pn_body
            // 
            this.pn_body.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_body.AutoSize = true;
            this.pn_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_body.Location = new System.Drawing.Point(196, -1);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(884, 562);
            this.pn_body.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_nhanvien);
            this.panel2.Controls.Add(this.btn_thethanhvien);
            this.panel2.Controls.Add(this.ptb_daidien);
            this.panel2.Controls.Add(this.btn_sach);
            this.panel2.Controls.Add(this.lb_thoigian);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.btn_muontra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 561);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(0, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 46);
            this.button3.TabIndex = 13;
            this.button3.Text = "Thẻ Ngày";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.BackColor = System.Drawing.SystemColors.Info;
            this.btn_nhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nhanvien.Location = new System.Drawing.Point(0, 285);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(206, 46);
            this.btn_nhanvien.TabIndex = 12;
            this.btn_nhanvien.Text = "Nhân Viên";
            this.btn_nhanvien.UseVisualStyleBackColor = false;
            // 
            // btn_thethanhvien
            // 
            this.btn_thethanhvien.BackColor = System.Drawing.Color.IndianRed;
            this.btn_thethanhvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_thethanhvien.Location = new System.Drawing.Point(0, 241);
            this.btn_thethanhvien.Name = "btn_thethanhvien";
            this.btn_thethanhvien.Size = new System.Drawing.Size(206, 46);
            this.btn_thethanhvien.TabIndex = 11;
            this.btn_thethanhvien.Text = "Thẻ Thành Viên";
            this.btn_thethanhvien.UseVisualStyleBackColor = false;
            // 
            // ptb_daidien
            // 
            this.ptb_daidien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_daidien.BackgroundImage")));
            this.ptb_daidien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_daidien.Location = new System.Drawing.Point(3, 3);
            this.ptb_daidien.Name = "ptb_daidien";
            this.ptb_daidien.Size = new System.Drawing.Size(195, 144);
            this.ptb_daidien.TabIndex = 10;
            this.ptb_daidien.TabStop = false;
            this.ptb_daidien.Click += new System.EventHandler(this.ptb_daidien_Click);
            // 
            // btn_sach
            // 
            this.btn_sach.BackColor = System.Drawing.Color.Chocolate;
            this.btn_sach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sach.Location = new System.Drawing.Point(0, 197);
            this.btn_sach.Name = "btn_sach";
            this.btn_sach.Size = new System.Drawing.Size(206, 46);
            this.btn_sach.TabIndex = 9;
            this.btn_sach.Text = "Thông Tin Sách";
            this.btn_sach.UseVisualStyleBackColor = false;
            this.btn_sach.Click += new System.EventHandler(this.btn_sach_Click);
            // 
            // lb_thoigian
            // 
            this.lb_thoigian.AutoSize = true;
            this.lb_thoigian.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_thoigian.Location = new System.Drawing.Point(12, 535);
            this.lb_thoigian.Name = "lb_thoigian";
            this.lb_thoigian.Size = new System.Drawing.Size(43, 17);
            this.lb_thoigian.TabIndex = 8;
            this.lb_thoigian.Text = "label1";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Highlight;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(33, 468);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 42);
            this.button7.TabIndex = 7;
            this.button7.Text = "ĐĂNG XUẤT";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btn_muontra
            // 
            this.btn_muontra.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_muontra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_muontra.Location = new System.Drawing.Point(0, 153);
            this.btn_muontra.Name = "btn_muontra";
            this.btn_muontra.Size = new System.Drawing.Size(206, 46);
            this.btn_muontra.TabIndex = 1;
            this.btn_muontra.Text = "Mượn Sách - Trả Sách";
            this.btn_muontra.UseVisualStyleBackColor = false;
            this.btn_muontra.Click += new System.EventHandler(this.btn_muontra_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_body);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_daidien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel pn_body;
        private Panel panel2;
        private Button btn_muontra;
        private Label lb_thoigian;
        private Button button7;
        private Button btn_sach;
        private PictureBox ptb_daidien;
        private Button button3;
        private Button btn_nhanvien;
        private Button btn_thethanhvien;
    }
}