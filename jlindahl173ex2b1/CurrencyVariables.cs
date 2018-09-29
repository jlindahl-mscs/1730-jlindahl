using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jlindahl173ex2b1
{
    public partial class frmCurrencyVariables : Form
    {
        public frmCurrencyVariables()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustrailia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00;");

            decimal amountBrazil = Convert.ToDecimal(txtAmountBrazil.Text);
            decimal rateBrazil = Convert.ToDecimal(txtRateBrazil.Text);
            decimal usdBrazil = amountBrazil * rateBrazil;
            txtUSDBrazil.Text = usdBrazil.ToString("0.00");

            decimal amountCanada = Convert.ToDecimal(txtAmountCanada.Text);
            decimal rateCanada = Convert.ToDecimal(txtRateCanada.Text);
            decimal usdCanada = amountCanada * rateCanada;
            txtUSDCanada.Text = usdCanada.ToString("0.00");

            decimal amountIndia = Convert.ToDecimal(txtAmountIndia.Text);
            decimal rateIndia = Convert.ToDecimal(txtRateIndia.Text);
            decimal usdIndia = amountIndia * rateIndia;
            txtUSDIndia.Text = usdIndia.ToString("0.00");

            decimal totalUSD = usdAustralia + usdBrazil + usdCanada + usdIndia;
            txtTotalUSD.Text = totalUSD.ToString("0.00");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustrailia.Text = ("0.00");
            txtRateAustralia.Text = ("0.719813");
            txtAmountBrazil.Text = ("0.00");
            txtRateBrazil.Text = ("0.241436");
            txtAmountCanada.Text = ("0.00");
            txtRateCanada.Text = ("0.759081");
            txtAmountIndia.Text = ("0.00");
            txtRateIndia.Text = ("0.0139414");
        }
    }
}
