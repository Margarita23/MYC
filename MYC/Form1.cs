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
        
        public Form1()
        {
            InitializeComponent();
            ageBox.Validating += ageBox_Validating;
            weightBox.Validating += weightBox_Validating;
            heightBox.Validating += heightBox_Validating;
            
        }
        
        //Gender true - male, false - female
        private bool Gender = true;

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

        private void ageBox_Validating(object sender,
                 System.ComponentModel.CancelEventArgs e)
        { 
            string errorMsg;
            int age = 0;
            try {
                age = Int32.Parse(ageBox.Text);
                if (!ValidAge(age, out errorMsg))
                {
                    // Cancel the event and select the text to be corrected by the user.
                    e.Cancel = true;
                    ageBox.Select(0, ageBox.Text.Length);

                    // Set the ErrorProvider error with the text to display. 
                    this.errorProvider1.SetError(ageBox, errorMsg);
                }
            } catch (FormatException) {
                MessageBox.Show("Проверьте введенные данные!", "Ошибка");
            }
}

        private void weightBox_Validating(object sender,
                 System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            int weight = 0;
            try { 
                weight = Int32.Parse(weightBox.Text);
                if (!ValidWeight(weight, out errorMsg))
                {
                    // Cancel the event and select the text to be corrected by the user.
                    e.Cancel = true;
                    weightBox.Select(0, weightBox.Text.Length);

                    // Set the ErrorProvider error with the text to display. 
                    this.errorProvider1.SetError(weightBox, errorMsg);
                }
            } catch (FormatException) {
                MessageBox.Show("Проверьте введенные данные!", "Ошибка");
            }
}

        private void heightBox_Validating(object sender,
                 System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            int height = 0;
            try
            {
                height = Int32.Parse(heightBox.Text);

                if (!ValidHeight(height, out errorMsg))
                {
                    // Cancel the event and select the text to be corrected by the user.
                    e.Cancel = true;
                    heightBox.Select(0, heightBox.Text.Length);

                    // Set the ErrorProvider error with the text to display. 
                    this.errorProvider1.SetError(heightBox, errorMsg);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте введенные данные!", "Ошибка");
            }
        }

        public bool ValidAge(int age, out string errorMessage)
        {
            if (age <= 0 || age > 150)
            {
                errorMessage = "Возраст некорректный";
                return false;
            }
            else {
                errorMessage = "";
                return true;
            }
        }

        public bool ValidHeight(int height, out string errorMessage)
        {
            if (height <= 30 || height > 400)
            {
                errorMessage = "Рост некорректный";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        public bool ValidWeight(int weight, out string errorMessage)
        {
            if (weight <= 0 || weight > 500)
            {
                errorMessage = "Вес некорректный";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("help");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
