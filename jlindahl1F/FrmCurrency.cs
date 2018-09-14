using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jlindahl1F
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBrazil.BackgroundImage = picBrazildim.Image;
            btnCanada.BackgroundImage = picCanadadim.Image;
            btnIndia.BackgroundImage = picIndiadim.Image;
            txtRate.Text= ("0.719813");
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSDollars.Text = ("0.00");
            txtTotalUSD.Text = ("0.00");
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBrazil.BackgroundImage = picBrazildim.Image;
            btnCanada.BackgroundImage = picCanadadim.Image;
            btnIndia.BackgroundImage = picIndiadim.Image;

            txtRate.Text= ("0.719813");
            lblCurrency.Text = btnAustralia.Text + ": ";
        }

        private void btnBrazil_Click(object sender, EventArgs e)
        {
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnAustralia.BackgroundImage = picAustraliadim.Image;
            btnCanada.BackgroundImage = picCanadadim.Image;
            btnIndia.BackgroundImage = picIndiadim.Image;

            txtRate.Text = ("0.241436");
            lblCurrency.Text = btnBrazil.Text + ": ";
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnAustralia.BackgroundImage = picAustraliadim.Image;
            btnBrazil.BackgroundImage = picBrazildim.Image;
            btnIndia.BackgroundImage = picIndiadim.Image;

            txtRate.Text = ("0.759081");
            lblCurrency.Text = btnCanada.Text + ": ";
        }

        private void btnIndia_Click(object sender, EventArgs e)
        {
            btnIndia.BackgroundImage = picIndia.Image;
            btnAustralia.BackgroundImage = picAustraliadim.Image;
            btnBrazil.BackgroundImage = picBrazildim.Image;
            btnCanada.BackgroundImage = picCanadadim.Image;

            txtRate.Text= ("0.0139414");
            lblCurrency.Text = btnIndia.Text + ": ";
        }

        private void txtCurrencyType_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
           
        }

        private void lblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtCurrency_Click(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDollars.Text) + Convert.ToDecimal(txtTotalUSD.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
            txtCurrency.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = ("0.00");
            txtRate.Text = ("0.719813");
            txtUSDollars.Text = ("0.00");
            txtTotalUSD.Text = ("0.00");
            lblEquation.Text = ("");

            txtCurrency.Focus();
        }
    }
}
