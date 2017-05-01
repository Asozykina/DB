namespace WindowsFormsApplication1
{
    partial class ViewForm
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
            this.manufactureDataSet = new WindowsFormsApplication1.ManufactureDataSet();
            this.assemblyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assemblyTableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.AssemblyTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componenetCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partCreatingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allDataTableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.allDataTableAdapter();
            this.allDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // manufactureDataSet
            // 
            this.manufactureDataSet.DataSetName = "ManufactureDataSet";
            this.manufactureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assemblyBindingSource
            // 
            this.assemblyBindingSource.DataMember = "Assembly";
            this.assemblyBindingSource.DataSource = this.manufactureDataSet;
            // 
            // assemblyTableAdapter
            // 
            this.assemblyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDetailDataGridViewTextBoxColumn,
            this.nameDetailDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.finishedCodeDataGridViewTextBoxColumn,
            this.operationCodeDataGridViewTextBoxColumn,
            this.componenetCountDataGridViewTextBoxColumn,
            this.jobCodeDataGridViewTextBoxColumn,
            this.categoryCodeDataGridViewTextBoxColumn,
            this.tariffCodeDataGridViewTextBoxColumn,
            this.preparationTimeDataGridViewTextBoxColumn,
            this.partCreatingTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.allDataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1243, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // typeDetailDataGridViewTextBoxColumn
            // 
            this.typeDetailDataGridViewTextBoxColumn.DataPropertyName = "typeDetail";
            this.typeDetailDataGridViewTextBoxColumn.HeaderText = "typeDetail";
            this.typeDetailDataGridViewTextBoxColumn.Name = "typeDetailDataGridViewTextBoxColumn";
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
            // finishedCodeDataGridViewTextBoxColumn
            // 
            this.finishedCodeDataGridViewTextBoxColumn.DataPropertyName = "finishedCode";
            this.finishedCodeDataGridViewTextBoxColumn.HeaderText = "finishedCode";
            this.finishedCodeDataGridViewTextBoxColumn.Name = "finishedCodeDataGridViewTextBoxColumn";
            // 
            // operationCodeDataGridViewTextBoxColumn
            // 
            this.operationCodeDataGridViewTextBoxColumn.DataPropertyName = "operationCode";
            this.operationCodeDataGridViewTextBoxColumn.HeaderText = "operationCode";
            this.operationCodeDataGridViewTextBoxColumn.Name = "operationCodeDataGridViewTextBoxColumn";
            // 
            // componenetCountDataGridViewTextBoxColumn
            // 
            this.componenetCountDataGridViewTextBoxColumn.DataPropertyName = "componenetCount";
            this.componenetCountDataGridViewTextBoxColumn.HeaderText = "componenetCount";
            this.componenetCountDataGridViewTextBoxColumn.Name = "componenetCountDataGridViewTextBoxColumn";
            // 
            // jobCodeDataGridViewTextBoxColumn
            // 
            this.jobCodeDataGridViewTextBoxColumn.DataPropertyName = "jobCode";
            this.jobCodeDataGridViewTextBoxColumn.HeaderText = "jobCode";
            this.jobCodeDataGridViewTextBoxColumn.Name = "jobCodeDataGridViewTextBoxColumn";
            // 
            // categoryCodeDataGridViewTextBoxColumn
            // 
            this.categoryCodeDataGridViewTextBoxColumn.DataPropertyName = "categoryCode";
            this.categoryCodeDataGridViewTextBoxColumn.HeaderText = "categoryCode";
            this.categoryCodeDataGridViewTextBoxColumn.Name = "categoryCodeDataGridViewTextBoxColumn";
            // 
            // tariffCodeDataGridViewTextBoxColumn
            // 
            this.tariffCodeDataGridViewTextBoxColumn.DataPropertyName = "tariffCode";
            this.tariffCodeDataGridViewTextBoxColumn.HeaderText = "tariffCode";
            this.tariffCodeDataGridViewTextBoxColumn.Name = "tariffCodeDataGridViewTextBoxColumn";
            // 
            // preparationTimeDataGridViewTextBoxColumn
            // 
            this.preparationTimeDataGridViewTextBoxColumn.DataPropertyName = "preparationTime";
            this.preparationTimeDataGridViewTextBoxColumn.HeaderText = "preparationTime";
            this.preparationTimeDataGridViewTextBoxColumn.Name = "preparationTimeDataGridViewTextBoxColumn";
            // 
            // partCreatingTimeDataGridViewTextBoxColumn
            // 
            this.partCreatingTimeDataGridViewTextBoxColumn.DataPropertyName = "partCreatingTime";
            this.partCreatingTimeDataGridViewTextBoxColumn.HeaderText = "partCreatingTime";
            this.partCreatingTimeDataGridViewTextBoxColumn.Name = "partCreatingTimeDataGridViewTextBoxColumn";
            // 
            // allDataTableAdapter
            // 
            this.allDataTableAdapter.ClearBeforeFill = true;
            // 
            // allDataBindingSource1
            // 
            this.allDataBindingSource1.DataMember = "allData";
            this.allDataBindingSource1.DataSource = this.manufactureDataSet;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ManufactureDataSet manufactureDataSet;
        private System.Windows.Forms.BindingSource assemblyBindingSource;
        private ManufactureDataSetTableAdapters.AssemblyTableAdapter assemblyTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ManufactureDataSetTableAdapters.allDataTableAdapter allDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componenetCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCreatingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource allDataBindingSource1;
    }
}