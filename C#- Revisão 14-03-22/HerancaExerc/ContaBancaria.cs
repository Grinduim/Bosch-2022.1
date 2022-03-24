using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExerc
{
    class ContaBancaria
    {
        private double saldo;
        private string numConta;
        private string nomeCliente;

        public double Saldo { get => saldo; set => saldo = value; }
        public string NumConta { get => numConta; set => numConta = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }

        public void Sacar(double valor)
        {
            try
            {
                if (Saldo - valor > 0)
                {
                    Saldo = Saldo - valor;
                    Console.WriteLine("Saldo sacado");
                }
                else
                {
                    throw new Exception("Valor invalido, saque inferior ao valor disponivel");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Depositar(double Valor)
        {
            try
            {
                if(Valor > 0)
                {
                    Saldo += Valor;
                    Console.WriteLine("Saldo depositado");
                }
                else
                {
                    throw new Exception("Valor para deposito invalido");
                }
            }
            catch
            {

            }
        }
    }
}
