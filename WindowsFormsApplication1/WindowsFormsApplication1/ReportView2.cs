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
    public partial class ReportView2 : Form
    {
        public ReportView2()
        {
            InitializeComponent();
        }

        private void ReportView2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ManufactureDataSet.Zadacha1". При необходимости она может быть перемещена или удалена.
            this.details2TableAdapter1.Fill(this.ManufactureDataSet.Details2);
            this.reportViewer1.RefreshReport();
        }
    }
}
