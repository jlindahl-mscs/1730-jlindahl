using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1730jlindahl2H1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DateCalculationsButton_Click(object sender, EventArgs e)
        {
            TextBox1AResult.Text = DateTime.Now.ToShortDateString();
            TextBox1BResult.Text = DateTime.Now.ToShortTimeString();
            TextBox2AResult.Text = DateTime.Today.ToShortDateString();
            TextBox2BResult.Text = DateTime.Today.ToShortTimeString();
            TextBox3aResult.Text = DateTime.Today.Year.ToString();
            TextBox3BResult.Text = DateTime.Today.Month.ToString();
            TextBox3CResult.Text = DateTime.Today.Day.ToString();
            TextBox4Result.Text = DateTime.Today.AddDays(90).ToShortDateString();
            TextBox5Result.Text = DateTime.Today.AddMonths(3).ToShortDateString();
            TextBox6Result.Text = Ex2HCalculations.DateCalc06(TextBox6a.Text, TextBox6b.Text, TextBox6c.Text);
            TextBox7Result.Text = Ex2HCalculations.DateCalc07(TextBox7.Text);
            TextBox8Result.Text = Ex2HCalculations.DateCalc08(TextBox8.Text);
            TextBox9Result.Text = Ex2HCalculations.DateCalc09(TextBox9a.Text, TextBox9b.Text);
            TextBox10Result.Text = Ex2HCalculations.DateCalc10(TextBox10a.Text, TextBox10b.Text);
            

        }

        protected void StringCalculationButton_Click(object sender, EventArgs e)
        {
            TextBox11Result.Text = Ex2HCalculations.StringCalc01(TextBox11.Text);
            TextBox12Result.Text = Ex2HCalculations.StringCalc02(TextBox12.Text);
            TextBox13Result.Text = Ex2HCalculations.StringCalc03(TextBox13.Text);
            TextBox14Result.Text = Ex2HCalculations.StringCalc04(TextBox14.Text);
            TextBox15Result.Text = Ex2HCalculations.StringCalc05(TextBox15.Text);
            TextBox16Result.Text = Ex2HCalculations.StringCalc06(TextBox16.Text);
            TextBox17Result.Text = Ex2HCalculations.StringCalc07(TextBox17.Text);
            TextBox18Result.Text = Ex2HCalculations.StringCalc08(TextBox18.Text);
            TextBox19Result.Text = Ex2HCalculations.StringCalc09(TextBox19.Text);
            Label20Result.Text = Ex2HCalculations.StringCalc10(TextBox17.Text, TextBox18.Text, TextBox19.Text);
        }
    }
}