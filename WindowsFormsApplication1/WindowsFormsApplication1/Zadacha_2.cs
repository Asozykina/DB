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
    public partial class Zadacha_2 : Form
    {
        public Zadacha_2()
        {
            InitializeComponent();
        }

        private void Zadacha_2_Load(object sender, EventArgs e)
        {
            this.labourInputTableAdapter1.Fill(this.manufactureDataSet.labourInput);
            this.assemblyTableAdapter1.Fill(this.manufactureDataSet.Assembly);
            this.detailsTableAdapter1.Fill(this.manufactureDataSet.Details);
        }
        public void queryCost()
        {
            manufactureDataSet.Zadacha1.Clear();
            foreach (ManufactureDataSet.DetailsRow dRow in this.manufactureDataSet.Details.Rows)
            {
                foreach (ManufactureDataSet.AssemblyRow asRow in this.manufactureDataSet.Assembly.Rows)
                {
                    if (asRow.finishedCode == Convert.ToInt32(textDetail.Text) && asRow.componentCode == dRow.id)
                    {
                        ManufactureDataSet.Zadacha1Row zRow = this.manufactureDataSet.Zadacha1.NewZadacha1Row();
                        zRow.id = dRow.id;
                        zRow.typeDetail = dRow.typeDetail;
                        zRow.nameDetail = dRow.nameDetail;
                        zRow.unit = dRow.unit;
                        zRow.unitPrice = dRow.unitPrice;
                        manufactureDataSet.Zadacha1.AddZadacha1Row(zRow);
                    }
                }
            }
            dataGridView1.Refresh();
            this.Text = "Запрос через цикл";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            queryCost();
        }
    }
}
