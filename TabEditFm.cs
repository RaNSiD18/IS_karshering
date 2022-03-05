using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_SERYAKOV
{
    public partial class TabEditFm : Form
    {
        public TabEditFm()
        {
            InitializeComponent();
        }

      
        private void bu_backFm_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainFm mainFm = new MainFm();
            mainFm.dataGridView1.DataSource = dataGridView1.DataSource;
            mainFm.Show();
        }
    }
}
