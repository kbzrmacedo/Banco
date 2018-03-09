using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.ContaCC;
using Banco.ContaPP;
using Banco.Contas;
using static Banco.ContaPP.ContaPoupanca;

namespace Banco
{
    public partial class FormularioConta : Form
    {
        private List<Conta> contas;
        private Dictionary<string, Conta> dicionario;

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
            this.contas = new List<Conta>();
            this.dicionario = new Dictionary<string, Conta>();

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
            //recuperar a instância da conta selecionada
            Conta selecionada = (Conta)comboContas.SelectedItem;

            try
            {
                double valor = Convert.ToDouble(textoValor.Text);
                selecionada.Deposita(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Depositado");

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Impossível depositar valor negativo!!");
            }

            //string valorDigitado = textoValor.Text;
            //double valorOperacao = Convert.ToDouble(valorDigitado);
            //this.conta.Deposita(valorOperacao);
            //textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            
        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
           // seleciona o objeto e não o index
            Conta selecionada = (Conta)comboContas.SelectedItem;
            double valor = Convert.ToDouble(textoValor.Text);

            try { 
                selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Sacado com sucesso!!");
            }
            catch(SaldoInsuficienteException ex) { 
                MessageBox.Show("Operação Invállida!! --- Motivo: Sem Saldo Disponível.");
            }
            catch (ContaCorrente.SaldoInsuficienteeException ex)
            {
                MessageBox.Show("Operação Invállida!! --- Motivo: Sem Saldo Disponível.");
            }
            catch (ArgumentException ex){
                MessageBox.Show("Não é possível sacar um valor negativo");
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
            this.contas.Add(conta);
            comboContas.Items.Add(conta);

            this.dicionario.Add(conta.Titular.Nome, conta);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            //nome do titular que foi digitado
            string nomeTitular = textoBuscaTitular.Text;

            try { 
                //dicionário para fazer a busca.
                Conta conta = dicionario[nomeTitular];
                //mostra a conta que foi encontrada
                textoTitular.Text = conta.Titular.Nome;
                textoNumero.Text = Convert.ToString(conta.Numero);
                textoSaldo.Text = Convert.ToString(conta.Saldo);
            }
            catch(Exception ex) { 
 
                MessageBox.Show("Nenhuma conta encontrada");
            }
        }
    }
}
