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
    public partial class Zadacha_3 : Form
    {
        public Zadacha_3()
        {
            InitializeComponent();
        }

        private void Zadacha_3_Load(object sender, EventArgs e)
        {
            this.assemblyTableAdapter1.Fill(this.manufactureDataSet.Assembly);
            this.detailsTableAdapter1.Fill(this.manufactureDataSet.Details);
            this.labourInputTableAdapter1.Fill(this.manufactureDataSet.labourInput);
        }

        private void queryQuery()
        {
            manufactureDataSet.Zadacha1.Clear();
            foreach (ManufactureDataSet.AssemblyRow asRow in manufactureDataSet.Assembly.Rows)
            {
                if (asRow.finishedCode == Convert.ToInt32(textDetail.Text))
                {
                    ManufactureDataSet.DetailsRow findedRow = manufactureDataSet.Details.Rows.Find(asRow.componentCode) as ManufactureDataSet.DetailsRow;

                    ManufactureDataSet.Zadacha1Row zRow = manufactureDataSet.Zadacha1.NewZadacha1Row();

                    zRow.id = findedRow.id;
                    zRow.typeDetail = findedRow.typeDetail;
                    zRow.nameDetail = findedRow.nameDetail;
                    zRow.unit = findedRow.unit;
                    zRow.unitPrice = findedRow.unitPrice;
                    manufactureDataSet.Zadacha1.AddZadacha1Row(zRow);

                }
            }
            dataGridView1.Refresh();
            this.Text = "Запрос через поиск по ключу";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            queryQuery();
        }
    }
}
