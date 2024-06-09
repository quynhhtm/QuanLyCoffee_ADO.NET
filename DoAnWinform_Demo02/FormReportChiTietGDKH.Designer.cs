namespace DoAnWinform_Demo02
{
    partial class FormReportChiTietGDKH
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
            this.chiTietGiaoDichKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DoAnWinform_Demo02.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chiTietGiaoDichKHTableAdapter = new DoAnWinform_Demo02.DataSet1TableAdapters.ChiTietGiaoDichKHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietGiaoDichKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chiTietGiaoDichKHBindingSource
            // 
            this.chiTietGiaoDichKHBindingSource.DataMember = "ChiTietGiaoDichKH";
            this.chiTietGiaoDichKHBindingSource.DataSource = this.dataSet1;
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
            reportDataSource1.Value = this.chiTietGiaoDichKHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnWinform_Demo02.ReportChiTietGiaoDichKH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(824, 648);
            this.reportViewer1.TabIndex = 0;
            // 
            // chiTietGiaoDichKHTableAdapter
            // 
            this.chiTietGiaoDichKHTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportChiTietGDKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 648);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "FormReportChiTietGDKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử giao dịch";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietGiaoDichKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource chiTietGiaoDichKHBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.ChiTietGiaoDichKHTableAdapter chiTietGiaoDichKHTableAdapter;
    }
}