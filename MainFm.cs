using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace IS_SERYAKOV
{
    public partial class MainFm : Form
    {
        private string fileName = string.Empty;

        private DataTableCollection tableCollection = null;

        public MainFm()
        {
            InitializeComponent();
        }

        public MySqlConnection mycon;
        public MySqlCommand mycom;
        public string connect = "server=localhost;port=3306;username=root;password=root;database=is_seryakov";
        public DataSet ds;

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();

                if (res == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;

                    Text = fileName;
                    OpenExcelFile(fileName); 
                }
                else
                {
                    throw new Exception("Файл не выбран!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenExcelFile (String path)
        {
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

            DataSet db = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (x) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            tableCollection = db.Tables;

            toolStripComboBox1.Items.Clear();

            foreach (DataTable tabe in tableCollection)
            {
                toolStripComboBox1.Items.Add(tabe.TableName);
            }

            toolStripComboBox1.SelectedIndex = 0;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = tableCollection[Convert.ToString(toolStripComboBox1.SelectedItem)];
            dataGridView1.DataSource = table;
        }

        private void загрузитьТаблицуКлиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "SELECT * FROM clients";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MessageBox.Show("Подключение к БД прошло успешно");

                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dataGridView1.DataSource = table;
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("Ошбика подключения");
            }
        }

        private void загрузитьТаблицуАвтомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "SELECT * FROM cars";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MessageBox.Show("Подключение к БД прошло успешно");

                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dataGridView1.DataSource = table;
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("Ошбика подключения");
            }
        }

        private void сохранитьТаблицуВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C";
            saveFileDialog1.Title = "Сохранить таблицу";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files (2007|*.xlsx|Excel Files (.CSV)|*.csv)";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Cursor.Current = Cursors.WaitCursor;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                excelApp.Columns.ColumnWidth = 28;
                for (int i = 1; i < dataGridView1.Columns.Count+1; i++)
                {
                    excelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                excelApp.ActiveWorkbook.Saved = true;
                excelApp.Quit();

                MessageBox.Show("Таблица сохранена");
            }
            Cursor.Current = Cursors.Default;
        }

        private void сформироватьСписокСвободныхМашинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "SELECT * FROM cars";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MessageBox.Show("Подключение к БД прошло успешно");

                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dataGridView1.DataSource = table;
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Статус LIKE '%{"Свободен"}%'";
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("Ошбика подключения");
            }
        }

        private void сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "SELECT * FROM cars";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MessageBox.Show("Подключение к БД прошло успешно");

                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dataGridView1.DataSource = table;
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Статус LIKE '%{"В ремонте"}%'";
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("Ошбика подключения");
            }
        }

        private void сформироватьСписокСвободныхАвтмообилейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "SELECT * FROM cars";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MessageBox.Show("Подключение к БД прошло успешно");

                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dataGridView1.DataSource = table;
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Статус LIKE '%{"Арендован"}%'";
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("Ошбика подключения");
            }
        }

        private void редактироватьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabEditFm tabEditFm = new TabEditFm();
            tabEditFm.dataGridView1.DataSource = dataGridView1.DataSource;
            tabEditFm.Show();
        }
    }
}
