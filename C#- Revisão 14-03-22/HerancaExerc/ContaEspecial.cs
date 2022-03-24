using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExerc
{
    class ContaEspecial:ContaBancaria
    {
        private double LimiteSaque;

        public double LimiteSaque1 { get => LimiteSaque; set => LimiteSaque = value; }

        public void SacarLimite()
        {
            Saldo = Saldo - LimiteSaque; 
        }

    }
}
