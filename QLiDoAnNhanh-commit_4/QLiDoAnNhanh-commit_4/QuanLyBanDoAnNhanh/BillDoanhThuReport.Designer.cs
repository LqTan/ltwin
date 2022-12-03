
namespace QuanLyBanDoAnNhanh
{
    partial class BillDoanhThuReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyBanDoAnNhanhDataSet = new QuanLyBanDoAnNhanh.QuanLyBanDoAnNhanhDataSet();
            this.USP_GetListBillByDateReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_GetListBillByDateReportTableAdapter = new QuanLyBanDoAnNhanh.QuanLyBanDoAnNhanhDataSetTableAdapters.USP_GetListBillByDateReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanDoAnNhanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetListBillByDateReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanDoAnNhanh.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLyBanDoAnNhanhDataSet
            // 
            this.QuanLyBanDoAnNhanhDataSet.DataSetName = "QuanLyBanDoAnNhanhDataSet";
            this.QuanLyBanDoAnNhanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_GetListBillByDateReportBindingSource
            // 
            this.USP_GetListBillByDateReportBindingSource.DataMember = "USP_GetListBillByDateReport";
            this.USP_GetListBillByDateReportBindingSource.DataSource = this.QuanLyBanDoAnNhanhDataSet;
            // 
            // USP_GetListBillByDateReportTableAdapter
            // 
            this.USP_GetListBillByDateReportTableAdapter.ClearBeforeFill = true;
            // 
            // BillDoanhThuReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BillDoanhThuReport";
            this.Text = "BillDoanhThuReport";
            this.Load += new System.EventHandler(this.BillDoanhThuReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanDoAnNhanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateReportBindingSource;
        private QuanLyBanDoAnNhanhDataSet QuanLyBanDoAnNhanhDataSet;
        private QuanLyBanDoAnNhanhDataSetTableAdapters.USP_GetListBillByDateReportTableAdapter USP_GetListBillByDateReportTableAdapter;
    }
}