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
            this.button2 = new System.Windows.Forms.Button();
            this.lb_thoigian = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_muontra = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pn_body
            // 
            this.pn_body.Location = new System.Drawing.Point(219, 100);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(849, 449);
            this.pn_body.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.lb_thoigian);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.btn_muontra);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 537);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(0, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Mượn Sách - Trả Sách";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lb_thoigian
            // 
            this.lb_thoigian.AutoSize = true;
            this.lb_thoigian.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_thoigian.Location = new System.Drawing.Point(3, 504);
            this.lb_thoigian.Name = "lb_thoigian";
            this.lb_thoigian.Size = new System.Drawing.Size(43, 17);
            this.lb_thoigian.TabIndex = 8;
            this.lb_thoigian.Text = "label1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 442);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 42);
            this.button7.TabIndex = 7;
            this.button7.Text = "ĐĂNG XUẤT";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_muontra
            // 
            this.btn_muontra.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_muontra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_muontra.Location = new System.Drawing.Point(0, 153);
            this.btn_muontra.Name = "btn_muontra";
            this.btn_muontra.Size = new System.Drawing.Size(201, 46);
            this.btn_muontra.TabIndex = 1;
            this.btn_muontra.Text = "Mượn Sách - Trả Sách";
            this.btn_muontra.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 147);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(219, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 85);
            this.panel3.TabIndex = 3;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_body);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel pn_body;
        private Panel panel2;
        private Panel panel3;
        private Button btn_muontra;
        private Panel panel4;
        private Label lb_thoigian;
        private Button button7;
        private Button button2;
    }
}