namespace DoAnWinform_Demo02
{
    partial class FormReportHoaDonCungCapNL
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.chiTietHoaDonCungCapNLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DoAnWinform_Demo02.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chiTietHoaDonCungCapNLTableAdapter = new DoAnWinform_Demo02.DataSet1TableAdapters.ChiTietHoaDonCungCapNLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonCungCapNLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chiTietHoaDonCungCapNLBindingSource
            // 
            this.chiTietHoaDonCungCapNLBindingSource.DataMember = "ChiTietHoaDonCungCapNL";
            this.chiTietHoaDonCungCapNLBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.chiTietHoaDonCungCapNLBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnWinform_Demo02.ReportHoaDonCungNL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(823, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // chiTietHoaDonCungCapNLTableAdapter
            // 
            this.chiTietHoaDonCungCapNLTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportHoaDonCungCapNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 517);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "FormReportHoaDonCungCapNL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn cung cấp nguyên liệu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonCungCapNLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource chiTietHoaDonCungCapNLBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.ChiTietHoaDonCungCapNLTableAdapter chiTietHoaDonCungCapNLTableAdapter;
    }
}