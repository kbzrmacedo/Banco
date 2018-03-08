namespace Banco
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

        public override void Saca(double valor)
        {
            if (valor + 0.10 <= this.Saldo)
            {
                this.Saldo -= valor + 0.05;
            }
        }

        public override void Deposita(double valor)
        {
            this.Saldo += (valor - 0.10);
        }

        public double CalculaTributo()
        {
            return this.Saldo = (Saldo * 0.05) ;
        }
      
    }
}