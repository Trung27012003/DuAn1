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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_thoigian = new System.Windows.Forms.Label();
            this.ptb_anhdaidien = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhdaidien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_thoigian);
            this.groupBox1.Controls.Add(this.ptb_anhdaidien);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO";
            // 
            // lb_thoigian
            // 
            this.lb_thoigian.AutoSize = true;
            this.lb_thoigian.Location = new System.Drawing.Point(12, 504);
            this.lb_thoigian.Name = "lb_thoigian";
            this.lb_thoigian.Size = new System.Drawing.Size(42, 20);
            this.lb_thoigian.TabIndex = 1;
            this.lb_thoigian.Text = "Time";
            // 
            // ptb_anhdaidien
            // 
            this.ptb_anhdaidien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_anhdaidien.BackgroundImage")));
            this.ptb_anhdaidien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_anhdaidien.Location = new System.Drawing.Point(6, 26);
            this.ptb_anhdaidien.Name = "ptb_anhdaidien";
            this.ptb_anhdaidien.Size = new System.Drawing.Size(253, 179);
            this.ptb_anhdaidien.TabIndex = 0;
            this.ptb_anhdaidien.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhdaidien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lb_thoigian;
        private PictureBox ptb_anhdaidien;
        private System.Windows.Forms.Timer timer1;
    }
}