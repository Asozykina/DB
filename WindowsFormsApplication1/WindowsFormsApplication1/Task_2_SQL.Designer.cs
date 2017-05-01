namespace WindowsFormsApplication1
{
    partial class Task_2_SQL
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufactureDataSet = new WindowsFormsApplication1.ManufactureDataSet();
            this.details2TableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.Details2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDetailDataGridViewTextBoxColumn,
            this.nameDetailDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.details2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // details2BindingSource
            // 
            this.details2BindingSource.DataMember = "Details2";
            this.details2BindingSource.DataSource = this.manufactureDataSet;
            // 
            // manufactureDataSet
            // 
            this.manufactureDataSet.DataSetName = "ManufactureDataSet";
            this.manufactureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // details2TableAdapter
            // 
            this.details2TableAdapter.ClearBeforeFill = true;
            // 
            // Task_2_SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Task_2_SQL";
            this.Text = "Task_2_SQL";
            this.Load += new System.EventHandler(this.Task_2_SQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ManufactureDataSet manufactureDataSet;
        private System.Windows.Forms.BindingSource details2BindingSource;
        private ManufactureDataSetTableAdapters.Details2TableAdapter details2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    }
}