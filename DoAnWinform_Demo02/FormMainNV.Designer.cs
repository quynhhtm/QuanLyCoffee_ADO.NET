namespace DoAnWinform_Demo02
{
    partial class FormMainNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainNV));
            this.panel = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMaxed = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnGiaoDich = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.pnMain);
            this.panel.Controls.Add(this.panel6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(322, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1090, 900);
            this.panel.TabIndex = 8;
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Controls.Add(this.pictureBox2);
            this.pnMain.Location = new System.Drawing.Point(82, 53);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(932, 817);
            this.pnMain.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::DoAnWinform_Demo02.Properties.Resources.Fresh_Drink_White;
            this.pictureBox2.Location = new System.Drawing.Point(261, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(469, 407);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.btnMaxed);
            this.panel6.Controls.Add(this.btnMin);
            this.panel6.Controls.Add(this.btnMax);
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1090, 47);
            this.panel6.TabIndex = 0;
            // 
            // btnMaxed
            // 
            this.btnMaxed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxed.BackColor = System.Drawing.SystemColors.Control;
            this.btnMaxed.FlatAppearance.BorderSize = 0;
            this.btnMaxed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMaxed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaxed.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxed.Image")));
            this.btnMaxed.Location = new System.Drawing.Point(916, 12);
            this.btnMaxed.Name = "btnMaxed";
            this.btnMaxed.Size = new System.Drawing.Size(37, 32);
            this.btnMaxed.TabIndex = 3;
            this.btnMaxed.UseVisualStyleBackColor = false;
            this.btnMaxed.Visible = false;
            this.btnMaxed.Click += new System.EventHandler(this.btnMaxed_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.SystemColors.Control;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMin.Image = global::DoAnWinform_Demo02.Properties.Resources.minus_small;
            this.btnMin.Location = new System.Drawing.Point(959, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(37, 32);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.SystemColors.Control;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMax.Image = global::DoAnWinform_Demo02.Properties.Resources.stop;
            this.btnMax.Location = new System.Drawing.Point(1002, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(37, 32);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1045, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelSideMenu.Controls.Add(this.btnGiaoDich);
            this.panelSideMenu.Controls.Add(this.btnTrangChu);
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(322, 900);
            this.panelSideMenu.TabIndex = 7;
            // 
            // btnGiaoDich
            // 
            this.btnGiaoDich.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGiaoDich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiaoDich.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoDich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoDich.Image = global::DoAnWinform_Demo02.Properties.Resources.lending;
            this.btnGiaoDich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoDich.Location = new System.Drawing.Point(0, 206);
            this.btnGiaoDich.Name = "btnGiaoDich";
            this.btnGiaoDich.Padding = new System.Windows.Forms.Padding(20, 0, 105, 0);
            this.btnGiaoDich.Size = new System.Drawing.Size(322, 50);
            this.btnGiaoDich.TabIndex = 12;
            this.btnGiaoDich.Text = "Giao dịch";
            this.btnGiaoDich.UseVisualStyleBackColor = false;
            this.btnGiaoDich.Click += new System.EventHandler(this.btnGiaoDich_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.Image = global::DoAnWinform_Demo02.Properties.Resources.house;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 153);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(20, 0, 100, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(322, 53);
            this.btnTrangChu.TabIndex = 4;
            this.btnTrangChu.Text = "Trang chủ ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.btnTaiKhoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 759);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 141);
            this.panel2.TabIndex = 11;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::DoAnWinform_Demo02.Properties.Resources.logout;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 53);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(20, 0, 92, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(322, 53);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.Text = "Đăng xuất ";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Image = global::DoAnWinform_Demo02.Properties.Resources.reset_password;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(20, 0, 100, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(322, 53);
            this.btnTaiKhoan.TabIndex = 11;
            this.btnTaiKhoan.Text = "Tài khoản ";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblTenDangNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 153);
            this.panel1.TabIndex = 0;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(124, 80);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(70, 28);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hi!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnWinform_Demo02.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 900);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "FormMainNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromMainNV";
            this.Load += new System.EventHandler(this.FormMainNV_Load);
            this.panel.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnMaxed;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnGiaoDich;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}