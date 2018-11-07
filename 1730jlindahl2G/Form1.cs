using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730jlindahl2G
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1a) 'Switch' with no default
            resultSwitch01TextBox.Text = Ex2GCalculations.Switch01(input01aTextBox.Text);

            //1b) Separate 'if' statements
            resultIf01TextBox.Text = Ex2GCalculations.If01(input01aTextBox.Text);

            //1c if elseif
            resultElseif01TextBox.Text = Ex2GCalculations.ElseIf01(input01aTextBox.Text);

            //1d nested if
            resultNestedIf01TextBox.Text = Ex2GCalculations.NestedIfElse01(input01aTextBox.Text);

            //1e swith with default
            resultSwitchDefault01TextBox.Text = Ex2GCalculations.SwitchDefault01(input01aTextBox.Text);

            //1f if R/C, default value 0 using if statements
            resultIfDefault01TextBox.Text = Ex2GCalculations.IfDefault01(input01aTextBox.Text);

            //1g) if elseif statements
            resultElseIfDefault01TextBox.Text = Ex2GCalculations.ElseIfDefault01(input01aTextBox.Text);

            //1h) nested if-else statements
            resultNestedIfDefault01TextBox.Text = Ex2GCalculations.NestedIfElseDefault01(input01aTextBox.Text);

            // 2a) 'Switch' with no default
            resultSwitch02TextBox.Text = Ex2GCalculations.Switch02(input02aTextBox.Text);

            // 2b) Separate 'if' statements
            resultIf02TextBox.Text = Ex2GCalculations.If02(input02aTextBox.Text);

            // 2c) if elseif
            resultElseIf02TextBox.Text = Ex2GCalculations.ElseIf02(input02aTextBox.Text);

            // 2d) Nested if-else
            resultNestedIf02TextBox.Text = Ex2GCalculations.NestedIfElse02(input02aTextBox.Text);



        }
    }
}
