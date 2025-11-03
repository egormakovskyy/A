//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQLApp
{
    public partial class Welcome_menu : Form
    {
        public Welcome_menu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PassField.Text))
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (int.TryParse(PassField.Text, out int pass))
            {
                if (pass == Data.pass)
                {
                    this.Hide();
                    Start_menu Start_menuForm = new Start_menu();
                    Start_menuForm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введите число");
                return;
            }


            //DB db = new DB();

            //DataTable table = new DataTable();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());

            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            //command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            //if (table.Rows.Count > 0)
            //{
            //this.Hide();
            //Start_menu mainForm = new Start_menu();
            //mainForm.Show();
            //}

            //else
            //    MessageBox.Show("No");
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Green;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //private void RegisterLabel_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    RegisterForm registerForm = new RegisterForm();
        //    registerForm.Show();
        //}
    }
}
