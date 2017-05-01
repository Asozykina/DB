namespace WindowsFormsApplication1
{
    partial class Zadacha_4
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
            this.btnFill = new System.Windows.Forms.Button();
            this.textDetail = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDetailDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zadacha1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufactureDataSet = new WindowsFormsApplication1.ManufactureDataSet();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsTableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.DetailsTableAdapter();
            this.zadacha1TableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.Zadacha1TableAdapter();
            this.assemblyTableAdapter1 = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.AssemblyTableAdapter();
            this.detailsTableAdapter1 = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.DetailsTableAdapter();
            this.labourInputTableAdapter1 = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.labourInputTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(23, 211);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(239, 23);
            this.btnFill.TabIndex = 5;
            this.btnFill.Text = "Ввести";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // textDetail
            // 
            this.textDetail.Location = new System.Drawing.Point(22, 184);
            this.textDetail.Name = "textDetail";
            this.textDetail.Size = new System.Drawing.Size(240, 20);
            this.textDetail.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDetailDataGridViewCheckBoxColumn,
            this.nameDetailDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zadacha1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // typeDetailDataGridViewCheckBoxColumn
            // 
            this.typeDetailDataGridViewCheckBoxColumn.DataPropertyName = "typeDetail";
            this.typeDetailDataGridViewCheckBoxColumn.HeaderText = "typeDetail";
            this.typeDetailDataGridViewCheckBoxColumn.Name = "typeDetailDataGridViewCheckBoxColumn";
            // 
            // nameDetailDataGridViewTextBoxColumn
            // 
            this.nameDetailDataGridViewTextBoxColumn.DataPropertyName = "nameDetail";
            this.nameDetailDataGridViewTextBoxColumn.HeaderText = "nameDetail";
            this.nameDetailDataGridViewTextBoxColumn.Name = "nameDetailDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "unitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "unitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
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
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "Details";
            this.detailsBindingSource.DataSource = this.manufactureDataSet;
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
            // 
            // zadacha1TableAdapter
            // 
            this.zadacha1TableAdapter.ClearBeforeFill = true;
            // 
            // assemblyTableAdapter1
            // 
            this.assemblyTableAdapter1.ClearBeforeFill = true;
            // 
            // detailsTableAdapter1
            // 
            this.detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // labourInputTableAdapter1
            // 
            this.labourInputTableAdapter1.ClearBeforeFill = true;
            // 
            // Zadacha_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.textDetail);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zadacha_4";
            this.Text = "Zadacha_4";
            this.Load += new System.EventHandler(this.Zadacha_4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.TextBox textDetail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ManufactureDataSet manufactureDataSet;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private ManufactureDataSetTableAdapters.DetailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDetailDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zadacha1BindingSource;
        private ManufactureDataSetTableAdapters.Zadacha1TableAdapter zadacha1TableAdapter;
        private ManufactureDataSetTableAdapters.AssemblyTableAdapter assemblyTableAdapter1;
        private ManufactureDataSetTableAdapters.DetailsTableAdapter detailsTableAdapter1;
        private ManufactureDataSetTableAdapters.labourInputTableAdapter labourInputTableAdapter1;
    }
}