using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5cSharp
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput(textBoxWeight.Text, textBoxAge.Text, numericUpDownDailyCost.Text, textBoxBreed.Text, textBoxNaturalHabitat.Text))
                {
                    // Зчитуємо значення з текстових та числового полів
                    double weight = Convert.ToDouble(textBoxWeight.Text);
                    int age = Convert.ToInt32(textBoxAge.Text);
                    string dailyCost = numericUpDownDailyCost.Text;
                    string breed = textBoxBreed.Text;
                    string naturalHabitat = textBoxNaturalHabitat.Text;

                    // Створюємо новий об'єкт класу Wolf
                    Wolf wolf = new Wolf(weight, age, dailyCost, breed, naturalHabitat);

                    // Виводимо інформацію про вовка в текстовому полі
                    MessageBox.Show(wolf.GetInfo()); ;
                }
                else
                {
                    throw new Exception("Invalid input.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static bool ValidateInput(string weight, string age, string dailyCost, string breed, string naturalHabitat)
        {
            bool isWeightValid = Regex.IsMatch(weight, @"[0-9]");
            bool isAgeValid = Regex.IsMatch(age, @"[0-9]");
            bool isDailyCostValid = Regex.IsMatch(dailyCost, @"[0-9]");
            bool isBreedValid = Regex.IsMatch(breed, @"^[a-zA-Zа-яА-Я\s]+$");
            bool isNaturalHabitatValid = Regex.IsMatch(naturalHabitat, @"^[a-zA-Zа-яА-Я\s]+$");

            return isWeightValid && isAgeValid && isDailyCostValid && isBreedValid && isNaturalHabitatValid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
