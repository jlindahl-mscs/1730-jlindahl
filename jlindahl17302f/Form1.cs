using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jlindahl17302f
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            //#1: if
            //subtotal = Decimal.Parse(input01aTextBox.Text);
            //    if (subtotal > 100m)
            //    discountPercent = 0.2m;
            //result01TextBox.Text = discountPercent.ToString();
            result01TextBox.Text = Ex2fCalculations.Calc01(input01aTextBox.Text);

            //#2: if {block}
           // discountPercent = 0m;
           // subtotal = Decimal.Parse(input02aTextBox.Text);
            ////string status = "Standard rate: ";
            //if (subtotal >= 100m)
            //{
            //    discountPercent = 0.2m;
              //  status = "Bulk rate: ";
           // }
            result02TextBox.Text = Ex2fCalculations.Calc02(input02aTextBox.Text);

            //#3: if else
           // subtotal = Decimal.Parse(input03aTextBox.Text);
            //discountPercent = 0m;
            //if (subtotal >= 100m)
            //    discountPercent = 0.2m;
           // else
               // discountPercent = 0.1m;
            result03TextBox.Text = Ex2fCalculations.Calc03(input03aTextBox.Text);

            //#4: if else if
           // subtotal = Decimal.Parse(input04aTextBox.Text);
           // discountPercent = 0m;
           // if (subtotal >= 100m && subtotal < 200m)
             //   discountPercent = 0.2m;
            //else if (subtotal >= 200m && subtotal < 300m)
              //  discountPercent = 0.3m;
           // else if (subtotal >= 300)
                discountPercent = 0.4m;
            ////else
              //  discountPercent = 0.1m;
            result04TextBox.Text = Ex2fCalculations.Calc04(input04aTextBox.Text);

            //#5: Better range test
            
            result05TextBox.Text = Ex2fCalculations.Calc05(input05aTextBox.Text);

            // #6: nested if statements
            result06TextBox.Text = Ex2fCalculations.Calc06(input06aTextBox.Text,input06bTextBox.Text);

            //#7 input validation
            result07TextBox.Text = Ex2fCalculations.Calc07(input07aTextBox.Text);

            // #8 Validate input, calculate quantity * price, shipping
            result08TextBox.Text = Ex2fCalculations.Calc08(input08aTextBox.Text, input08bTextBox.Text);

            // // #9 Validate input, calculate difference * rate
            result09TextBox.Text = Ex2fCalculations.Calc09(input09aTextBox.Text, input09bTextBox.Text);

            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            result10TextBox.Text = Ex2fCalculations.Calc10(input10aTextBox.Text, input10bTextBox.Text);
        }
    }
}
