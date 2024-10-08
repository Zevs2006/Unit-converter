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

        // ���������� ��������� ��������� (�����, ���, �����)
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFromUnit.Items.Clear();
            comboBoxToUnit.Items.Clear();

            switch (comboBoxCategory.SelectedItem.ToString())
            {
                case "�����":
                    comboBoxFromUnit.Items.AddRange(new string[] { "�����", "���������", "����������", "����������", "����", "����", "����", "�����" });
                    comboBoxToUnit.Items.AddRange(new string[] { "�����", "���������", "����������", "����������", "����", "����", "����", "�����" });
                    break;

                case "���":
                    comboBoxFromUnit.Items.AddRange(new string[] { "����������", "������", "�����", "�����", "�����" });
                    comboBoxToUnit.Items.AddRange(new string[] { "����������", "������", "�����", "�����", "�����" });
                    break;

                case "�����":
                    comboBoxFromUnit.Items.AddRange(new string[] { "�����", "����������", "���������� �����", "�������", "�����" });
                    comboBoxToUnit.Items.AddRange(new string[] { "�����", "����������", "���������� �����", "�������", "�����" });
                    break;
            }

            comboBoxFromUnit.SelectedIndex = 0;
            comboBoxToUnit.SelectedIndex = 0;
        }

        // ���������� ������� �� ������ "��������������"
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(textBoxInput.Text);
                string fromUnit = comboBoxFromUnit.SelectedItem.ToString();
                string toUnit = comboBoxToUnit.SelectedItem.ToString();
                double result = ConvertUnits(input, fromUnit, toUnit);
                labelResult.Text = $"���������: {result} {toUnit}";
            }
            catch (FormatException)
            {
                MessageBox.Show("������� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ����� ��� ����������� ������ ���������
        private double ConvertUnits(double value, string fromUnit, string toUnit)
        {
            // ����������� ��� �����
            if (comboBoxCategory.SelectedItem.ToString() == "�����")
            {
                double valueInMeters = ConvertToMeters(value, fromUnit);
                return ConvertFromMeters(valueInMeters, toUnit);
            }
            // ����������� ��� ����
            else if (comboBoxCategory.SelectedItem.ToString() == "���")
            {
                double valueInKilograms = ConvertToKilograms(value, fromUnit);
                return ConvertFromKilograms(valueInKilograms, toUnit);
            }
            // ����������� ��� ������
            else if (comboBoxCategory.SelectedItem.ToString() == "�����")
            {
                double valueInLiters = ConvertToLiters(value, fromUnit);
                return ConvertFromLiters(valueInLiters, toUnit);
            }

            return 0;
        }

        // ����������� ����� � �����
        private double ConvertToMeters(double value, string fromUnit)
        {
            switch (fromUnit)
            {
                case "�����": return value;
                case "���������": return value * 1000;
                case "����������": return value / 100;
                case "����������": return value / 1000;
                case "����": return value * 1609.34;
                case "����": return value * 0.9144;
                case "����": return value * 0.3048;
                case "�����": return value * 0.0254;
                default: return 0;
            }
        }

        // ����������� ����� �� ������ � ������� �������
        private double ConvertFromMeters(double value, string toUnit)
        {
            switch (toUnit)
            {
                case "�����": return value;
                case "���������": return value / 1000;
                case "����������": return value * 100;
                case "����������": return value * 1000;
                case "����": return value / 1609.34;
                case "����": return value / 0.9144;
                case "����": return value / 0.3048;
                case "�����": return value / 0.0254;
                default: return 0;
            }
        }

        // ����������� ���� � ����������
        private double ConvertToKilograms(double value, string fromUnit)
        {
            switch (fromUnit)
            {
                case "����������": return value;
                case "������": return value / 1000;
                case "�����": return value * 1000;
                case "�����": return value * 0.453592;
                case "�����": return value * 0.0283495;
                default: return 0;
            }
        }

        // ����������� ���� �� ����������� � ������� �������
        private double ConvertFromKilograms(double value, string toUnit)
        {
            switch (toUnit)
            {
                case "����������": return value;
                case "������": return value * 1000;
                case "�����": return value / 1000;
                case "�����": return value / 0.453592;
                case "�����": return value / 0.0283495;
                default: return 0;
            }
        }

        // ����������� ������ � �����
        private double ConvertToLiters(double value, string fromUnit)
        {
            switch (fromUnit)
            {
                case "�����": return value;
                case "����������": return value / 1000;
                case "���������� �����": return value * 1000;
                case "�������": return value * 3.78541;
                case "�����": return value * 0.473176;
                default: return 0;
            }
        }

        // ����������� ������ �� ������ � ������� �������
        private double ConvertFromLiters(double value, string toUnit)
        {
            switch (toUnit)
            {
                case "�����": return value;
                case "����������": return value * 1000;
                case "���������� �����": return value / 1000;
                case "�������": return value / 3.78541;
                case "�����": return value / 0.473176;
                default: return 0;
            }
        }
    }
}
