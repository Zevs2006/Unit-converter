using System;
using System.Windows.Forms;

namespace Unit_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик изменения категории (длина, вес, объем)
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFromUnit.Items.Clear();
            comboBoxToUnit.Items.Clear();

            switch (comboBoxCategory.SelectedItem.ToString())
            {
                case "Длина":
                    comboBoxFromUnit.Items.AddRange(new string[] { "Метры", "Километры", "Сантиметры", "Миллиметры", "Мили", "Ярды", "Футы", "Дюймы" });
                    comboBoxToUnit.Items.AddRange(new string[] { "Метры", "Километры", "Сантиметры", "Миллиметры", "Мили", "Ярды", "Футы", "Дюймы" });
                    break;

                case "Вес":
                    comboBoxFromUnit.Items.AddRange(new string[] { "Килограммы", "Граммы", "Тонны", "Фунты", "Унции" });
                    comboBoxToUnit.Items.AddRange(new string[] { "Килограммы", "Граммы", "Тонны", "Фунты", "Унции" });
                    break;

                case "Объем":
                    comboBoxFromUnit.Items.AddRange(new string[] { "Литры", "Миллилитры", "Кубические метры", "Галлоны", "Пинты" });
                    comboBoxToUnit.Items.AddRange(new string[] { "Литры", "Миллилитры", "Кубические метры", "Галлоны", "Пинты" });
                    break;
            }

            comboBoxFromUnit.SelectedIndex = 0;
            comboBoxToUnit.SelectedIndex = 0;
        }

        // Обработчик нажатия на кнопку "Конвертировать"
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(textBoxInput.Text);
                string fromUnit = comboBoxFromUnit.SelectedItem.ToString();
                string toUnit = comboBoxToUnit.SelectedItem.ToString();
                double result = ConvertUnits(input, fromUnit, toUnit);
                labelResult.Text = $"Результат: {result} {toUnit}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для конвертации единиц измерения
        private double ConvertUnits(double value, string fromUnit, string toUnit)
        {
            // Конвертация для длины
            if (comboBoxCategory.SelectedItem.ToString() == "Длина")
            {
                double valueInMeters = ConvertToMeters(value, fromUnit);
                return ConvertFromMeters(valueInMeters, toUnit);
            }
            // Конвертация для веса
            else if (comboBoxCategory.SelectedItem.ToString() == "Вес")
            {
                double valueInKilograms = ConvertToKilograms(value, fromUnit);
                return ConvertFromKilograms(valueInKilograms, toUnit);
            }
            // Конвертация для объема
            else if (comboBoxCategory.SelectedItem.ToString() == "Объем")
            {
                double valueInLiters = ConvertToLiters(value, fromUnit);
                return ConvertFromLiters(valueInLiters, toUnit);
            }

            return 0;
        }

        // Конвертация длины в метры
        private double ConvertToMeters(double value, string fromUnit)
        {
            switch (fromUnit)
            {
                case "Метры": return value;
                case "Километры": return value * 1000;
                case "Сантиметры": return value / 100;
                case "Миллиметры": return value / 1000;
                case "Мили": return value * 1609.34;
                case "Ярды": return value * 0.9144;
                case "Футы": return value * 0.3048;
                case "Дюймы": return value * 0.0254;
                default: return 0;
            }
        }

        // Конвертация длины из метров в целевую единицу
        private double ConvertFromMeters(double value, string toUnit)
        {
            switch (toUnit)
            {
                case "Метры": return value;
                case "Километры": return value / 1000;
                case "Сантиметры": return value * 100;
                case "Миллиметры": return value * 1000;
                case "Мили": return value / 1609.34;
                case "Ярды": return value / 0.9144;
                case "Футы": return value / 0.3048;
                case "Дюймы": return value / 0.0254;
                default: return 0;
            }
        }

        // Конвертация веса в килограммы
        private double ConvertToKilograms(double value, string fromUnit)
        {
            switch (fromUnit)
            {
                case "Килограммы": return value;
                case "Граммы": return value / 1000;
                case "Тонны": return value * 1000;
                case "Фунты": return value * 0.453592;
                case "Унции": return value * 0.0283495;
                default: return 0;
            }
        }

        // Конвертация веса из килограммов в целевую единицу
        private double ConvertFromKilograms(double value, string toUnit)
        {
            switch (toUnit)
            {
                case "Килограммы": return value;
                case "Граммы": return value * 1000;
                case "Тонны": return value / 1000;
                case "Фунты": return value / 0.453592;
                case "Унции": return value / 0.0283495;
                default: return 0;
            }
        }

        // Конвертация объема в литры
        private double ConvertToLiters(double value, string fromUnit)
        {
            switch (fromUnit)
            {
                case "Литры": return value;
                case "Миллилитры": return value / 1000;
                case "Кубические метры": return value * 1000;
                case "Галлоны": return value * 3.78541;
                case "Пинты": return value * 0.473176;
                default: return 0;
            }
        }

        // Конвертация объема из литров в целевую единицу
        private double ConvertFromLiters(double value, string toUnit)
        {
            switch (toUnit)
            {
                case "Литры": return value;
                case "Миллилитры": return value * 1000;
                case "Кубические метры": return value / 1000;
                case "Галлоны": return value / 3.78541;
                case "Пинты": return value / 0.473176;
                default: return 0;
            }
        }
    }
}
