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
    public partial class RegFm : Form
    {
        public RegFm()
        {
            InitializeComponent();
            tb_regLogin.Text = "Введите логин";
            tb_regLogin.ForeColor = Color.Gray;

            tb_regPass.Text = "Введите пароль";
            tb_regPass.ForeColor = Color.Gray;

            tb_regLogDouble.Text = "Введите имя";
            tb_regLogDouble.ForeColor = Color.Gray;

            tb_regPassDouble.Text = "Введите фамилию";
            tb_regPassDouble.ForeColor = Color.Gray;
        }

        private void tb_regLogin_Enter(object sender, EventArgs e)
        {
            if(tb_regLogin.Text == "Введите логин")
            {
                tb_regLogin.Text = "";
                tb_regLogin.ForeColor = Color.Black;
            }
        }

        private void tb_regLogin_Leave(object sender, EventArgs e)
        {
            if (tb_regLogin.Text == "")
            {
                tb_regLogin.Text = "Введите логин";
                tb_regLogin.ForeColor = Color.Gray;
            }
               
        }

        private void tb_regPass_Enter(object sender, EventArgs e)
        {
            if (tb_regPass.Text == "Введите пароль")
            {
                tb_regPass.Text = "";
                tb_regPass.ForeColor = Color.Black;
            }
        }

        private void tb_regPass_Leave(object sender, EventArgs e)
        {
            if (tb_regLogin.Text == "")
            {
                tb_regPass.Text = "Введите пароль";
                tb_regPass.ForeColor = Color.Gray;
            }
        }

        private void bu_Reg_Click(object sender, EventArgs e)
        {
            if (tb_regLogin.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (tb_regPass.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (tb_regLogDouble.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (tb_regPassDouble.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (isUserExists() == true)
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = tb_regLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tb_regPass.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = tb_regLogDouble.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = tb_regPassDouble.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }

        private void tb_regLogDouble_Enter(object sender, EventArgs e)
        {
            if (tb_regLogDouble.Text == "Введите имя")
            {
                tb_regLogDouble.Text = "";
                tb_regLogDouble.ForeColor = Color.Black;
            }
        }

        private void tb_regLogDouble_Leave(object sender, EventArgs e)
        {
            if (tb_regLogDouble.Text == "")
            {
                tb_regLogDouble.Text = "Введите имя";
                tb_regLogDouble.ForeColor = Color.Gray;
            }
        }

        private void tb_regPassDouble_Enter(object sender, EventArgs e)
        {
            if (tb_regPassDouble.Text == "Введите фамилию")
            {
                tb_regPassDouble.Text = "";
                tb_regPassDouble.ForeColor = Color.Black;
            }
        }

        private void tb_regPassDouble_Leave(object sender, EventArgs e)
        {
            if (tb_regPassDouble.Text == "")
            {
                tb_regPassDouble.Text = "Введите фамилию";
                tb_regPassDouble.ForeColor = Color.Gray;
            }
        }

        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = tb_regLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой логин");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void bt_backLoginFm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logFm = new LoginForm();
            logFm.Show();
        }
    }
}
