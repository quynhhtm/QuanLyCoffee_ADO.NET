namespace DoAnWinform_Demo02
{
    partial class FormThucUong01
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThucUong01));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvThucUong = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.MaThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucUong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvThucUong);
            this.panel2.Location = new System.Drawing.Point(53, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 470);
            this.panel2.TabIndex = 60;
            // 
            // dgvThucUong
            // 
            this.dgvThucUong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThucUong.BackgroundColor = System.Drawing.Color.White;
            this.dgvThucUong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThucUong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvThucUong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucUong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThucUong.ColumnHeadersHeight = 50;
            this.dgvThucUong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThucUong,
            this.TenThucUong,
            this.DonGia,
            this.TenNhom,
            this.Column1,
            this.Column2});
            this.dgvThucUong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThucUong.EnableHeadersVisualStyles = false;
            this.dgvThucUong.Location = new System.Drawing.Point(0, 0);
            this.dgvThucUong.Name = "dgvThucUong";
            this.dgvThucUong.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucUong.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThucUong.RowHeadersVisible = false;
            this.dgvThucUong.RowHeadersWidth = 51;
            this.dgvThucUong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvThucUong.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThucUong.RowTemplate.DividerHeight = 1;
            this.dgvThucUong.RowTemplate.Height = 50;
            this.dgvThucUong.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThucUong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucUong.Size = new System.Drawing.Size(697, 468);
            this.dgvThucUong.TabIndex = 59;
            this.dgvThucUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucUong_CellClick);
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
            this.panel1.TabIndex = 59;
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
            this.txtThongTin.Size = new System.Drawing.Size(458, 27);
            this.txtThongTin.TabIndex = 0;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemMoi.BackColor = System.Drawing.Color.White;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Image = global::DoAnWinform_Demo02.Properties.Resources.shopping_cart_add;
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
            // MaThucUong
            // 
            this.MaThucUong.DataPropertyName = "MaThucUong";
            this.MaThucUong.FillWeight = 80F;
            this.MaThucUong.HeaderText = "Mã thức uống ";
            this.MaThucUong.MinimumWidth = 6;
            this.MaThucUong.Name = "MaThucUong";
            this.MaThucUong.ReadOnly = true;
            // 
            // TenThucUong
            // 
            this.TenThucUong.DataPropertyName = "TenThucUong";
            this.TenThucUong.HeaderText = "Tên thức uống";
            this.TenThucUong.MinimumWidth = 6;
            this.TenThucUong.Name = "TenThucUong";
            this.TenThucUong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.FillWeight = 50F;
            this.DonGia.HeaderText = "Giá bán ";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "TenNhom";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.ReadOnly = true;
            this.TenNhom.Visible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 30F;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Chỉnh sửa";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 15F;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Xóa";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // FormThucUong01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormThucUong01";
            this.Text = "FormThucUong01";
            this.Load += new System.EventHandler(this.FormThucUong01_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucUong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvThucUong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}