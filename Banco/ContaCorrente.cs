namespace Banco
{
    public class ContaCorrente : Conta
    {
        public override void Saca(double valor)
        {
            base.Saca(valor - 0.05); 
        }
        public override void Deposita(double valor)
        {
            base.Saca(valor - 0.10);
        }
    }
}