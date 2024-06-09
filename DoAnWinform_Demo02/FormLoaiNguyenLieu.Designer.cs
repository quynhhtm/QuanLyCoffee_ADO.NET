namespace DoAnWinform_Demo02
{
    partial class FormLoaiNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiNguyenLieu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLoaiNL = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTenLoaiNL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiNL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MaLoaiNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNL)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(56, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 513);
            this.panel2.TabIndex = 88;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvLoaiNL);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 512);
            this.panel3.TabIndex = 83;
            // 
            // dgvLoaiNL
            // 
            this.dgvLoaiNL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiNL.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiNL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLoaiNL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiNL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiNL.ColumnHeadersHeight = 50;
            this.dgvLoaiNL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiNL,
            this.TenLoaiNL,
            this.Column1,
            this.Column2});
            this.dgvLoaiNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiNL.EnableHeadersVisualStyles = false;
            this.dgvLoaiNL.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaiNL.Name = "dgvLoaiNL";
            this.dgvLoaiNL.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiNL.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoaiNL.RowHeadersVisible = false;
            this.dgvLoaiNL.RowHeadersWidth = 51;
            this.dgvLoaiNL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvLoaiNL.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLoaiNL.RowTemplate.DividerHeight = 1;
            this.dgvLoaiNL.RowTemplate.Height = 50;
            this.dgvLoaiNL.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiNL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiNL.Size = new System.Drawing.Size(753, 510);
            this.dgvLoaiNL.TabIndex = 59;
            this.dgvLoaiNL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiNL_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Controls.Add(this.btnHuy);
            this.panel4.Controls.Add(this.txtTenLoaiNL);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtMaLoaiNL);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(760, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 511);
            this.panel4.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 41);
            this.label3.TabIndex = 86;
            this.label3.Text = "Thông tin chi tiết";
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
            this.btnLuu.Location = new System.Drawing.Point(140, 446);
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
            this.btnHuy.Location = new System.Drawing.Point(272, 446);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 50);
            this.btnHuy.TabIndex = 85;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTenLoaiNL
            // 
            this.txtTenLoaiNL.BackColor = System.Drawing.Color.White;
            this.txtTenLoaiNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiNL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiNL.Location = new System.Drawing.Point(140, 243);
            this.txtTenLoaiNL.Name = "txtTenLoaiNL";
            this.txtTenLoaiNL.Size = new System.Drawing.Size(220, 34);
            this.txtTenLoaiNL.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên loại:";
            // 
            // txtMaLoaiNL
            // 
            this.txtMaLoaiNL.BackColor = System.Drawing.Color.White;
            this.txtMaLoaiNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLoaiNL.Enabled = false;
            this.txtMaLoaiNL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiNL.Location = new System.Drawing.Point(140, 136);
            this.txtMaLoaiNL.Name = "txtMaLoaiNL";
            this.txtMaLoaiNL.Size = new System.Drawing.Size(147, 34);
            this.txtMaLoaiNL.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "Mã loại:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1269, 154);
            this.panel5.TabIndex = 87;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.txtThongTin);
            this.panel6.Location = new System.Drawing.Point(285, 52);
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
            this.txtThongTin.Size = new System.Drawing.Size(482, 27);
            this.txtThongTin.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DoAnWinform_Demo02.Properties.Resources.shopping_cart_add;
            this.button1.Location = new System.Drawing.Point(919, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 49);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(846, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 49);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // MaLoaiNL
            // 
            this.MaLoaiNL.DataPropertyName = "MaLoaiNL";
            this.MaLoaiNL.HeaderText = "Mã loại nguyên liệu";
            this.MaLoaiNL.MinimumWidth = 6;
            this.MaLoaiNL.Name = "MaLoaiNL";
            this.MaLoaiNL.ReadOnly = true;
            // 
            // TenLoaiNL
            // 
            this.TenLoaiNL.DataPropertyName = "TenLoaiNL";
            this.TenLoaiNL.HeaderText = "Tên loại nguyên liệu";
            this.TenLoaiNL.MinimumWidth = 6;
            this.TenLoaiNL.Name = "TenLoaiNL";
            this.TenLoaiNL.ReadOnly = true;
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
            // FormLoaiNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Name = "FormLoaiNguyenLieu";
            this.Text = "FormLoaiNguyenLieu01";
            this.Load += new System.EventHandler(this.FormLoaiNguyenLieu01_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNL)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvLoaiNL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtTenLoaiNL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiNL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiNL;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}