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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.allData". При необходимости она может быть перемещена или удалена.
            this.allDataTableAdapter.Fill(this.manufactureDataSet.allData);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.Assembly". При необходимости она может быть перемещена или удалена.
            this.assemblyTableAdapter.Fill(this.manufactureDataSet.Assembly);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
