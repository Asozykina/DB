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
    public partial class Task_2_Sharp : Form
    {
        public Task_2_Sharp()
        {
            InitializeComponent();
        }

        private void Task_2_Sharp_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("SHOW");
            this.labourInputTableAdapter1.Fill(this.manufactureDataSet.labourInput);
            this.assemblyTableAdapter1.Fill(this.manufactureDataSet.Assembly);
            this.detailsTableAdapter1.Fill(this.manufactureDataSet.Details);
            this.details2TableAdapter1.Fill(this.manufactureDataSet.Details2);
            SharpQuery();
        }
        private void SharpQuery()
        {
            //MessageBox.Show("SHOW2");
            manufactureDataSet.Details2.Clear();
            foreach (ManufactureDataSet.DetailsRow dRow in this.manufactureDataSet.Details.Rows)
            {
                bool countFlag = false;

                foreach (ManufactureDataSet.labourInputRow labRow in this.manufactureDataSet.labourInput.Rows)
                {

                    if (dRow.id == labRow.detailCode)
                    {
                        if (labRow.jobCode > 3)
                        {
                            countFlag = true;
                        }
                        else
                        {
                            foreach (ManufactureDataSet.AssemblyRow asRow in this.manufactureDataSet.Assembly.Rows)
                            {
                                if (labRow.detailCode == asRow.finishedCode)
                                {
                                    if (asRow.componentCount > 5)
                                    {
                                        countFlag = true;
                                    }
                                }
                            }
                        } 
                    }
                }
                if (countFlag)
                {
                    ManufactureDataSet.Details2Row zRow = this.manufactureDataSet.Details2.NewDetails2Row();
                    zRow.id = dRow.id;
                    //zRow.typeDetail = dRow.typeDetail;
                    zRow.nameDetail = dRow.nameDetail;
                    zRow.unit = dRow.unit;
                    zRow.unitPrice = dRow.unitPrice;
                    manufactureDataSet.Details2.AddDetails2Row(zRow);
                    //MessageBox.Show(dRow.nameDetail);
                }
            }
            dataGridView1.Refresh();
            this.Text = "Запрос через цикл";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
