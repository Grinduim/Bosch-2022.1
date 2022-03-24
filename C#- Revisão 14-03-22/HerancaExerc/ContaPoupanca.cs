using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExerc
{
    class ContaPoupanca:ContaBancaria
    {
        private int diaRendimento;

        public int DiaRendimento { get => diaRendimento;
            set {
                try
                {
                    if (value > 0 && value <= 31)
                    {
                        diaRendimento = value;
                    }
                    else
                    {
                        throw new Exception("Dia Invalido");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public void CalcularNovoSaldo(double taxaRendimento)
        {
            Saldo = Saldo * (1 + taxaRendimento);
        }

        public ContaPoupanca(string Numero, string nomeCliente, double saldo, int diaRendimento)
        {
            NumConta = Numero;
            NomeCliente = nomeCliente;
            Saldo = saldo;
            DiaRendimento = diaRendimento;
        }
    }
}
