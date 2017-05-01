namespace WindowsFormsApplication1
{
    partial class AllDataReportView
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
            this.ManufactureDataSet = new WindowsFormsApplication1.ManufactureDataSet();
            this.allDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDataTableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.allDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "AllDataReport";
            reportDataSource1.Value = this.allDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(706, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // ManufactureDataSet
            // 
            this.ManufactureDataSet.DataSetName = "ManufactureDataSet";
            this.ManufactureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allDataBindingSource
            // 
            this.allDataBindingSource.DataMember = "allData";
            this.allDataBindingSource.DataSource = this.ManufactureDataSet;
            // 
            // allDataTableAdapter
            // 
            this.allDataTableAdapter.ClearBeforeFill = true;
            // 
            // AllDataReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AllDataReportView";
            this.Text = "AllDataReportView";
            this.Load += new System.EventHandler(this.AllDataReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource allDataBindingSource;
        private ManufactureDataSet ManufactureDataSet;
        private ManufactureDataSetTableAdapters.allDataTableAdapter allDataTableAdapter;
    }
}