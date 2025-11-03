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
    public partial class CreateHumanForm : Form
    {
        int humanNumber;

        public CreateHumanForm(int humanNumber)
        {
            InitializeComponent();
            this.humanNumber = humanNumber;

            // Устанавливаем заголовок с номером человека
            this.Text = $"Человек {humanNumber}";

            // Placeholder текст
            TargetField.Text = "Целевой этаж";
            TargetField.ForeColor = Color.Gray;
            WeightField.Text = "Вес человека";
            WeightField.ForeColor = Color.Gray;
        }

        private void CreateHuman_Click(object sender, EventArgs e)
        {
            // Проверяем целевой этаж
            if (!int.TryParse(TargetField.Text, out int targetFloor) || targetFloor <= 0)
            {
                MessageBox.Show("Введите корректный целевой этаж");
                return;
            }

            // Проверяем, что целевой этаж не превышает общее количество этажей
            if (targetFloor > Data.TotalFloors)
            {
                MessageBox.Show($"Целевой этаж не может превышать {Data.TotalFloors}");
                return;
            }

            // Проверяем вес
            if (!int.TryParse(WeightField.Text, out int weight) || weight <= 0)
            {
                MessageBox.Show("Введите корректный вес");
                return;
            }

            // Сохраняем данные человека
            Data.Humans.Add(new HumanData
            {
                TargetFloor = targetFloor,
                Weight = weight
            });

            Data.people_created++;

            //DB db = new DB();

            //DataTable table = new DataTable();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());

            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Data.people_created;

            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            MessageBox.Show($"Данные человека {humanNumber} сохранены!\nЭтаж: {targetFloor}, Вес: {weight}");

            // Закрываем форму
            this.Close();
        }

        // Обработчики для placeholder текста
        private void TargetField_Enter(object sender, EventArgs e)
        {
            if (TargetField.Text == "Целевой этаж")
            {
                TargetField.Text = "";
                TargetField.ForeColor = Color.Black;
            }
        }

        private void TargetField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TargetField.Text))
            {
                TargetField.Text = "Целевой этаж";
                TargetField.ForeColor = Color.Gray;
            }
        }

        private void WeightField_Enter(object sender, EventArgs e)
        {
            if (WeightField.Text == "Вес человека")
            {
                WeightField.Text = "";
                WeightField.ForeColor = Color.Black;
            }
        }

        private void WeightField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(WeightField.Text))
            {
                WeightField.Text = "Вес человека";
                WeightField.ForeColor = Color.Gray;
            }
        }

        private void TargetField_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeightField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}