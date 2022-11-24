namespace _3_PL.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tbt_taikhoan = new System.Windows.Forms.TextBox();
            this.tbt_matkau = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbt_taikhoan
            // 
            this.tbt_taikhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbt_taikhoan.Location = new System.Drawing.Point(291, 161);
            this.tbt_taikhoan.Name = "tbt_taikhoan";
            this.tbt_taikhoan.PlaceholderText = "Nhập Tài Khoản";
            this.tbt_taikhoan.Size = new System.Drawing.Size(386, 30);
            this.tbt_taikhoan.TabIndex = 0;
            // 
            // tbt_matkau
            // 
            this.tbt_matkau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbt_matkau.Location = new System.Drawing.Point(291, 235);
            this.tbt_matkau.Name = "tbt_matkau";
            this.tbt_matkau.PasswordChar = '*';
            this.tbt_matkau.PlaceholderText = "Nhập Mật Khẩu";
            this.tbt_matkau.Size = new System.Drawing.Size(386, 30);
            this.tbt_matkau.TabIndex = 1;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dangnhap.Location = new System.Drawing.Point(386, 315);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(213, 80);
            this.btn_dangnhap.TabIndex = 2;
            this.btn_dangnhap.Text = "ĐĂNG NHẬP";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 502);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.tbt_matkau);
            this.Controls.Add(this.tbt_taikhoan);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbt_taikhoan;
        private TextBox tbt_matkau;
        private Button btn_dangnhap;
    }
}