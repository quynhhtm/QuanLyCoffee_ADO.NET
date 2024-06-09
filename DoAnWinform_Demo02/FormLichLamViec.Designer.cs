namespace DoAnWinform_Demo02
{
    partial class FormLichLamViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLichLamViec));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLichLV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TgBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TgKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mtbTgKetThuc = new System.Windows.Forms.MaskedTextBox();
            this.mtbTgBatDau = new System.Windows.Forms.MaskedTextBox();
            this.cbbCaLam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLV)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(57, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 543);
            this.panel2.TabIndex = 85;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvLichLV);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 542);
            this.panel3.TabIndex = 83;
            // 
            // dgvLichLV
            // 
            this.dgvLichLV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLV.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichLV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLichLV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichLV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLichLV.ColumnHeadersHeight = 50;
            this.dgvLichLV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTenNV,
            this.TenLLV,
            this.MaLLV,
            this.TgBatDau,
            this.TgKetThuc});
            this.dgvLichLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichLV.EnableHeadersVisualStyles = false;
            this.dgvLichLV.Location = new System.Drawing.Point(0, 0);
            this.dgvLichLV.Name = "dgvLichLV";
            this.dgvLichLV.ReadOnly = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichLV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLichLV.RowHeadersVisible = false;
            this.dgvLichLV.RowHeadersWidth = 51;
            this.dgvLichLV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvLichLV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLichLV.RowTemplate.DividerHeight = 1;
            this.dgvLichLV.RowTemplate.Height = 50;
            this.dgvLichLV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichLV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichLV.Size = new System.Drawing.Size(684, 540);
            this.dgvLichLV.TabIndex = 60;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Họ tên";
            this.HoTenNV.MinimumWidth = 6;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            // 
            // TenLLV
            // 
            this.TenLLV.DataPropertyName = "TenLLV";
            this.TenLLV.HeaderText = "Lịch làm việc";
            this.TenLLV.MinimumWidth = 6;
            this.TenLLV.Name = "TenLLV";
            this.TenLLV.ReadOnly = true;
            // 
            // MaLLV
            // 
            this.MaLLV.DataPropertyName = "MaLLV";
            this.MaLLV.HeaderText = "MaLLV";
            this.MaLLV.MinimumWidth = 6;
            this.MaLLV.Name = "MaLLV";
            this.MaLLV.ReadOnly = true;
            this.MaLLV.Visible = false;
            // 
            // TgBatDau
            // 
            this.TgBatDau.DataPropertyName = "TgBatDau";
            this.TgBatDau.HeaderText = "Giờ bắt đầu ";
            this.TgBatDau.MinimumWidth = 6;
            this.TgBatDau.Name = "TgBatDau";
            this.TgBatDau.ReadOnly = true;
            // 
            // TgKetThuc
            // 
            this.TgKetThuc.DataPropertyName = "TgKetThuc";
            this.TgKetThuc.HeaderText = "Giờ kết thúc";
            this.TgKetThuc.MinimumWidth = 6;
            this.TgKetThuc.Name = "TgKetThuc";
            this.TgKetThuc.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.mtbTgKetThuc);
            this.panel4.Controls.Add(this.mtbTgBatDau);
            this.panel4.Controls.Add(this.cbbCaLam);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Controls.Add(this.btnHuy);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(691, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 541);
            this.panel4.TabIndex = 82;
            // 
            // mtbTgKetThuc
            // 
            this.mtbTgKetThuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTgKetThuc.Location = new System.Drawing.Point(164, 310);
            this.mtbTgKetThuc.Mask = "90:00";
            this.mtbTgKetThuc.Name = "mtbTgKetThuc";
            this.mtbTgKetThuc.Size = new System.Drawing.Size(135, 34);
            this.mtbTgKetThuc.TabIndex = 90;
            this.mtbTgKetThuc.ValidatingType = typeof(System.DateTime);
            // 
            // mtbTgBatDau
            // 
            this.mtbTgBatDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTgBatDau.Location = new System.Drawing.Point(164, 217);
            this.mtbTgBatDau.Mask = "90:00";
            this.mtbTgBatDau.Name = "mtbTgBatDau";
            this.mtbTgBatDau.Size = new System.Drawing.Size(135, 34);
            this.mtbTgBatDau.TabIndex = 89;
            this.mtbTgBatDau.ValidatingType = typeof(System.DateTime);
            // 
            // cbbCaLam
            // 
            this.cbbCaLam.BackColor = System.Drawing.Color.White;
            this.cbbCaLam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCaLam.FormattingEnabled = true;
            this.cbbCaLam.Location = new System.Drawing.Point(164, 124);
            this.cbbCaLam.Name = "cbbCaLam";
            this.cbbCaLam.Size = new System.Drawing.Size(199, 36);
            this.cbbCaLam.TabIndex = 88;
            this.cbbCaLam.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiNL_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 87;
            this.label4.Text = "Ca làm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 41);
            this.label3.TabIndex = 86;
            this.label3.Text = "Thông tin chi tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 82;
            this.label2.Text = "Giờ kết thúc: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "Giờ bắt đầu:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1197, 154);
            this.panel5.TabIndex = 84;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.txtThongTin);
            this.panel6.Location = new System.Drawing.Point(297, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(567, 49);
            this.panel6.TabIndex = 3;
            // 
            // txtThongTin
            // 
            this.txtThongTin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThongTin.BackColor = System.Drawing.Color.White;
            this.txtThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTin.Location = new System.Drawing.Point(46, 11);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(458, 27);
            this.txtThongTin.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.Tan;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(150, 472);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 50);
            this.btnSua.TabIndex = 91;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(273, 472);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 50);
            this.btnLuu.TabIndex = 84;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.IndianRed;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHuy.Image = global::DoAnWinform_Demo02.Properties.Resources.delete_document;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(28, 472);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 50);
            this.btnHuy.TabIndex = 85;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(858, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 49);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FormLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Name = "FormLichLamViec";
            this.Text = "FromLichLamViec";
            this.Load += new System.EventHandler(this.FormLichLamViec_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvLichLV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbTgKetThuc;
        private System.Windows.Forms.MaskedTextBox mtbTgBatDau;
        private System.Windows.Forms.ComboBox cbbCaLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TgBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TgKetThuc;
        private System.Windows.Forms.Button btnSua;
    }
}