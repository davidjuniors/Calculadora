using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double dValorA = 0;
        double dValorB = 0;
        string cOperacao;
        bool bResult = false;
        bool bRestarted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '0';
            else
                txtResult.Text = "0";

            bResult = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '1';
            else
                txtResult.Text = "1";

            bResult = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '2';
            else
                txtResult.Text = "2";

            bResult = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '3';
            else
                txtResult.Text = "3";

            bResult = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '4';
            else
                txtResult.Text = "4";

            bResult = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '5';
            else
                txtResult.Text = "5";

            bResult = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '6';
            else
                txtResult.Text = "6";

            bResult = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '7';
            else
                txtResult.Text = "7";

            bResult = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '8';
            else
                txtResult.Text = "8";

            bResult = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '9';
            else
                txtResult.Text = "9";

            bResult = false;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            cOperacao = "soma";
            dValorA = double.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            txtResult.Text = "";
            lbMemorial.Text = string.Concat(dValorA, " + ");

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            cOperacao = "subtrai";
            dValorA = double.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            lbMemorial.Text = string.Concat(dValorA, " - ");
            txtResult.Text = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            cOperacao = "multiplica";
            dValorA = double.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            lbMemorial.Text = string.Concat(dValorA, " * ");
            txtResult.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            cOperacao = "divide";
            dValorA = double.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            lbMemorial.Text = string.Concat(dValorA, " / ");
            txtResult.Text = "";
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!bResult)
                txtResult.Text += '.';
            else
                txtResult.Text = ".";

            bResult = false;
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            dValorA = 0;
            dValorB = 0;
            lbMemorial.Text = "";
            bRestarted = true;
        }

        private void btnZerarTela_Click(object sender, EventArgs e)
        {
            if (dValorA != 0)
            {
                dValorB = 0;
                txtResult.Text = "";
            }
            else
            {
                dValorA = 0;
                dValorB = 0;
                txtResult.Text = "";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (bResult)
                return;

            switch(cOperacao)
            {
                case "soma":
                    dValorB = double.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                    txtResult.Text = (dValorA + dValorB).ToString();
                    break;
                case "subtrai":
                    dValorB = double.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                    txtResult.Text = (dValorA - dValorB).ToString();
                    break;
                case "multiplica":
                    dValorB = double.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                    txtResult.Text = (dValorA * dValorB).ToString();
                    break;
                case "divide":
                    dValorB = double.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                    txtResult.Text = (dValorA / dValorB).ToString();
                    break;
                default:
                    break;

            }

            lbMemorial.Text = string.Concat(lbMemorial.Text, " ", dValorB);
            bResult = true;
        }

        
    }
}
