
namespace QuanLyBanDoAnNhanh
{
    partial class ListFoodReport
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
            this.QuanLyBanDoAnNhanhDataSet1 = new QuanLyBanDoAnNhanh.QuanLyBanDoAnNhanhDataSet1();
            this.USP_GetListFoodReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_GetListFoodReportTableAdapter = new QuanLyBanDoAnNhanh.QuanLyBanDoAnNhanhDataSet1TableAdapters.USP_GetListFoodReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanDoAnNhanhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListFoodReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetListFoodReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanDoAnNhanh.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLyBanDoAnNhanhDataSet1
            // 
            this.QuanLyBanDoAnNhanhDataSet1.DataSetName = "QuanLyBanDoAnNhanhDataSet1";
            this.QuanLyBanDoAnNhanhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_GetListFoodReportBindingSource
            // 
            this.USP_GetListFoodReportBindingSource.DataMember = "USP_GetListFoodReport";
            this.USP_GetListFoodReportBindingSource.DataSource = this.QuanLyBanDoAnNhanhDataSet1;
            // 
            // USP_GetListFoodReportTableAdapter
            // 
            this.USP_GetListFoodReportTableAdapter.ClearBeforeFill = true;
            // 
            // ListFoodReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListFoodReport";
            this.Text = "ListFoodReport";
            this.Load += new System.EventHandler(this.ListFoodReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanDoAnNhanhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListFoodReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_GetListFoodReportBindingSource;
        private QuanLyBanDoAnNhanhDataSet1 QuanLyBanDoAnNhanhDataSet1;
        private QuanLyBanDoAnNhanhDataSet1TableAdapters.USP_GetListFoodReportTableAdapter USP_GetListFoodReportTableAdapter;
    }
}