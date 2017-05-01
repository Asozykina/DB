namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDetailDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.labourInputDataGridView = new System.Windows.Forms.DataGridView();
            this.Detail = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.detailCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparaionTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partCreatingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labourInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assemblyDataGridView = new System.Windows.Forms.DataGridView();
            this.finishedCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assemblyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assemblyDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assemblylabourInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.формаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.представлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.задача3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача3CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsTableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.DetailsTableAdapter();
            this.labourInputTableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.labourInputTableAdapter();
            this.assemblyTableAdapter = new WindowsFormsApplication1.ManufactureDataSetTableAdapters.AssemblyTableAdapter();
            this.отчетПоПредставлениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labourInputDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labourInputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblylabourInputBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.AutoGenerateColumns = false;
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDetailDataGridViewCheckBoxColumn,
            this.nameDetailDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.detailsDataGridView.DataSource = this.detailsBindingSource;
            this.detailsDataGridView.Location = new System.Drawing.Point(12, 52);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.Size = new System.Drawing.Size(546, 119);
            this.detailsDataGridView.TabIndex = 0;
            this.detailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detailsDataGridView_CellContentClick);
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
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "Details";
            this.detailsBindingSource.DataSource = this.manufactureDataSet;
            // 
            // manufactureDataSet
            // 
            this.manufactureDataSet.DataSetName = "ManufactureDataSet";
            this.manufactureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.detailsBindingSource;
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
            this.toolStripLabel1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(755, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
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
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Таблицы";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // labourInputDataGridView
            // 
            this.labourInputDataGridView.AllowUserToOrderColumns = true;
            this.labourInputDataGridView.AutoGenerateColumns = false;
            this.labourInputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labourInputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail,
            this.detailCodeDataGridViewTextBoxColumn,
            this.operationCodeDataGridViewTextBoxColumn,
            this.jobCodeDataGridViewTextBoxColumn,
            this.tariffCodeDataGridViewTextBoxColumn,
            this.preparaionTimeDataGridViewTextBoxColumn,
            this.partCreatingTimeDataGridViewTextBoxColumn});
            this.labourInputDataGridView.DataSource = this.labourInputBindingSource;
            this.labourInputDataGridView.Location = new System.Drawing.Point(12, 177);
            this.labourInputDataGridView.Name = "labourInputDataGridView";
            this.labourInputDataGridView.Size = new System.Drawing.Size(701, 150);
            this.labourInputDataGridView.TabIndex = 2;
            this.labourInputDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "detailCode";
            this.Detail.DataSource = this.detailsBindingSource;
            this.Detail.DisplayMember = "nameDetail";
            this.Detail.HeaderText = "Деталь";
            this.Detail.Name = "Detail";
            this.Detail.ValueMember = "id";
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
            // assemblyDataGridView
            // 
            this.assemblyDataGridView.AllowUserToOrderColumns = true;
            this.assemblyDataGridView.AutoGenerateColumns = false;
            this.assemblyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assemblyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.finishedCodeDataGridViewTextBoxColumn,
            this.componentCodeDataGridViewTextBoxColumn,
            this.operationCodeDataGridViewTextBoxColumn1,
            this.componentCountDataGridViewTextBoxColumn});
            this.assemblyDataGridView.DataSource = this.assemblyBindingSource;
            this.assemblyDataGridView.Location = new System.Drawing.Point(12, 333);
            this.assemblyDataGridView.Name = "assemblyDataGridView";
            this.assemblyDataGridView.Size = new System.Drawing.Size(448, 150);
            this.assemblyDataGridView.TabIndex = 3;
            this.assemblyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assemblyDataGridView_CellContentClick);
            // 
            // finishedCodeDataGridViewTextBoxColumn
            // 
            this.finishedCodeDataGridViewTextBoxColumn.DataPropertyName = "finishedCode";
            this.finishedCodeDataGridViewTextBoxColumn.HeaderText = "finishedCode";
            this.finishedCodeDataGridViewTextBoxColumn.Name = "finishedCodeDataGridViewTextBoxColumn";
            // 
            // componentCodeDataGridViewTextBoxColumn
            // 
            this.componentCodeDataGridViewTextBoxColumn.DataPropertyName = "componentCode";
            this.componentCodeDataGridViewTextBoxColumn.HeaderText = "componentCode";
            this.componentCodeDataGridViewTextBoxColumn.Name = "componentCodeDataGridViewTextBoxColumn";
            // 
            // operationCodeDataGridViewTextBoxColumn1
            // 
            this.operationCodeDataGridViewTextBoxColumn1.DataPropertyName = "operationCode";
            this.operationCodeDataGridViewTextBoxColumn1.HeaderText = "operationCode";
            this.operationCodeDataGridViewTextBoxColumn1.Name = "operationCodeDataGridViewTextBoxColumn1";
            // 
            // componentCountDataGridViewTextBoxColumn
            // 
            this.componentCountDataGridViewTextBoxColumn.DataPropertyName = "componentCount";
            this.componentCountDataGridViewTextBoxColumn.HeaderText = "componentCount";
            this.componentCountDataGridViewTextBoxColumn.Name = "componentCountDataGridViewTextBoxColumn";
            // 
            // assemblyBindingSource
            // 
            this.assemblyBindingSource.DataMember = "Assembly";
            this.assemblyBindingSource.DataSource = this.manufactureDataSet;
            // 
            // assemblyDetailsBindingSource
            // 
            this.assemblyDetailsBindingSource.DataMember = "Assembly_Details";
            // 
            // assemblylabourInputBindingSource
            // 
            this.assemblylabourInputBindingSource.DataMember = "Assembly_labourInput";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формаToolStripMenuItem,
            this.задачиToolStripMenuItem,
            this.представлениеToolStripMenuItem,
            this.задача2ToolStripMenuItem1,
            this.задача3ToolStripMenuItem1,
            this.отчет2ToolStripMenuItem,
            this.задача3CToolStripMenuItem,
            this.отчет3ToolStripMenuItem,
            this.отчетПоПредставлениюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // формаToolStripMenuItem
            // 
            this.формаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основнаяToolStripMenuItem,
            this.альтернативнаяToolStripMenuItem});
            this.формаToolStripMenuItem.Name = "формаToolStripMenuItem";
            this.формаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.формаToolStripMenuItem.Text = "Форма";
            // 
            // основнаяToolStripMenuItem
            // 
            this.основнаяToolStripMenuItem.Name = "основнаяToolStripMenuItem";
            this.основнаяToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.основнаяToolStripMenuItem.Text = "Основная";
            // 
            // альтернативнаяToolStripMenuItem
            // 
            this.альтернативнаяToolStripMenuItem.Name = "альтернативнаяToolStripMenuItem";
            this.альтернативнаяToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.альтернативнаяToolStripMenuItem.Text = "Альтернативная";
            this.альтернативнаяToolStripMenuItem.Click += new System.EventHandler(this.альтернативнаяToolStripMenuItem_Click);
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задача1ToolStripMenuItem,
            this.задача2ToolStripMenuItem,
            this.задача3ToolStripMenuItem,
            this.задача4ToolStripMenuItem,
            this.задача5ToolStripMenuItem});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.задачиToolStripMenuItem.Text = "Задачи";
            // 
            // задача1ToolStripMenuItem
            // 
            this.задача1ToolStripMenuItem.Name = "задача1ToolStripMenuItem";
            this.задача1ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача1ToolStripMenuItem.Text = "Задача 1";
            this.задача1ToolStripMenuItem.Click += new System.EventHandler(this.задача1ToolStripMenuItem_Click);
            // 
            // задача2ToolStripMenuItem
            // 
            this.задача2ToolStripMenuItem.Name = "задача2ToolStripMenuItem";
            this.задача2ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача2ToolStripMenuItem.Text = "Задача 2";
            this.задача2ToolStripMenuItem.Click += new System.EventHandler(this.задача2ToolStripMenuItem_Click);
            // 
            // задача3ToolStripMenuItem
            // 
            this.задача3ToolStripMenuItem.Name = "задача3ToolStripMenuItem";
            this.задача3ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача3ToolStripMenuItem.Text = "Задача 3";
            this.задача3ToolStripMenuItem.Click += new System.EventHandler(this.задача3ToolStripMenuItem_Click);
            // 
            // задача4ToolStripMenuItem
            // 
            this.задача4ToolStripMenuItem.Name = "задача4ToolStripMenuItem";
            this.задача4ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача4ToolStripMenuItem.Text = "Задача 4";
            this.задача4ToolStripMenuItem.Click += new System.EventHandler(this.задача4ToolStripMenuItem_Click);
            // 
            // задача5ToolStripMenuItem
            // 
            this.задача5ToolStripMenuItem.Name = "задача5ToolStripMenuItem";
            this.задача5ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача5ToolStripMenuItem.Text = "Задача 5";
            this.задача5ToolStripMenuItem.Click += new System.EventHandler(this.задача5ToolStripMenuItem_Click);
            // 
            // представлениеToolStripMenuItem
            // 
            this.представлениеToolStripMenuItem.Name = "представлениеToolStripMenuItem";
            this.представлениеToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.представлениеToolStripMenuItem.Text = "Представление";
            this.представлениеToolStripMenuItem.Click += new System.EventHandler(this.представлениеToolStripMenuItem_Click);
            // 
            // задача2ToolStripMenuItem1
            // 
            this.задача2ToolStripMenuItem1.Name = "задача2ToolStripMenuItem1";
            this.задача2ToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.задача2ToolStripMenuItem1.Text = "Задача 2";
            this.задача2ToolStripMenuItem1.Click += new System.EventHandler(this.задача2ToolStripMenuItem1_Click);
            // 
            // задача3ToolStripMenuItem1
            // 
            this.задача3ToolStripMenuItem1.Name = "задача3ToolStripMenuItem1";
            this.задача3ToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.задача3ToolStripMenuItem1.Text = "Задача 3";
            this.задача3ToolStripMenuItem1.Click += new System.EventHandler(this.задача3ToolStripMenuItem1_Click);
            // 
            // отчет2ToolStripMenuItem
            // 
            this.отчет2ToolStripMenuItem.Name = "отчет2ToolStripMenuItem";
            this.отчет2ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчет2ToolStripMenuItem.Text = "Отчет 2";
            this.отчет2ToolStripMenuItem.Click += new System.EventHandler(this.отчет2ToolStripMenuItem_Click);
            // 
            // задача3CToolStripMenuItem
            // 
            this.задача3CToolStripMenuItem.Name = "задача3CToolStripMenuItem";
            this.задача3CToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.задача3CToolStripMenuItem.Text = "Задача 3 C#";
            this.задача3CToolStripMenuItem.Click += new System.EventHandler(this.задача3CToolStripMenuItem_Click);
            // 
            // отчет3ToolStripMenuItem
            // 
            this.отчет3ToolStripMenuItem.Name = "отчет3ToolStripMenuItem";
            this.отчет3ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчет3ToolStripMenuItem.Text = "Отчет 3";
            this.отчет3ToolStripMenuItem.Click += new System.EventHandler(this.отчет3ToolStripMenuItem_Click);
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
            // 
            // labourInputTableAdapter
            // 
            this.labourInputTableAdapter.ClearBeforeFill = true;
            // 
            // assemblyTableAdapter
            // 
            this.assemblyTableAdapter.ClearBeforeFill = true;
            // 
            // отчетПоПредставлениюToolStripMenuItem
            // 
            this.отчетПоПредставлениюToolStripMenuItem.Name = "отчетПоПредставлениюToolStripMenuItem";
            this.отчетПоПредставлениюToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.отчетПоПредставлениюToolStripMenuItem.Text = "Отчет по представлению";
            this.отчетПоПредставлениюToolStripMenuItem.Click += new System.EventHandler(this.отчетПоПредставлениюToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 491);
            this.Controls.Add(this.assemblyDataGridView);
            this.Controls.Add(this.labourInputDataGridView);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.detailsDataGridView);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labourInputDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labourInputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblylabourInputBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView detailsDataGridView;
        private ManufactureDataSet manufactureDataSet;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private ManufactureDataSetTableAdapters.DetailsTableAdapter detailsTableAdapter;
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
        private System.Windows.Forms.DataGridView labourInputDataGridView;
        private System.Windows.Forms.BindingSource labourInputBindingSource;
        private ManufactureDataSetTableAdapters.labourInputTableAdapter labourInputTableAdapter;
        private System.Windows.Forms.DataGridView assemblyDataGridView;
        private ManufactureDataSetTableAdapters.AssemblyTableAdapter assemblyTableAdapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.BindingSource assemblyDetailsBindingSource;
        private System.Windows.Forms.BindingSource assemblylabourInputBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn Detail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem формаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача1ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDetailDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparaionTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCreatingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource assemblyBindingSource;
        private System.Windows.Forms.ToolStripMenuItem задача2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem представлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem задача3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отчет2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача3CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоПредставлениюToolStripMenuItem;
    }
}

