using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJWindowsFormsExercicio001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double renda = double.Parse(txtRenda.Text);
            double energia = double.Parse(txtEnergia.Text);
            double agua = double.Parse(txtAgua.Text);
            double tv = double.Parse(txtTV.Text);
            double alimentacao = double.Parse(txtAlimentacao.Text);
            double outros = double.Parse(txtOutros.Text);
            double saldo = renda - (energia + agua + tv + alimentacao + outros);
            double gasto = energia + agua + tv + alimentacao + outros;

            lblGastos.Text = gasto.ToString("C");
            lblSaldo.Text = saldo.ToString("C");


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRenda.Clear();
            txtEnergia.Clear();
            txtAgua.Clear();
            txtTV.Clear();
            txtAlimentacao.Clear();
            txtOutros.Clear();

            lblSaldo.Text = "";
            lblGastos.Text = "";

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
