using Banco.Relatorios.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Relatorios
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = from c in contas
                            where c.Saldo > 5000
                            orderby c.Titular.Nome
                            select c.Titular.Nome;
            foreach (var c in resultado)
            {
                listaResultado.Items.Add(c);
            }
            double saldoTotal = contas.Sum(conta => conta.Saldo);
            double maiorSaldo = contas.Max(conta => conta.Saldo);

            labelSaldoTotal.Text = Convert.ToString(saldoTotal);
            labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);
        }

        private void botaoContasAntigas_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = from c in contas
                            where c.Numero < 10 || c.Saldo > 1000
                            select c.Titular.Nome;
            foreach (var c in resultado)
            {
                listaResultado.Items.Add(c);
            }
        }
    }
}
