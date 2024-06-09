namespace DoAnWinform_Demo02
{
    partial class FormThongKe01
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.btnBieuDo = new System.Windows.Forms.Button();
            this.rdbDoanhThu = new System.Windows.Forms.RadioButton();
            this.rdbChiPhi = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbNam
            // 
            this.cbbNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(563, 46);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(89, 36);
            this.cbbNam.TabIndex = 1;
            // 
            // btnBieuDo
            // 
            this.btnBieuDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBieuDo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBieuDo.FlatAppearance.BorderSize = 0;
            this.btnBieuDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBieuDo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBieuDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBieuDo.Location = new System.Drawing.Point(706, 45);
            this.btnBieuDo.Name = "btnBieuDo";
            this.btnBieuDo.Size = new System.Drawing.Size(107, 37);
            this.btnBieuDo.TabIndex = 2;
            this.btnBieuDo.Text = "Biểu đồ";
            this.btnBieuDo.UseVisualStyleBackColor = false;
            this.btnBieuDo.Click += new System.EventHandler(this.btnBieuDo_Click);
            // 
            // rdbDoanhThu
            // 
            this.rdbDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbDoanhThu.AutoSize = true;
            this.rdbDoanhThu.Checked = true;
            this.rdbDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDoanhThu.Location = new System.Drawing.Point(126, 47);
            this.rdbDoanhThu.Name = "rdbDoanhThu";
            this.rdbDoanhThu.Size = new System.Drawing.Size(123, 32);
            this.rdbDoanhThu.TabIndex = 3;
            this.rdbDoanhThu.TabStop = true;
            this.rdbDoanhThu.Text = "DoanhThu";
            this.rdbDoanhThu.UseVisualStyleBackColor = true;
            // 
            // rdbChiPhi
            // 
            this.rdbChiPhi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbChiPhi.AutoSize = true;
            this.rdbChiPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChiPhi.Location = new System.Drawing.Point(294, 47);
            this.rdbChiPhi.Name = "rdbChiPhi";
            this.rdbChiPhi.Size = new System.Drawing.Size(200, 32);
            this.rdbChiPhi.TabIndex = 4;
            this.rdbChiPhi.Text = "Chi phí nguyên liệu";
            this.rdbChiPhi.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(67, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 492);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBieuDo);
            this.panel2.Controls.Add(this.cbbNam);
            this.panel2.Controls.Add(this.rdbChiPhi);
            this.panel2.Controls.Add(this.rdbDoanhThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 113);
            this.panel2.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(804, 492);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // FormThongKe01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 679);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormThongKe01";
            this.Text = "FormThongKe01";
            this.Load += new System.EventHandler(this.FormThongKe01_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBieuDo;
        private System.Windows.Forms.RadioButton rdbDoanhThu;
        private System.Windows.Forms.RadioButton rdbChiPhi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}