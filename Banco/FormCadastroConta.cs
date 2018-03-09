using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Relatorios.Busca;
using Banco.Relatorios.ContaCC;
using Banco.Relatorios.Contas;

namespace Banco.Relatorios
{
    public partial class FormCadastroConta : Form
    {
        private ICollection<string> devedores;
        private FormularioConta formPrincipal;

        public FormCadastroConta(FormularioConta formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            bool ehDevedor = this.devedores.Contains(titular);
            if (!ehDevedor)
            {
                Conta novaConta = new ContaCorrente();
                novaConta.Titular = new Cliente(textoTitular.Text);
                novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                //chama o metodo presente no Formulario 1
                this.formPrincipal.AdicionaConta(novaConta);
            }
            else
            {
                MessageBox.Show("devedor");
            }

            
        }
    }
}
