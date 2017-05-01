namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detailCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparaionTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partCreatingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labourInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufactureDataSet = new WindowsFormsApplication1.ManufactureDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTableName = new System.Windows.Forms.ToolStripLabel();
            this.labourInput = new System.Windows.Forms.Button();
            this.assemblyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assemblyTableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.AssemblyTableAdapter();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsTableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.DetailsTableAdapter();
            this.labourInputTableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.labourInputTableAdapter();
            this.details = new System.Windows.Forms.Button();
            this.assembly = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.TableAdapterManager();
            this.procedure = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labourInputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.labourInputBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 222);
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
            // labourInputBindingSource
            // 
            this.labourInputBindingSource.DataMember = "labourInput";
            this.labourInputBindingSource.DataSource = this.manufactureDataSet;
            // 
            // manufactureDataSet
            // 
            this.manufactureDataSet.DataSetName = "ManufactureDataSet";
            this.manufactureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.lblTableName});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(681, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblTableName
            // 
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(69, 22);
            this.lblTableName.Text = "labourInput";
            this.lblTableName.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // labourInput
            // 
            this.labourInput.Location = new System.Drawing.Point(12, 256);
            this.labourInput.Name = "labourInput";
            this.labourInput.Size = new System.Drawing.Size(75, 23);
            this.labourInput.TabIndex = 2;
            this.labourInput.Text = "labourInput";
            this.labourInput.UseVisualStyleBackColor = true;
            this.labourInput.Click += new System.EventHandler(this.labourInput_Click);
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
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "Details";
            this.detailsBindingSource.DataSource = this.manufactureDataSet;
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
            // 
            // labourInputTableAdapter
            // 
            this.labourInputTableAdapter.ClearBeforeFill = true;
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(94, 256);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(75, 23);
            this.details.TabIndex = 3;
            this.details.Text = "details";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // assembly
            // 
            this.assembly.Location = new System.Drawing.Point(176, 256);
            this.assembly.Name = "assembly";
            this.assembly.Size = new System.Drawing.Size(75, 23);
            this.assembly.TabIndex = 4;
            this.assembly.Text = "assembly";
            this.assembly.UseVisualStyleBackColor = true;
            this.assembly.Click += new System.EventHandler(this.assembly_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "sent";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(340, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "close";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AssemblyTableAdapter = this.assemblyTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DetailsTableAdapter = this.detailsTableAdapter;
            this.tableAdapterManager1.labourInputTableAdapter = this.labourInputTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplication1.ManufactureDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // procedure
            // 
            this.procedure.Location = new System.Drawing.Point(421, 256);
            this.procedure.Name = "procedure";
            this.procedure.Size = new System.Drawing.Size(75, 23);
            this.procedure.TabIndex = 7;
            this.procedure.Text = "procedure";
            this.procedure.UseVisualStyleBackColor = true;
            this.procedure.Click += new System.EventHandler(this.procedure_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(564, 261);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(67, 13);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Потрачено: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 291);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.procedure);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.assembly);
            this.Controls.Add(this.details);
            this.Controls.Add(this.labourInput);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labourInputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button labourInput;
        private ManufactureDataSet manufactureDataSet;
        private System.Windows.Forms.BindingSource assemblyBindingSource;
        private ManufactureDataSetTableAdapters.AssemblyTableAdapter assemblyTableAdapter;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private ManufactureDataSetTableAdapters.DetailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.BindingSource labourInputBindingSource;
        private ManufactureDataSetTableAdapters.labourInputTableAdapter labourInputTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparaionTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCreatingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel lblTableName;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Button assembly;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private ManufactureDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button procedure;
        private System.Windows.Forms.Label costLabel;
    }
}