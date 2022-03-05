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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bu_login_Click(object sender, EventArgs e)
        {
            String logUser = tb_login.Text; 
            String passUser = tb_pass.Text;

            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainFm mainFm = new MainFm();
                mainFm.Show();
            }
            else MessageBox.Show("Введите логин и пароль");
        }

        private void bt_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegFm regFm = new RegFm();
            regFm.Show();
        }
    }
}
