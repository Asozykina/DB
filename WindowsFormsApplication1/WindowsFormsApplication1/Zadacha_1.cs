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
    public partial class Zadacha_1 : Form
    {
        public Zadacha_1()
        {
            InitializeComponent();
        }

        private void Zadacha_1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
             dataGridView1.AutoGenerateColumns = true;
            //this.zadacha1TableAdapter.Fill(manufactureDataSet.Zadacha1, 0);
            this.Text = "Запрос на основании объекта TableAdapter";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            int finishedCode = Convert.ToInt32(textTime.Text);
            this.zadacha1TableAdapter.Fill(manufactureDataSet.Zadacha1, finishedCode);
       }
    }
}
