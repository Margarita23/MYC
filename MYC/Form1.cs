using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYC
{
    public partial class Form1 : Form
    {
        //Gender true - male, false - female
        private bool Gender = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int age = Convert.ToInt32(ageBox.Text);
                float weight = Convert.ToInt32(weightBox.Text);
                float height = Convert.ToInt32(heightBox.Text);
                double userStr = 0;

                switch (Gender)
                {
                    case true:
                        userStr = Math.Abs(88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age));
                        break; 
                    case false:
                        userStr = Math.Abs(447.593 + (9.247 * weight) + (3.098 * height) - (4.33 * age));
                        break;
                    default:
                        MessageBox.Show("Укажите ваш пол!", "Ошибка");
                        break;
                }
                MessageBox.Show(userStr.ToString(), "Результат");
            } catch (FormatException) {
                MessageBox.Show("Проверьте введенные данные!", "Ошибка");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void genderFemale_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Gender = false;
            }
        }

        private void genderMale_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Gender = true;
            }
        }
    }
}
