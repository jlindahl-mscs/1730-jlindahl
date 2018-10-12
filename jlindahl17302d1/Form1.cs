using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jlindahl17302d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setpassvaluesButton_Click(object sender, EventArgs e)
        {
            textbox1Input.Text = "Frank";
            textbox2Input.Text = "";
            textbox3Input.Text = "2.3";
            textbox4Input.Text = "false";
            textbox5AInput.Text = "2";
            textbox5BInput.Text = "2";
            textbox6Input.Text = "xyz";
            textbox7Input.Text = "1";
            textbox8AInput.Text = "1";
            textbox8BInput.Text = "2";
            textbox9Input.Text = "500";
            textbox10AInput.Text = "2";
            textbox10BInput.Text = "3";
        }

        private void setfailvaluesButton_Click(object sender, EventArgs e)
        {
            textbox1Input.Text = "xyz";
            textbox2Input.Text = "xyz";
            textbox3Input.Text = "2.4";
            textbox4Input.Text = "true";
            textbox5AInput.Text = "2";
            textbox5BInput.Text = "3";
            textbox6Input.Text = "Jones";
            textbox7Input.Text = "0";
            textbox8AInput.Text = "1";
            textbox8BInput.Text = "1";
            textbox9Input.Text = "499";
            textbox10AInput.Text = "4";
            textbox10BInput.Text = "3";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            textbox1ResultA.Text = "Fail";
            textbox2ResultA.Text = "Fail";
            textbox3ResultA.Text = "Fail";
            textbox4ResultA.Text = "Fail";
            textbox5ResultA.Text = "Fail";
            textbox6ResultA.Text = "Fail";
            textbox7ResultA.Text = "Fail";
            textbox8ResultA.Text = "Fail";
            textbox9ResultA.Text = "Fail";
            textbox10ResultA.Text = "Fail";

            textbox1ResultB.Text = "Success";
            textbox2ResultB.Text = "Success";
            textbox3ResultB.Text = "Success";
            textbox4ResultB.Text = "Success";
            textbox5ResultB.Text = "Success";
            textbox6ResultB.Text = "Success";
            textbox7ResultB.Text = "Success";
            textbox8ResultB.Text = "Success";
            textbox9ResultB.Text = "Success";
            textbox10ResultB.Text = "Success";

            if (textbox1Input.Text == "Frank")
                textbox1ResultA.Text = "Success";

            if (textbox1Input.Text != "Frank")
                textbox1ResultB.Text = "Fail";

            if (textbox2Input.Text == "")
                textbox2ResultA.Text = "Success";

            if (textbox2Input.Text != "")
                textbox2ResultB.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textbox3Input.Text);
            if (val3 == 2.3m)
                textbox3ResultA.Text = "Success";

            if (val3 != 2.3m)
                textbox3ResultB.Text = "Fail";

            bool val4 = Convert.ToBoolean(textbox4Input.Text);
            if (val4 == false)
                textbox4ResultA.Text = "Success";

            if (val4 != false)
                textbox4ResultB.Text = "Fail";

            int val5a = Convert.ToInt32(textbox5AInput.Text);
            int val5b = Convert.ToInt32(textbox5BInput.Text);
            if (val5a == val5b)
                textbox5ResultA.Text = "Success";

            if (val5a != val5b)
                textbox5ResultB.Text = "Fail";

            if (textbox6Input.Text != "Jones")
                textbox6ResultA.Text = "Success";

            if (textbox6Input.Text == "Jones")
                textbox6ResultB.Text = "Fail";

            int val7 = Convert.ToInt32(textbox7Input.Text);
            if (val7 > 0)
                textbox7ResultA.Text = "Success";

            if (val7 == 0)
                textbox7ResultB.Text = "Fail";

            int val8a = Convert.ToInt32(textbox8AInput.Text);
            int val8b = Convert.ToInt32(textbox8BInput.Text);

            if (val8a < val8b)
                textbox8ResultA.Text = "Success";

            if (val8a == val8b)
                textbox8ResultB.Text = "Fail";

            int val9 = Convert.ToInt32(textbox9Input.Text);

            if (val9 >= 500)
                textbox9ResultA.Text = "Success";

            if (val9 != 500)
                textbox9ResultB.Text = "Fail";

            int val10a = Convert.ToInt32(textbox10AInput.Text);
            int val10b = Convert.ToInt32(textbox10BInput.Text);

            if (val10a <= val10b)
                textbox10ResultA.Text = "Success";

            if (val10a >= val10b)
                textbox10ResultB.Text = "Fail";

        }
    }
}
