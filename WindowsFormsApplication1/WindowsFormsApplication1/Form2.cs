using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.labourInput". При необходимости она может быть перемещена или удалена.
            this.labourInputTableAdapter.Fill(this.manufactureDataSet.labourInput);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.Details". При необходимости она может быть перемещена или удалена.
            this.detailsTableAdapter.Fill(this.manufactureDataSet.Details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.Assembly". При необходимости она может быть перемещена или удалена.
            this.assemblyTableAdapter.Fill(this.manufactureDataSet.Assembly);

            dataGridView1.AutoGenerateColumns = true;

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void labourInput_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "labourInput")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = labourInputBindingSource;
                bindingNavigator1.BindingSource = labourInputBindingSource;
                lblTableName.Text = "labourInput";
            }
        }

        private void details_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "details")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = detailsBindingSource;
                bindingNavigator1.BindingSource = detailsBindingSource;
                lblTableName.Text = "details";
            }
        }

        private void assembly_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "assembly")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = assemblyBindingSource;
                bindingNavigator1.BindingSource = assemblyBindingSource;
                lblTableName.Text = "assembly";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void procedure_Click(object sender, EventArgs e)
        {
            try {
                String component = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                String operation = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.ManufactureConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "costDetails";
                SqlParameter param = new SqlParameter("@cost", SqlDbType.Decimal);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.Parameters.Add(new SqlParameter("@componentCode", int.Parse(component)));
                cmd.Parameters.Add(new SqlParameter("@operaionCode", int.Parse(operation)));
                con.Open();
                cmd.ExecuteNonQuery();
                string cost = cmd.Parameters["@cost"].Value.ToString();
                MessageBox.Show(cost);
                con.Close();
                costLabel.Text = "Потрачено: " + cost;
            }
                
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            tableAdapterManager1.UpdateAll(manufactureDataSet);
            MessageBox.Show("Изменения сохранены");
        }


    }
}
