using System;

namespace Banco
{
	public abstract class Conta
	{
		public int Numero { get; set; }
		public double Saldo { get; protected set; }
		public Cliente Titular { get; set; }

		public Conta()
		{
		}

        public virtual void Deposita(double valor)
        {
            
        }

        public virtual void Saca(double valor)
        {
           
        }
    }
}