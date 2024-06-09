namespace DoAnWinform_Demo02
{
    partial class FormNhanVien01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien01));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnThemMoi);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 154);
            this.panel1.TabIndex = 57;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtThongTin);
            this.panel3.Location = new System.Drawing.Point(53, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 49);
            this.panel3.TabIndex = 3;
            // 
            // txtThongTin
            // 
            this.txtThongTin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThongTin.BackColor = System.Drawing.Color.White;
            this.txtThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTin.Location = new System.Drawing.Point(46, 11);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(474, 27);
            this.txtThongTin.TabIndex = 0;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemMoi.BackColor = System.Drawing.Color.White;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Image = global::DoAnWinform_Demo02.Properties.Resources.user_add;
            this.btnThemMoi.Location = new System.Drawing.Point(687, 52);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(67, 49);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(614, 52);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(66, 49);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvNV
            // 
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.BackgroundColor = System.Drawing.Color.White;
            this.dgvNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNV.ColumnHeadersHeight = 50;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTenNV,
            this.Phai,
            this.NgSinh,
            this.DiaChi,
            this.MaLLV});
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNV.EnableHeadersVisualStyles = false;
            this.dgvNV.Location = new System.Drawing.Point(0, 0);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNV.RowHeadersVisible = false;
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvNV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNV.RowTemplate.DividerHeight = 1;
            this.dgvNV.RowTemplate.Height = 50;
            this.dgvNV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(699, 464);
            this.dgvNV.TabIndex = 59;
            this.dgvNV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNV_CellMouseClick);
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
            this.HoTenNV.HeaderText = "Họ tên ";
            this.HoTenNV.MinimumWidth = 6;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            // 
            // Phai
            // 
            this.Phai.DataPropertyName = "Phai";
            this.Phai.HeaderText = "Giới tính ";
            this.Phai.MinimumWidth = 6;
            this.Phai.Name = "Phai";
            this.Phai.ReadOnly = true;
            // 
            // NgSinh
            // 
            this.NgSinh.DataPropertyName = "NgSinh";
            this.NgSinh.HeaderText = "Ngày sinh";
            this.NgSinh.MinimumWidth = 6;
            this.NgSinh.Name = "NgSinh";
            this.NgSinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // MaLLV
            // 
            this.MaLLV.DataPropertyName = "MaLLV";
            this.MaLLV.HeaderText = "MALLV";
            this.MaLLV.MinimumWidth = 6;
            this.MaLLV.Name = "MaLLV";
            this.MaLLV.ReadOnly = true;
            this.MaLLV.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvNV);
            this.panel2.Location = new System.Drawing.Point(53, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 466);
            this.panel2.TabIndex = 58;
            // 
            // FormNhanVien01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNhanVien01";
            this.Text = "FormNhanVien01";
            this.Load += new System.EventHandler(this.FormNhanVien01_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLLV;
    }
}