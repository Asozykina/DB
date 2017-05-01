namespace WindowsFormsApplication1
{
    partial class Task_2
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
            this.manufactureDataSet = new WindowsFormsApplication1.ManufactureDataSet();
            this.details1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.details1TableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.Details1TableAdapter();
            this.nameDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfComponentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDetailDataGridViewTextBoxColumn,
            this.countOfComponentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.details1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // manufactureDataSet
            // 
            this.manufactureDataSet.DataSetName = "ManufactureDataSet";
            this.manufactureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // details1BindingSource
            // 
            this.details1BindingSource.DataMember = "Details1";
            this.details1BindingSource.DataSource = this.manufactureDataSet;
            // 
            // details1TableAdapter
            // 
            this.details1TableAdapter.ClearBeforeFill = true;
            // 
            // nameDetailDataGridViewTextBoxColumn
            // 
            this.nameDetailDataGridViewTextBoxColumn.DataPropertyName = "nameDetail";
            this.nameDetailDataGridViewTextBoxColumn.HeaderText = "nameDetail";
            this.nameDetailDataGridViewTextBoxColumn.Name = "nameDetailDataGridViewTextBoxColumn";
            // 
            // countOfComponentDataGridViewTextBoxColumn
            // 
            this.countOfComponentDataGridViewTextBoxColumn.DataPropertyName = "countOfComponent";
            this.countOfComponentDataGridViewTextBoxColumn.HeaderText = "countOfComponent";
            this.countOfComponentDataGridViewTextBoxColumn.Name = "countOfComponentDataGridViewTextBoxColumn";
            this.countOfComponentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Task_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Task_2";
            this.Text = "Task_2";
            this.Load += new System.EventHandler(this.Task_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ManufactureDataSet manufactureDataSet;
        private System.Windows.Forms.BindingSource details1BindingSource;
        private ManufactureDataSetTableAdapters.Details1TableAdapter details1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countOfComponentDataGridViewTextBoxColumn;
    }
}