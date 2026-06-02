using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _191035_231343.Views
{
    public partial class FrmNegociacaoVenda : Form
    {
        double total, entrada = 0, parcela;

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            calcularParcela();
        }

        public FrmNegociacaoVenda(int idVenda, int idCliente, double total, string nome)
        {
            InitializeComponent();

            txtIdVenda.Text = idVenda.ToString();
            txtIdCliente.Text = idCliente.ToString();
            txtNome.Text = nome;
            txtTotal.Text = total.ToString("C");
            txtData.Text = DateTime.Now.ToShortDateString();
            dtpVencto.Value = DateTime.Now.AddMonths(1);
            this.total = total;

            calcularParcela();
        }

        void calcularParcela()
        {
            double saldo = total - entrada;

            if (txtEntrada.Text != "") entrada = double.Parse(txtEntrada.Text);

            parcela = saldo / Convert.ToByte(nudQtdeParcela.Value);

            lblSaldo.Text = saldo.ToString("C");

            lblVlrParcela.Text = parcela.ToString("C");
        }
    }
}
