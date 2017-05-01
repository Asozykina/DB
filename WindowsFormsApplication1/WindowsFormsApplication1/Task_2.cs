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
    public partial class Task_2 : Form
    {
        public Task_2()
        {
            InitializeComponent();
        }

        private void Task_2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.Details1". При необходимости она может быть перемещена или удалена.
            this.details1TableAdapter.Fill(this.manufactureDataSet.Details1);

        }
    }
}
