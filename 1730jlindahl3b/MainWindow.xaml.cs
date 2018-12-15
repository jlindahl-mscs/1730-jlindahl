using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1730jlindahl3b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        { 
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox0A.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(499m);
                resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch
            {
                MessageBox.Show("Invalid input:" + this.inputTextBox0A.Text);
            }

            try
            {
                int months = Int32.Parse(this.inputTextBox2A.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox2B.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox2C.Text);
                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, 24);
                resultTextBox2.Text = futureValue.ToString("c2");
            }
            catch
            {
                MessageBox.Show("Invalid input:\n" 
                    + this.inputTextBox2A.Text + "\n"
                    + this.inputTextBox2B.Text + "\n"
                    + this.inputTextBox2C.Text + "\n");
            }
            //3) CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months, ref futureValue)
            try
            {
                int months = Int32.Parse(this.inputTextBox3A.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox3B.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox3C.Text);
                decimal futureValue = 0m;
                Ex3bCalculations.CalculateFutureValue
                    (monthlyInvestment, monthlyInterestRate, months, ref futureValue);
                this.resultTextBox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                this.resultTextBox3.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox3A.Text + "\n"
                    + this.inputTextBox3B.Text + "\n"
                    + this.inputTextBox3C.Text + "\n");
            }

            //  4) FahrenheitToCelsius(fahrenheit)
            try
            {
                double fahrenheit = Double.Parse(this.inputTextBox4A.Text);
                this.resultTextBox4.Text = Ex3bCalculations.FahrenheitToCelsius(fahrenheit).ToString("f1");
            }
            catch
            {
                this.resultTextBox4.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox4A.Text);
            }

            //  5) CelsiusToFahrenheit(celsius, out fahrenheit)
            try
            {
                double celsius = Double.Parse(this.inputTextBox5A.Text);
                Ex3bCalculations.CelsiusToFahrenheit(celsius, out double fahrenheit);
                this.resultTextBox5.Text = fahrenheit.ToString("f1");
            }
            catch
            {
                this.resultTextBox5.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox5A.Text);
            }

            //  6) GrossPay(hours, rate)
            try
            {
                decimal hours = Decimal.Parse(this.inputTextBox6A.Text);
                decimal rate = Decimal.Parse(this.inputTextBox6B.Text);
                this.resultTextBox6.Text = Ex3bCalculations.GrossPay(hours, rate).ToString("c2");
            }
            catch
            {
                this.resultTextBox6.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox6A.Text + "\n"
                    + this.inputTextBox6B.Text);
            }

            //  7) TotalHours(strNumbers)
            try
            {
                this.resultTextBox7.Text =
                    Ex3bCalculations.TotalHours(this.inputTextBox7A.Text).ToString("n2");
            }
            catch
            {
                this.resultTextBox7.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox7A.Text);
            }

            //8) GrossPay(strNumbers, rate)
            try
            {
                decimal rate = Decimal.Parse(this.inputTextBox8B.Text);
                this.resultTextBox8.Text =
                    Ex3bCalculations.GrossPay(this.inputTextBox8A.Text, rate).ToString("c2");
            }
            catch
            {
                this.resultTextBox8.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox8A.Text + "\n"
                    + this.inputTextBox8B.Text);
            }

        }
    }
}
