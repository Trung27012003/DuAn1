namespace _3_PL.Views
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_forgotPassword = new System.Windows.Forms.Label();
            this.btn_login = new WinFormsApp1.Custom_Controls.TvT_IconButton();
            this.cbx_remember = new System.Windows.Forms.CheckBox();
            this.tbx_username = new _3_PL.custom_control.TvT_TextBox();
            this.tbx_password = new _3_PL.custom_control.TvT_TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_forgotPassword);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.cbx_remember);
            this.panel1.Controls.Add(this.tbx_username);
            this.panel1.Controls.Add(this.tbx_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(348, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 661);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.Location = new System.Drawing.Point(429, 4);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(60, 58);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(344, 555);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sign up";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_forgotPassword
            // 
            this.lbl_forgotPassword.AutoSize = true;
            this.lbl_forgotPassword.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_forgotPassword.ForeColor = System.Drawing.Color.Brown;
            this.lbl_forgotPassword.Location = new System.Drawing.Point(129, 555);
            this.lbl_forgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_forgotPassword.Name = "lbl_forgotPassword";
            this.lbl_forgotPassword.Size = new System.Drawing.Size(199, 25);
            this.lbl_forgotPassword.TabIndex = 5;
            this.lbl_forgotPassword.Text = "Forgot password?";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_login.BorderColor = System.Drawing.Color.DimGray;
            this.btn_login.BorderRadius = 30;
            this.btn_login.BorderSize = 1;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_login.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_login.IconColor = System.Drawing.Color.Black;
            this.btn_login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_login.Location = new System.Drawing.Point(111, 456);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(260, 82);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // cbx_remember
            // 
            this.cbx_remember.AutoSize = true;
            this.cbx_remember.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbx_remember.ForeColor = System.Drawing.Color.Gray;
            this.cbx_remember.Location = new System.Drawing.Point(48, 401);
            this.cbx_remember.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_remember.Name = "cbx_remember";
            this.cbx_remember.Size = new System.Drawing.Size(153, 29);
            this.cbx_remember.TabIndex = 3;
            this.cbx_remember.Text = "Remember";
            this.cbx_remember.UseVisualStyleBackColor = true;
            this.cbx_remember.CheckedChanged += new System.EventHandler(this.cbx_remember_CheckedChanged);
            // 
            // tbx_username
            // 
            this.tbx_username.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbx_username.BorderColor = System.Drawing.Color.Gray;
            this.tbx_username.BorderFocusColor = System.Drawing.Color.Green;
            this.tbx_username.BorderRadius = 15;
            this.tbx_username.BorderSize = 2;
            this.tbx_username.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_username.Location = new System.Drawing.Point(39, 220);
            this.tbx_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_username.Multiline = false;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Padding = new System.Windows.Forms.Padding(30, 11, 30, 11);
            this.tbx_username.PasswordChar = false;
            this.tbx_username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbx_username.PlaceholderText = "";
            this.tbx_username.Size = new System.Drawing.Size(405, 53);
            this.tbx_username.TabIndex = 1;
            this.tbx_username.Texts = "";
            this.tbx_username.UnderlinedStyle = false;
            // 
            // tbx_password
            // 
            this.tbx_password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbx_password.BorderColor = System.Drawing.Color.Gray;
            this.tbx_password.BorderFocusColor = System.Drawing.Color.Green;
            this.tbx_password.BorderRadius = 15;
            this.tbx_password.BorderSize = 2;
            this.tbx_password.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_password.Location = new System.Drawing.Point(39, 338);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_password.Multiline = false;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Padding = new System.Windows.Forms.Padding(30, 11, 30, 11);
            this.tbx_password.PasswordChar = true;
            this.tbx_password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbx_password.PlaceholderText = "";
            this.tbx_password.Size = new System.Drawing.Size(405, 53);
            this.tbx_password.TabIndex = 2;
            this.tbx_password.Texts = "";
            this.tbx_password.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(39, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(39, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(111, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Login";
            this.Text = "frm_Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label5;
        private Label lbl_forgotPassword;
        private WinFormsApp1.Custom_Controls.TvT_IconButton btn_login;
        private CheckBox cbx_remember;
        private custom_control.TvT_TextBox tbx_username;
        private custom_control.TvT_TextBox tbx_password;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}