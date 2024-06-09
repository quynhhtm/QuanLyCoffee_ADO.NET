namespace DoAnWinform_Demo02
{
    partial class FormPhaChe02
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenThucUong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaThucUong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnThemMoi);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbbNguyenLieu);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMaNL);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTenThucUong);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtMaThucUong);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 486);
            this.panel2.TabIndex = 80;
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
            this.btnThemMoi.Location = new System.Drawing.Point(325, 421);
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
            this.button1.Location = new System.Drawing.Point(440, 421);
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
            this.label6.Location = new System.Drawing.Point(127, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 41);
            this.label6.TabIndex = 81;
            this.label6.Text = "Nguyên liệu pha chế";
            // 
            // cbbNguyenLieu
            // 
            this.cbbNguyenLieu.BackColor = System.Drawing.Color.White;
            this.cbbNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNguyenLieu.FormattingEnabled = true;
            this.cbbNguyenLieu.Location = new System.Drawing.Point(235, 315);
            this.cbbNguyenLieu.Name = "cbbNguyenLieu";
            this.cbbNguyenLieu.Size = new System.Drawing.Size(265, 36);
            this.cbbNguyenLieu.TabIndex = 30;
            this.cbbNguyenLieu.SelectedIndexChanged += new System.EventHandler(this.cbbNguyenLieu_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nguyên liệu:";
            // 
            // txtMaNL
            // 
            this.txtMaNL.BackColor = System.Drawing.Color.White;
            this.txtMaNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNL.Enabled = false;
            this.txtMaNL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNL.Location = new System.Drawing.Point(235, 245);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(153, 34);
            this.txtMaNL.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mã nguyên liệu";
            // 
            // txtTenThucUong
            // 
            this.txtTenThucUong.BackColor = System.Drawing.Color.White;
            this.txtTenThucUong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenThucUong.Enabled = false;
            this.txtTenThucUong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThucUong.Location = new System.Drawing.Point(235, 175);
            this.txtTenThucUong.Name = "txtTenThucUong";
            this.txtTenThucUong.Size = new System.Drawing.Size(259, 34);
            this.txtTenThucUong.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 28);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tên thức uống: ";
            // 
            // txtMaThucUong
            // 
            this.txtMaThucUong.BackColor = System.Drawing.Color.White;
            this.txtMaThucUong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaThucUong.Enabled = false;
            this.txtMaThucUong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThucUong.Location = new System.Drawing.Point(235, 103);
            this.txtMaThucUong.Name = "txtMaThucUong";
            this.txtMaThucUong.Size = new System.Drawing.Size(147, 34);
            this.txtMaThucUong.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã thức uống: ";
            // 
            // FormPhaChe02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 511);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhaChe02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhaChe02";
            this.Load += new System.EventHandler(this.FormPhaChe02_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNguyenLieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenThucUong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaThucUong;
        private System.Windows.Forms.Label label11;
    }
}