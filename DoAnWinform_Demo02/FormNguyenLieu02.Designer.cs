namespace DoAnWinform_Demo02
{
    partial class FormNguyenLieu02
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
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLoaiNL = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnThemMoi);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbbLoaiNL);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTenNL);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtMaNL);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 427);
            this.panel2.TabIndex = 81;
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
            this.btnThemMoi.Location = new System.Drawing.Point(333, 365);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 50);
            this.btnThemMoi.TabIndex = 82;
            this.btnThemMoi.Text = "Lưu ";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::DoAnWinform_Demo02.Properties.Resources.delete_document;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(449, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 83;
            this.button2.Text = "Hủy";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 41);
            this.label6.TabIndex = 81;
            this.label6.Text = "Nguyên liệu";
            // 
            // cbbLoaiNL
            // 
            this.cbbLoaiNL.BackColor = System.Drawing.Color.White;
            this.cbbLoaiNL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiNL.FormattingEnabled = true;
            this.cbbLoaiNL.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbLoaiNL.Location = new System.Drawing.Point(258, 264);
            this.cbbLoaiNL.Name = "cbbLoaiNL";
            this.cbbLoaiNL.Size = new System.Drawing.Size(249, 36);
            this.cbbLoaiNL.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Loại nguyên liệu: ";
            // 
            // txtTenNL
            // 
            this.txtTenNL.BackColor = System.Drawing.Color.White;
            this.txtTenNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNL.Location = new System.Drawing.Point(258, 182);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(249, 34);
            this.txtTenNL.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên nguyên liệu:";
            // 
            // txtMaNL
            // 
            this.txtMaNL.BackColor = System.Drawing.Color.White;
            this.txtMaNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNL.Enabled = false;
            this.txtMaNL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNL.Location = new System.Drawing.Point(258, 108);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(147, 34);
            this.txtMaNL.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã nguyên liệu: ";
            // 
            // FormNguyenLieu02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 452);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNguyenLieu02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNguyenLieu02";
            this.Load += new System.EventHandler(this.FormNguyenLieu02_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbLoaiNL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label label10;
    }
}