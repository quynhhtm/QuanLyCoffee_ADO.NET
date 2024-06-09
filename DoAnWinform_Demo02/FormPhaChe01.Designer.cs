namespace DoAnWinform_Demo02
{
    partial class FormPhaChe01
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhaChe01));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThucUongNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvThucUong = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSet11 = new DoAnWinform_Demo02.DataSet1();
            this.MaThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucUong)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(54, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 521);
            this.panel2.TabIndex = 88;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvNguyenLieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(715, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 519);
            this.panel1.TabIndex = 85;
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguyenLieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNguyenLieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNguyenLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNguyenLieu.ColumnHeadersHeight = 50;
            this.dgvNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNL,
            this.MaNL,
            this.MaThucUongNL,
            this.Column2});
            this.dgvNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguyenLieu.EnableHeadersVisualStyles = false;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(0, 0);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguyenLieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNguyenLieu.RowHeadersVisible = false;
            this.dgvNguyenLieu.RowHeadersWidth = 51;
            this.dgvNguyenLieu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvNguyenLieu.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNguyenLieu.RowTemplate.DividerHeight = 1;
            this.dgvNguyenLieu.RowTemplate.Height = 50;
            this.dgvNguyenLieu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(378, 517);
            this.dgvNguyenLieu.TabIndex = 60;
            this.dgvNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguyenLieu_CellClick);
            // 
            // TenNL
            // 
            this.TenNL.DataPropertyName = "TenNL";
            this.TenNL.HeaderText = "Tên nguyên liệu ";
            this.TenNL.MinimumWidth = 6;
            this.TenNL.Name = "TenNL";
            this.TenNL.ReadOnly = true;
            // 
            // MaNL
            // 
            this.MaNL.DataPropertyName = "MaNL";
            this.MaNL.HeaderText = "MaNL";
            this.MaNL.MinimumWidth = 6;
            this.MaNL.Name = "MaNL";
            this.MaNL.ReadOnly = true;
            this.MaNL.Visible = false;
            // 
            // MaThucUongNL
            // 
            this.MaThucUongNL.DataPropertyName = "MaThucUongNL";
            this.MaThucUongNL.HeaderText = "MaThucUongNL";
            this.MaThucUongNL.MinimumWidth = 6;
            this.MaThucUongNL.Name = "MaThucUongNL";
            this.MaThucUongNL.ReadOnly = true;
            this.MaThucUongNL.Visible = false;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.FillWeight = 20F;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Xóa";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvThucUong);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 521);
            this.panel3.TabIndex = 83;
            // 
            // dgvThucUong
            // 
            this.dgvThucUong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThucUong.BackgroundColor = System.Drawing.Color.White;
            this.dgvThucUong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThucUong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvThucUong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucUong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThucUong.ColumnHeadersHeight = 50;
            this.dgvThucUong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThucUong,
            this.TenThucUong,
            this.DonGia,
            this.TenNhom,
            this.Column1});
            this.dgvThucUong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThucUong.EnableHeadersVisualStyles = false;
            this.dgvThucUong.Location = new System.Drawing.Point(0, 0);
            this.dgvThucUong.Name = "dgvThucUong";
            this.dgvThucUong.ReadOnly = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucUong.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvThucUong.RowHeadersVisible = false;
            this.dgvThucUong.RowHeadersWidth = 51;
            this.dgvThucUong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvThucUong.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvThucUong.RowTemplate.DividerHeight = 1;
            this.dgvThucUong.RowTemplate.Height = 50;
            this.dgvThucUong.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThucUong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucUong.Size = new System.Drawing.Size(708, 519);
            this.dgvThucUong.TabIndex = 60;
            this.dgvThucUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucUong_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1205, 154);
            this.panel5.TabIndex = 87;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.txtThongTin);
            this.panel6.Location = new System.Drawing.Point(292, 55);
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
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(853, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 49);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MaThucUong
            // 
            this.MaThucUong.DataPropertyName = "MaThucUong";
            this.MaThucUong.FillWeight = 50F;
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
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Visible = false;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.FillWeight = 20F;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Thêm";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // FormPhaChe01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Name = "FormPhaChe01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhaChe01";
            this.Load += new System.EventHandler(this.FormPhaChe01_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucUong)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dgvThucUong;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucUongNL;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}