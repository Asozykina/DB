namespace WindowsFormsApplication1
{
    partial class ReportView1
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
            this.ManufactureDataSet = new WindowsFormsApplication1.ManufactureDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.details2TableAdapter1 = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.Details2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ManufactureDataSet
            // 
            this.ManufactureDataSet.DataSetName = "ManufactureDataSet";
            this.ManufactureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // details2TableAdapter1
            // 
            this.details2TableAdapter1.ClearBeforeFill = true;
            // 
            // ReportView1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportView1";
            this.Text = "ReportView1";
            this.Load += new System.EventHandler(this.ReportView1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ManufactureDataSet ManufactureDataSet;
        private ManufactureDataSetTableAdapters.Details2TableAdapter details2TableAdapter1;
    }
}