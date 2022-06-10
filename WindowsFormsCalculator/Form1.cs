using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            var ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";
            try
            {
                var value1 = Convert.ToDouble(textBoxValue1.Text,ci);
                var value2 = Convert.ToDouble(textBoxValue2.Text,ci);
                var result = value1 + value2;
                textBoxResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            var ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";
            try
            {
                var value1 = Convert.ToDouble(textBoxValue1.Text, ci);
                var value2 = Convert.ToDouble(textBoxValue2.Text, ci);
                var result = value1 - value2;
                textBoxResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            var ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";
            try
            {
                var value1 = Convert.ToDouble(textBoxValue1.Text, ci);
                var value2 = Convert.ToDouble(textBoxValue2.Text, ci);
                var result = value1 * value2;
                textBoxResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            var ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";
            try
            {
                var value1 = Convert.ToDouble(textBoxValue1.Text, ci);
                var value2 = Convert.ToDouble(textBoxValue2.Text, ci);
                var result = value1 / value2;
                textBoxResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }
        }
    }
}
