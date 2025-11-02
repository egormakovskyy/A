using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQLApp
{
    public partial class Start_menu : Form
    {
        public Start_menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            // Устанавливаем placeholder текст
            FloorsField.Text = "Кол-во этажей";
            FloorsField.ForeColor = Color.Gray;
            PeopleField.Text = "Кол-во человек";
            PeopleField.ForeColor = Color.Gray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LaunchSystem_Click(object sender, EventArgs e)
        {
            // Парсим введенные значения
            if (!int.TryParse(FloorsField.Text, out int floors) || floors <= 0)
            {
                MessageBox.Show("Введите корректное количество этажей");
                return;
            }
            if (!int.TryParse(PeopleField.Text, out int humans) || humans < 0)
            {
                MessageBox.Show("Введите корректное количество человек");
                return;
            }
            Data.TotalFloors = floors;
            this.Hide();
            for (int i = 0; i < humans; i++)
            {
                CreateHumanForm humanForm = new CreateHumanForm(i+1);
                humanForm.ShowDialog();
            }

            // После заполнения данных всех людей можно запускать основную систему
            MessageBox.Show("Все данные заполнены! Запускаем систему...");
            
            SimulationForm simulationForm = new SimulationForm();
            simulationForm.ShowDialog();
            this.Close();
        }

        private void FloorsField_Enter(object sender, EventArgs e)
        {
            if (FloorsField.Text == "Кол-во этажей")
            {
                FloorsField.Text = "";
                FloorsField.ForeColor = Color.Black;
            }
        }

        private void FloorsField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FloorsField.Text))
            {
                FloorsField.Text = "Кол-во этажей";
                FloorsField.ForeColor = Color.Gray;
            }
        }

        private void PeopleField_Enter(object sender, EventArgs e)
        {
            if (PeopleField.Text == "Кол-во человек")
            {
                PeopleField.Text = "";
                PeopleField.ForeColor = Color.Black;
            }
        }

        private void PeopleField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PeopleField.Text))
            {
                PeopleField.Text = "Кол-во человек";
                PeopleField.ForeColor = Color.Gray;
            }
        }
    }
}