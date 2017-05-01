using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.Assembly". При необходимости она может быть перемещена или удалена.
            this.assemblyTableAdapter.Fill(this.manufactureDataSet.Assembly);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.labourInput". При необходимости она может быть перемещена или удалена.
            this.labourInputTableAdapter.Fill(this.manufactureDataSet.labourInput);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.Details". При необходимости она может быть перемещена или удалена.
            this.detailsTableAdapter.Fill(this.manufactureDataSet.Details);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            int nRow = detailsDataGridView.CurrentCell.RowIndex;
            int nCol = detailsDataGridView.CurrentCell.ColumnIndex;
            // Если строка – не последняя, увеличиваем номер строки на 1,
            // в противном случае соответству
            if (nRow < detailsDataGridView.RowCount - 1)
                detailsDataGridView.CurrentCell = detailsDataGridView[nCol, ++nRow];
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void detailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.labourInputDataGridView.DataSource = labourInputBindingSource;
            bindingNavigator1.BindingSource = detailsBindingSource;
            toolStripLabel1.Text = "Детали";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.assemblyDataGridView.DataSource = 0;
            bindingNavigator1.BindingSource = labourInputBindingSource;
            toolStripLabel1.Text = "Трудозатраты";

        }

        private void assemblyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.detailsDataGridView.DataSource = assemblyDetailsBindingSource;
            this.labourInputDataGridView.DataSource = assemblylabourInputBindingSource;
            bindingNavigator1.BindingSource = assemblyBindingSource;
            toolStripLabel1.Text = "Деталезатраты";
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void альтернативнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void задача1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha_1 z2 = new Zadacha_1();
            z2.Show();
        }

        private void задача3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha_3 z3 = new Zadacha_3();
            z3.Show();
        }

        private void задача4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha_4 z4 = new Zadacha_4();
            z4.Show();
        }

        private void задача5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha_5 z5 = new Zadacha_5();
            z5.Show();
        }

        private void задача2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha_2 z2 = new Zadacha_2();
            z2.Show();
        }

        private void представлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.Show();
        }

        private void задача2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Task_2 t2 = new Task_2();
            t2.Show();
        }

        private void задача3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Task_2_SQL t2sql = new Task_2_SQL();
            t2sql.Show();
        }

        private void отчет2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportView2 rp2 = new ReportView2();
            rp2.Show();
        }

        private void задача3CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task_2_Sharp t2sharp = new Task_2_Sharp();
            t2sharp.Show();
        }

        private void отчет3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportView1 rp1 = new ReportView1();
            rp1.Show();
        }

        private void отчетПоПредставлениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDataReportView allDataReportView = new AllDataReportView();
            allDataReportView.Show();
        }
    }
}
