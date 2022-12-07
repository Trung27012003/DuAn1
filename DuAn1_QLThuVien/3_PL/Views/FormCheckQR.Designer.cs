namespace _3_PL.Views
{
    partial class FormCheckQR
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
            this.ptb_camera = new System.Windows.Forms.PictureBox();
            this.btn_batcam = new WinFormsApp1.Custom_Controls.TvT_IconButton();
            this.rtb_showtt = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbb_chon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_camera
            // 
            this.ptb_camera.Location = new System.Drawing.Point(12, 12);
            this.ptb_camera.Name = "ptb_camera";
            this.ptb_camera.Size = new System.Drawing.Size(499, 359);
            this.ptb_camera.TabIndex = 0;
            this.ptb_camera.TabStop = false;
            // 
            // btn_batcam
            // 
            this.btn_batcam.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_batcam.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btn_batcam.BorderColor = System.Drawing.Color.Gray;
            this.btn_batcam.BorderRadius = 20;
            this.btn_batcam.BorderSize = 1;
            this.btn_batcam.FlatAppearance.BorderSize = 0;
            this.btn_batcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batcam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_batcam.ForeColor = System.Drawing.Color.Black;
            this.btn_batcam.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_batcam.IconColor = System.Drawing.Color.Black;
            this.btn_batcam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_batcam.Location = new System.Drawing.Point(557, 28);
            this.btn_batcam.Name = "btn_batcam";
            this.btn_batcam.Size = new System.Drawing.Size(139, 48);
            this.btn_batcam.TabIndex = 1;
            this.btn_batcam.Text = "Bật Camera";
            this.btn_batcam.TextColor = System.Drawing.Color.Black;
            this.btn_batcam.UseVisualStyleBackColor = false;
            this.btn_batcam.Click += new System.EventHandler(this.btn_batcam_Click);
            // 
            // rtb_showtt
            // 
            this.rtb_showtt.Location = new System.Drawing.Point(517, 173);
            this.rtb_showtt.Name = "rtb_showtt";
            this.rtb_showtt.Size = new System.Drawing.Size(196, 198);
            this.rtb_showtt.TabIndex = 3;
            this.rtb_showtt.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbb_chon
            // 
            this.cbb_chon.FormattingEnabled = true;
            this.cbb_chon.Location = new System.Drawing.Point(557, 120);
            this.cbb_chon.Name = "cbb_chon";
            this.cbb_chon.Size = new System.Drawing.Size(121, 23);
            this.cbb_chon.TabIndex = 4;
            // 
            // FormCheckQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 383);
            this.Controls.Add(this.cbb_chon);
            this.Controls.Add(this.rtb_showtt);
            this.Controls.Add(this.btn_batcam);
            this.Controls.Add(this.ptb_camera);
            this.Name = "FormCheckQR";
            this.Text = "FormCheckQR";
            this.Load += new System.EventHandler(this.FormCheckQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ptb_camera;
        private WinFormsApp1.Custom_Controls.TvT_IconButton btn_batcam;
        private RichTextBox rtb_showtt;
        private System.Windows.Forms.Timer timer1;
        private ComboBox cbb_chon;
    }
}