namespace _3_PL.Views
{
    partial class frm_thongkedulieu
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
            this.cmb_loc = new System.Windows.Forms.ComboBox();
            this.dgrid_show2 = new System.Windows.Forms.DataGridView();
            this.dgrid_show1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_locpm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_loc
            // 
            this.cmb_loc.FormattingEnabled = true;
            this.cmb_loc.Location = new System.Drawing.Point(815, 12);
            this.cmb_loc.Name = "cmb_loc";
            this.cmb_loc.Size = new System.Drawing.Size(195, 28);
            this.cmb_loc.TabIndex = 7;
            this.cmb_loc.SelectedIndexChanged += new System.EventHandler(this.cmb_loc_SelectedIndexChanged);
            // 
            // dgrid_show2
            // 
            this.dgrid_show2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show2.Location = new System.Drawing.Point(6, 26);
            this.dgrid_show2.Name = "dgrid_show2";
            this.dgrid_show2.RowHeadersWidth = 51;
            this.dgrid_show2.RowTemplate.Height = 29;
            this.dgrid_show2.Size = new System.Drawing.Size(572, 588);
            this.dgrid_show2.TabIndex = 2;
            // 
            // dgrid_show1
            // 
            this.dgrid_show1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show1.Location = new System.Drawing.Point(6, 26);
            this.dgrid_show1.Name = "dgrid_show1";
            this.dgrid_show1.RowHeadersWidth = 51;
            this.dgrid_show1.RowTemplate.Height = 29;
            this.dgrid_show1.Size = new System.Drawing.Size(419, 588);
            this.dgrid_show1.TabIndex = 3;
            this.dgrid_show1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_show1);
            this.groupBox2.Location = new System.Drawing.Point(7, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 623);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mượn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrid_show2);
            this.groupBox1.Location = new System.Drawing.Point(444, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 623);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sách";
            // 
            // cmb_locpm
            // 
            this.cmb_locpm.FormattingEnabled = true;
            this.cmb_locpm.Location = new System.Drawing.Point(237, 17);
            this.cmb_locpm.Name = "cmb_locpm";
            this.cmb_locpm.Size = new System.Drawing.Size(195, 28);
            this.cmb_locpm.TabIndex = 10;
            this.cmb_locpm.SelectedIndexChanged += new System.EventHandler(this.tbx_locpm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lọc sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lọc thẻ";
            // 
            // frm_thongkedulieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 672);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_locpm);
            this.Controls.Add(this.cmb_loc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_thongkedulieu";
            this.Text = "frm_thongkedulieu";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_loc;
        private DataGridView dgrid_show2;
        private DataGridView dgrid_show1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ComboBox cmb_locpm;
        private Label label1;
        private Label label2;
    }
}