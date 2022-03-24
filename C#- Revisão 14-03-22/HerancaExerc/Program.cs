using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExerc
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaPoupanca ContaPopanca = new ContaPoupanca("1235", "Gerovaldo", 15.50, 16);

            ContaPopanca.Sacar(3.50);
            ContaPopanca.Depositar(5.00);
            Console.ReadKey();

            Console.WriteLine($"Conta: {ContaPopanca.NumConta}" +
                $"Cliente: {ContaPopanca.NomeCliente}" +
                $"Saldo: {ContaPopanca.Saldo}");


            ContaPopanca.CalcularNovoSaldo(0.5);
            Console.WriteLine($"Saldo apos rendimento: { ContaPopanca.Saldo}");
            Console.ReadKey();

        }
    }
}
