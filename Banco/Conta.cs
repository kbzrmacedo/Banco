﻿using System;
using Banco.Relatorios.ContaCC;
using Banco.Relatorios.ContaPP;
namespace Banco.Relatorios.Contas
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

        public override string ToString()
        {
            return "titular: " + this.Titular.Nome;
        }
    }
}