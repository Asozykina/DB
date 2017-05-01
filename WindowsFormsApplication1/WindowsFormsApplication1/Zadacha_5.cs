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
    public partial class Zadacha_5 : Form
    {
        public Zadacha_5()
        {
            InitializeComponent();

        }

        private void Zadacha_5_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
        }

        public void FillGridByReader()
        {
            SqlConnection con = new SqlConnection( Properties.Settings.Default.ManufactureConnectionString);
            // создаем объект связь с бд, строку соединения берём из // свойств проекта, можно задать самим строкой
            con.Open();
            // подключаемся к бд
            String str = "SELECT id, typeDetail, nameDetail, unit, unitPrice FROM dbo.Details AS details JOIN dbo.Assembly AS assembly ON details.id=componentCode WHERE  assembly.finishedCode=" + textDetail.Text;
            // задаем текст запроса, добавляем текст из txtKolvo
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            // создали команду и выполнили метод ExecuteReader
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            // при помощи ридера заполнили таблицу и закрыли // соединение с бд
            BindingSource bs = new BindingSource();
            bs.DataSource = dt; 
            // программно создали объект BindingSource и связали // его с таблицей, далее грид и навигатор укажем на // него для связи с таблицей
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Refresh();
    }

        private void btnFill_Click(object sender, EventArgs e)
        {
            FillGridByReader();
        }
    }
}
