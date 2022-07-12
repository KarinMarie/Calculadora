using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        Operacoes op;
        string operacao_texto;
        int operacao = 0;
        decimal n1;
        decimal n2;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "0";
            operacao_texto += "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "1";
            operacao_texto += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "2";
            operacao_texto += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "3";
            operacao_texto += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "4";
            operacao_texto += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "5";
            operacao_texto += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "6";
            operacao_texto += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "7";
            operacao_texto += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "8";
            operacao_texto += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "9";
            operacao_texto += "9";
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            txtPainel.Text = "";
            lblOperacao.Text = "";
            operacao_texto = "";
            n1 = 0;
            n2 = 0;
            operacao = 0;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            //txtPainel.Text += " + ";
            operacao_texto += " + ";
            operacao = 1;
            if (txtPainel.Text != "")  n1 = Convert.ToDecimal(txtPainel.Text);
            txtPainel.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            // txtPainel.Text += " - ";
            operacao_texto += " - ";
            operacao = 2;
            if (txtPainel.Text != "")  n1 = Convert.ToDecimal(txtPainel.Text);
            txtPainel.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            // txtPainel.Text += " * ";
            operacao_texto += " * ";
            operacao = 3;
            if (txtPainel.Text != "")  n1 = Convert.ToDecimal(txtPainel.Text);
            txtPainel.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            // txtPainel.Text += " / ";
            operacao_texto += " / ";
            operacao = 4;
            if (txtPainel.Text != "") n1 = Convert.ToDecimal(txtPainel.Text);
            txtPainel.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            /*op = new Operacoes(txtPainel.Text);
            txtPainel.Text = "";
            txtPainel.Text = op.Calcular().ToString();*/
            operacao_texto += " = ";

            if (txtPainel.Text != "") n2 = Convert.ToDecimal(txtPainel.Text);

            op = new Operacoes(operacao, n1, n2);

            txtPainel.Text = op.calculo().ToString();
            lblOperacao.Text = operacao_texto;

            n1 = 0;
            n2 = 0;
            operacao = 0;
            operacao_texto = "";
        }

        private void btnApagarDigito_Click(object sender, EventArgs e)
        {
            if(txtPainel.Text.Length != 0)
                txtPainel.Text = txtPainel.Text.Remove(txtPainel.Text.Length - 1, 1);
        }

        private void txtPainel_TextChanged(object sender, EventArgs e)
        {
            //lblOperacao.Text += txtPainel.Text;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtPainel.Text += ",";
        }

        private void btnApagarN2_Click(object sender, EventArgs e)
        {
            operacao_texto.Replace(txtPainel.Text, "");
            txtPainel.Text = "";
            n2 = 0;
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            txtPainel.Text = (Convert.ToDecimal(txtPainel.Text) * Convert.ToDecimal(txtPainel.Text)).ToString();
        }
    }
}
