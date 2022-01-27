using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionLibrary;
using MySql.Data.MySqlClient;

namespace percentCalc
{
    public partial class Form1 : Form
    {
        MySqlDataAdapter MySQLData = new MySqlDataAdapter();
        BindingSource SourceBind = new BindingSource();
        DataTable datatable = new DataTable();
        ConnDB conndb = new ConnDB();
        public delegate void AddDelegate(double startcount, double rate, int years);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDelegate Del = new AddDelegate(Funct);
            Del.Invoke(Convert.ToDouble(numstartcount.Value), Convert.ToDouble(numpercent.Value), Convert.ToInt32(numyears.Value));
        }
        private void Funct(double startcount, double rate, int years)
        {
            int periods = 0;
            rate = rate / 100;
            string select = comboprocess.Text;
            switch (select)
            {
                case "Ежедневно":
                    double dayRate = rate / 365;
                    periods = years * 365;
                    startcount = startcount * Math.Pow((1 + dayRate), periods);
                    total.Text = Convert.ToString(Math.Ceiling(startcount));
                    break;
                case "Ежемесячно":
                    double monthRate = rate / 12;
                    periods = years * 12;
                    startcount = startcount * Math.Pow((1 + monthRate), periods);
                    total.Text = Convert.ToString(Math.Ceiling(startcount));
                    break;
                case "Ежеквартально":
                    double quarterRate = rate / 4;
                    periods = years * 4;
                    startcount = startcount * Math.Pow((1 + quarterRate), periods);
                    total.Text = Convert.ToString(Math.Ceiling(startcount));
                    break;
                case "По полугодиям":
                    double halfyearRate = rate / 2;
                    periods = years * 2;
                    startcount = startcount * Math.Pow((1 + halfyearRate), periods);
                    total.Text = Convert.ToString(Math.Ceiling(startcount));
                    break;
                case "Ежегодно":
                    double yearRate = rate;
                    periods = years;
                    startcount = startcount * Math.Pow((1 + yearRate), periods);
                    total.Text = Convert.ToString(Math.Ceiling(startcount));
                    break;
                default:
                    comboprocess.Text = "Процент не выбран";
                    break;
            }
        }

        private void button2_click(object sender, EventArgs e)
        {
            try
            {
                conndb.ConnMysqlClient().Open();
                string ConnSTR = "SELECT ID AS 'ID', startcount AS 'Изначальная сумма', rate AS 'Процентная ставка (%)', years AS 'Количество лет', periods AS 'Период начисления', total AS 'Итоговая сумма' FROM ndfl_bd";
                MySQLData.SelectCommand = new MySqlCommand(ConnSTR, conndb.ConnMysqlClient());
                MySQLData.Fill(datatable);
                SourceBind.DataSource = datatable;
                dataGridView1.DataSource = SourceBind;
            }
            catch (Exception oshibka)
            {
                MessageBox.Show($"{oshibka}");
            }
            finally
            {
                conndb.ConnMysqlClient().Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (total.TextLength != 0)
            {
                try
                {
                    double _startcount = Convert.ToDouble(numstartcount.Value);
                    double _rate = Convert.ToDouble(numpercent.Value);
                    int _years = Convert.ToInt32(numyears.Value);
                    string _select = comboprocess.Text;
                    int _sum = Convert.ToInt32 (total.Text);
                    conndb.ConnMysqlClient().Open();
                    string commandStr = $"INSERT INTO ndfl_bd (startcount, rate, years, periods, total) VALUES ('{_startcount}', '{_rate}', '{_years}', '{_select}', '{_sum}')";
                    using (MySqlCommand cmnd = new MySqlCommand(commandStr, conndb.ConnMysqlClient()))
                    {
                        cmnd.Parameters.Add(Convert.ToString(_startcount), MySqlDbType.VarChar).Value = numstartcount.Text;
                        cmnd.Parameters.Add(Convert.ToString(_rate), MySqlDbType.VarChar).Value = numpercent.Text;
                        cmnd.Parameters.Add(Convert.ToString(_years), MySqlDbType.VarChar).Value = numyears.Text;
                        cmnd.Parameters.Add(Convert.ToString(_select), MySqlDbType.VarChar).Value = comboprocess.Text;
                        cmnd.Parameters.Add(Convert.ToString(_sum), MySqlDbType.VarChar).Value = total.Text;
                        cmnd.Connection.Open();
                        cmnd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
                finally
                {
                    conndb.ConnMysqlClient().Close();
                }
            }
            else
            {
                MessageBox.Show("Нет результата");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
                int delet = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(delet);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);
        }
    } 
}
