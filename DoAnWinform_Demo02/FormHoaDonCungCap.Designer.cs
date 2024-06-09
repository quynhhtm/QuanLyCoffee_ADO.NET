namespace DoAnWinform_Demo02
{
    partial class FormHoaDonCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHoaDonCungCap = new System.Windows.Forms.DataGridView();
            this.MaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbNL = new System.Windows.Forms.ComboBox();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonCungCap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDonCungCap
            // 
            this.dgvHoaDonCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonCungCap.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDonCungCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDonCungCap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHoaDonCungCap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDonCungCap.ColumnHeadersHeight = 50;
            this.dgvHoaDonCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNL,
            this.TenNL,
            this.SoLuong,
            this.DonGia});
            this.dgvHoaDonCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDonCungCap.EnableHeadersVisualStyles = false;
            this.dgvHoaDonCungCap.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDonCungCap.Name = "dgvHoaDonCungCap";
            this.dgvHoaDonCungCap.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonCungCap.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDonCungCap.RowHeadersVisible = false;
            this.dgvHoaDonCungCap.RowHeadersWidth = 51;
            this.dgvHoaDonCungCap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvHoaDonCungCap.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDonCungCap.RowTemplate.DividerHeight = 1;
            this.dgvHoaDonCungCap.RowTemplate.Height = 50;
            this.dgvHoaDonCungCap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDonCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonCungCap.Size = new System.Drawing.Size(648, 633);
            this.dgvHoaDonCungCap.TabIndex = 61;
            // 
            // MaNL
            // 
            this.MaNL.HeaderText = "Mã nguyên liệu";
            this.MaNL.MinimumWidth = 6;
            this.MaNL.Name = "MaNL";
            this.MaNL.ReadOnly = true;
            // 
            // TenNL
            // 
            this.TenNL.HeaderText = "Tên nguyên liệu";
            this.TenNL.MinimumWidth = 6;
            this.TenNL.Name = "TenNL";
            this.TenNL.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng ";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(61, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 635);
            this.panel1.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 633);
            this.panel3.TabIndex = 63;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Controls.Add(this.nudSoLuong);
            this.panel4.Controls.Add(this.cbbNL);
            this.panel4.Controls.Add(this.cbbNCC);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtDonGia);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnChon);
            this.panel4.Controls.Add(this.btnHuy);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 633);
            this.panel4.TabIndex = 83;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Image = global::DoAnWinform_Demo02.Properties.Resources.trash;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(133, 561);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 50);
            this.btnXoa.TabIndex = 95;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::DoAnWinform_Demo02.Properties.Resources.folder_download;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(365, 561);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 50);
            this.btnLuu.TabIndex = 94;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(221, 392);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 38);
            this.nudSoLuong.TabIndex = 93;
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbNL
            // 
            this.cbbNL.BackColor = System.Drawing.Color.White;
            this.cbbNL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNL.FormattingEnabled = true;
            this.cbbNL.Location = new System.Drawing.Point(221, 211);
            this.cbbNL.Name = "cbbNL";
            this.cbbNL.Size = new System.Drawing.Size(217, 36);
            this.cbbNL.TabIndex = 92;
            // 
            // cbbNCC
            // 
            this.cbbNCC.BackColor = System.Drawing.Color.White;
            this.cbbNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(221, 118);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(217, 36);
            this.cbbNCC.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 89;
            this.label4.Text = "Số lượng: ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(221, 304);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(217, 34);
            this.txtDonGia.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 87;
            this.label5.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 41);
            this.label3.TabIndex = 86;
            this.label3.Text = "Thông tin chi tiết";
            // 
            // btnChon
            // 
            this.btnChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChon.BackColor = System.Drawing.Color.BurlyWood;
            this.btnChon.FlatAppearance.BorderSize = 0;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Image = global::DoAnWinform_Demo02.Properties.Resources.shopping_cart_add;
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(249, 561);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(110, 50);
            this.btnChon.TabIndex = 84;
            this.btnChon.Text = "Chọn ";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHuy.Image = global::DoAnWinform_Demo02.Properties.Resources.delete_document;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(17, 561);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 50);
            this.btnHuy.TabIndex = 85;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nguyên liệu: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "Nhà cung cấp: ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvHoaDonCungCap);
            this.panel2.Location = new System.Drawing.Point(499, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 633);
            this.panel2.TabIndex = 62;
            // 
            // FormHoaDonCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 743);
            this.Controls.Add(this.panel1);
            this.Name = "FormHoaDonCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDonCungCap01";
            this.Load += new System.EventHandler(this.FormHoaDonCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonCungCap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDonCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cbbNL;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
    }
}