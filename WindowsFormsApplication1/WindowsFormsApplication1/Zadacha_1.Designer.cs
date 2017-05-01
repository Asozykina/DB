namespace WindowsFormsApplication1
{
    partial class Zadacha_1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detailCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparaionTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partCreatingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zadacha1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufactureDataSet = new WindowsFormsApplication1.ManufactureDataSet();
            this.zadacha1TableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.Zadacha1TableAdapter();
            this.textTime = new System.Windows.Forms.TextBox();
            this.btnFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailCodeDataGridViewTextBoxColumn,
            this.operationCodeDataGridViewTextBoxColumn,
            this.jobCodeDataGridViewTextBoxColumn,
            this.tariffCodeDataGridViewTextBoxColumn,
            this.preparaionTimeDataGridViewTextBoxColumn,
            this.partCreatingTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zadacha1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // detailCodeDataGridViewTextBoxColumn
            // 
            this.detailCodeDataGridViewTextBoxColumn.DataPropertyName = "detailCode";
            this.detailCodeDataGridViewTextBoxColumn.HeaderText = "detailCode";
            this.detailCodeDataGridViewTextBoxColumn.Name = "detailCodeDataGridViewTextBoxColumn";
            // 
            // operationCodeDataGridViewTextBoxColumn
            // 
            this.operationCodeDataGridViewTextBoxColumn.DataPropertyName = "operationCode";
            this.operationCodeDataGridViewTextBoxColumn.HeaderText = "operationCode";
            this.operationCodeDataGridViewTextBoxColumn.Name = "operationCodeDataGridViewTextBoxColumn";
            this.operationCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobCodeDataGridViewTextBoxColumn
            // 
            this.jobCodeDataGridViewTextBoxColumn.DataPropertyName = "jobCode";
            this.jobCodeDataGridViewTextBoxColumn.HeaderText = "jobCode";
            this.jobCodeDataGridViewTextBoxColumn.Name = "jobCodeDataGridViewTextBoxColumn";
            // 
            // tariffCodeDataGridViewTextBoxColumn
            // 
            this.tariffCodeDataGridViewTextBoxColumn.DataPropertyName = "tariffCode";
            this.tariffCodeDataGridViewTextBoxColumn.HeaderText = "tariffCode";
            this.tariffCodeDataGridViewTextBoxColumn.Name = "tariffCodeDataGridViewTextBoxColumn";
            // 
            // preparaionTimeDataGridViewTextBoxColumn
            // 
            this.preparaionTimeDataGridViewTextBoxColumn.DataPropertyName = "preparaionTime";
            this.preparaionTimeDataGridViewTextBoxColumn.HeaderText = "preparaionTime";
            this.preparaionTimeDataGridViewTextBoxColumn.Name = "preparaionTimeDataGridViewTextBoxColumn";
            // 
            // partCreatingTimeDataGridViewTextBoxColumn
            // 
            this.partCreatingTimeDataGridViewTextBoxColumn.DataPropertyName = "partCreatingTime";
            this.partCreatingTimeDataGridViewTextBoxColumn.HeaderText = "partCreatingTime";
            this.partCreatingTimeDataGridViewTextBoxColumn.Name = "partCreatingTimeDataGridViewTextBoxColumn";
            // 
            // zadacha1BindingSource
            // 
            this.zadacha1BindingSource.DataMember = "Zadacha1";
            this.zadacha1BindingSource.DataSource = this.manufactureDataSet;
            // 
            // manufactureDataSet
            // 
            this.manufactureDataSet.DataSetName = "ManufactureDataSet";
            this.manufactureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zadacha1TableAdapter
            // 
            this.zadacha1TableAdapter.ClearBeforeFill = true;
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(12, 169);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(240, 20);
            this.textTime.TabIndex = 1;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(13, 196);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(239, 23);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Ввести";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // Zadacha_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zadacha_1";
            this.Text = "Zadacha_1";
            this.Load += new System.EventHandler(this.Zadacha_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparaionTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCreatingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zadacha1BindingSource;
        private ManufactureDataSet manufactureDataSet;
        private ManufactureDataSetTableAdapters.Zadacha1TableAdapter zadacha1TableAdapter;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.Button btnFill;
    }
}