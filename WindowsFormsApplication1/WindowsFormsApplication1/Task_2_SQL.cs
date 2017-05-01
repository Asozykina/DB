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
    public partial class Task_2_SQL : Form
    {
        public Task_2_SQL()
        {
            InitializeComponent();
        }

        private void Task_2_SQL_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.Details2". При необходимости она может быть перемещена или удалена.
            this.details2TableAdapter.Fill(this.manufactureDataSet.Details2);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
