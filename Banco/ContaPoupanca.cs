using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta
    {

        public override void Saca(double valor)
        {
            base.Saca(valor + 0.10); // chama o método da classe base passando como argumento valor + 0.10. 
        }
    }
}