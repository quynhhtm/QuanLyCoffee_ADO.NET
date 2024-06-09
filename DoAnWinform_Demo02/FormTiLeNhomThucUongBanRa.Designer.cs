namespace DoAnWinform_Demo02
{
    partial class FormTiLeNhomThucUongBanRa
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBieuDo = new System.Windows.Forms.Button();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(805, 508);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnBieuDo
            // 
            this.btnBieuDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBieuDo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBieuDo.FlatAppearance.BorderSize = 0;
            this.btnBieuDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBieuDo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBieuDo.Location = new System.Drawing.Point(615, 50);
            this.btnBieuDo.Name = "btnBieuDo";
            this.btnBieuDo.Size = new System.Drawing.Size(105, 36);
            this.btnBieuDo.TabIndex = 1;
            this.btnBieuDo.Text = "Biểu đồ";
            this.btnBieuDo.UseVisualStyleBackColor = false;
            this.btnBieuDo.Click += new System.EventHandler(this.btnBieuDo_Click);
            // 
            // cbbNam
            // 
            this.cbbNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(465, 51);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(84, 36);
            this.cbbNam.TabIndex = 2;
            // 
            // cbbThang
            // 
            this.cbbThang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbThang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(300, 51);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(57, 36);
            this.cbbThang.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(66, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 508);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBieuDo);
            this.panel2.Controls.Add(this.cbbNam);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbbThang);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 121);
            this.panel2.TabIndex = 7;
            // 
            // FormTiLeNhomThucUongBanRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormTiLeNhomThucUongBanRa";
            this.Text = "FormTiLeNhomThucUongBanRa";
            this.Load += new System.EventHandler(this.FormTiLeNhomThucUongBanRa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnBieuDo;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}