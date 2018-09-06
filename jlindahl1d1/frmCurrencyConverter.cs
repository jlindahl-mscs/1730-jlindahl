using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jlindahl1d1
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (Convert.ToDecimal(txtAmountAustrailia.Text)
                   * Convert.ToDecimal(txtRateAustralia.Text)
                   ).ToString("0.00");
        }

     

        private void txtBrazilTextChanged(object sender, EventArgs e)
        {
            txtUSDBrazil.Text = (Convert.ToDecimal(txtAmountBrazil.Text)
                  * Convert.ToDecimal(txtRateBrazil.Text)
                  ).ToString("0.00");
        }

        private void txtCanadaTextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (Convert.ToDecimal(txtAmountCanada.Text)
                  * Convert.ToDecimal(txtRateCanada.Text)
                  ).ToString("0.00");
        }

        private void txtIndiaTextChanged(object sender, EventArgs e)
        {
            txtUSDIndia.Text = (Convert.ToDecimal(txtAmountIndia.Text) * 
                Convert.ToDecimal(txtRateIndia.Text)).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDBrazil.Text) 
                + Convert.ToDecimal(txtUSDCanada.Text) + Convert.ToDecimal(txtUSDIndia.Text)
                ).ToString("0.00");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
