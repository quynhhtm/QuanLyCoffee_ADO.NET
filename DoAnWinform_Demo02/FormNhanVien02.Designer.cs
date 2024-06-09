namespace DoAnWinform_Demo02
{
    partial class FormNhanVien02
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbPhai = new System.Windows.Forms.ComboBox();
            this.mtbNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.cbbTenLLV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnThemMoi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbbPhai);
            this.panel1.Controls.Add(this.mtbNgaySinh);
            this.panel1.Controls.Add(this.cbbTenLLV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 620);
            this.panel1.TabIndex = 76;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemMoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Image = global::DoAnWinform_Demo02.Properties.Resources.folder_download;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(323, 558);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 50);
            this.btnThemMoi.TabIndex = 79;
            this.btnThemMoi.Text = "Lưu ";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::DoAnWinform_Demo02.Properties.Resources.delete_document;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(440, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 80;
            this.button1.Text = "Hủy";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 41);
            this.label6.TabIndex = 81;
            this.label6.Text = "Thông tin nhân viên ";
            // 
            // cbbPhai
            // 
            this.cbbPhai.BackColor = System.Drawing.Color.White;
            this.cbbPhai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhai.FormattingEnabled = true;
            this.cbbPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbPhai.Location = new System.Drawing.Point(218, 386);
            this.cbbPhai.Name = "cbbPhai";
            this.cbbPhai.Size = new System.Drawing.Size(147, 36);
            this.cbbPhai.TabIndex = 32;
            // 
            // mtbNgaySinh
            // 
            this.mtbNgaySinh.BackColor = System.Drawing.Color.White;
            this.mtbNgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNgaySinh.Location = new System.Drawing.Point(218, 240);
            this.mtbNgaySinh.Mask = "00/00/0000";
            this.mtbNgaySinh.Name = "mtbNgaySinh";
            this.mtbNgaySinh.Size = new System.Drawing.Size(147, 34);
            this.mtbNgaySinh.TabIndex = 31;
            this.mtbNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // cbbTenLLV
            // 
            this.cbbTenLLV.BackColor = System.Drawing.Color.White;
            this.cbbTenLLV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenLLV.FormattingEnabled = true;
            this.cbbTenLLV.Location = new System.Drawing.Point(218, 468);
            this.cbbTenLLV.Name = "cbbTenLLV";
            this.cbbTenLLV.Size = new System.Drawing.Size(265, 36);
            this.cbbTenLLV.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "Lịch làm việc: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Giới tính: ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(218, 311);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(265, 34);
            this.txtDiaChi.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày sinh:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.White;
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(218, 168);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(265, 34);
            this.txtTenNV.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Họ tên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.White;
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(218, 96);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(147, 34);
            this.txtMaNV.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên: ";
            // 
            // FormNhanVien02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 652);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhanVien02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhanVien02";
            this.Load += new System.EventHandler(this.FormNhanVien02_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtbNgaySinh;
        private System.Windows.Forms.ComboBox cbbTenLLV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPhai;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}