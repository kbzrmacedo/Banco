using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormularioConta : Form
    {
        private Conta[] contas;
        //private Conta conta;
        // guarda o número de contas que já foram cadastradas
        private int numeroDeContas;
        public FormularioConta()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // criando o array para guardar as contas
            this.contas = new Conta[10];

            // vamos inicializar algumas instâncias de Conta.
            Conta c1 = new ContaCorrente();
            c1.Titular = new Cliente("Victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("Matheus");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("Sidinei");
            c3.Numero = 3;
            this.AdicionaConta(c3);

            // foreach (Conta conta in contas)
            // {
            //     comboContas.Items.Add(conta.Titular.Nome);
            // }

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            //recuperar o índice da conta selecionada
            int indice = comboContas.SelectedIndex;

            //ler a posição correta do array
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            //string valorDigitado = textoValor.Text;
            //double valorOperacao = Convert.ToDouble(valorDigitado);
            //this.conta.Deposita(valorOperacao);
            //textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Depositado");
        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            //recuperar o índice da conta selecionada
            int indice = comboContas.SelectedIndex;

            //ler a posição correta do array
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            Conta conta = new ContaPoupanca();
            if (valor + 0.10 <= conta.Saldo)
            {
                MessageBox.Show("Sacado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Operação Invállida!! Motivo: Sem Saldo Disponível.");
            }       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("Titular: " + conta.Titular.Nome);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //recuperar o index selecionado
            int indice = comboContas.SelectedIndex;

            //recuperar o Nome da conta através do indice
            Conta selecionada = contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void BuscaDeConta_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            // this representa a instância de Form1 que está sendo utilizada pelo
            // Windows Form
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            MessageBox.Show("imposto da conta corrente = " + conta.CalculaTributo());
            ITributavel t = conta;

            MessageBox.Show("imposto da conta pela interface = " + t.CalculaTributo());

            SeguroDeVida sv = new SeguroDeVida();
            MessageBox.Show("imposto do seguro = " + sv.CalculaTributo());

            t = sv;
            MessageBox.Show("imposto do seguro pela interface" + t.CalculaTributo());

        }

    }
}
