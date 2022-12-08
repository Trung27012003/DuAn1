namespace _3_PL.Views
{
    partial class DoiMK
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
            this.tbx_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_repass = new System.Windows.Forms.TextBox();
            this.tbx_mkcu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_pass
            // 
            this.tbx_pass.Location = new System.Drawing.Point(341, 198);
            this.tbx_pass.Name = "tbx_pass";
            this.tbx_pass.Size = new System.Drawing.Size(370, 31);
            this.tbx_pass.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật khẩu mới";
            // 
            // tbx_repass
            // 
            this.tbx_repass.Location = new System.Drawing.Point(341, 266);
            this.tbx_repass.Name = "tbx_repass";
            this.tbx_repass.Size = new System.Drawing.Size(370, 31);
            this.tbx_repass.TabIndex = 17;
            // 
            // tbx_mkcu
            // 
            this.tbx_mkcu.Location = new System.Drawing.Point(341, 118);
            this.tbx_mkcu.Name = "tbx_mkcu";
            this.tbx_mkcu.Size = new System.Drawing.Size(370, 31);
            this.tbx_mkcu.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // btn_dn
            // 
            this.btn_dn.Location = new System.Drawing.Point(364, 368);
            this.btn_dn.Name = "btn_dn";
            this.btn_dn.Size = new System.Drawing.Size(228, 51);
            this.btn_dn.TabIndex = 13;
            this.btn_dn.Text = "Đổi mật khẩu";
            this.btn_dn.UseVisualStyleBackColor = true;
            this.btn_dn.Click += new System.EventHandler(this.btn_dn_Click);
            // 
            // SignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 526);
            this.Controls.Add(this.tbx_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_repass);
            this.Controls.Add(this.tbx_mkcu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dn);
            this.Name = "SignUP";
            this.Text = "SignUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbx_pass;
        private Label label3;
        private TextBox tbx_repass;
        private TextBox tbx_mkcu;
        private Label label2;
        private Label label1;
        private Button btn_dn;
    }
}