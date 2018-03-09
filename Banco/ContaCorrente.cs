using System;
using Banco.Relatorios.Contas;

namespace Banco.Relatorios.ContaCC
{
    public class ContaCorrente : Conta, ITributavel
    {
        private static int totalDeContas = 0;

        public ContaCorrente(){
            ContaCorrente.totalDeContas++;
        }

         public static int ProximaConta()
        {
        return ContaCorrente.totalDeContas + 1;
        }
        public class SaldoInsuficienteeException : Exception
        {
        }
        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteeException();
            }
            else
            {
                this.Saldo -= valor + 0.10;
            }
        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Saldo += (valor - 0.10);
            }
        }

        public double CalculaTributo()
        {
            return this.Saldo = (Saldo * 0.05) ;
        }
      
    }
}