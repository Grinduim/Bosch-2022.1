using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QtdPessoa = 3;
            List<Pessoas> ListaPessoas = new List<Pessoas>();
            for (int i = 0; i < QtdPessoa; i++)
            {
                try
                {

                    Pessoas pessoa = new Pessoas();
                    Console.WriteLine($"Insira o nome da {i + 1}º Pessoa:");
                    pessoa.Nome = Console.ReadLine();
                    Console.WriteLine($"Insira a  idade de {pessoa.Nome}");
                    pessoa.Idade = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                    Console.WriteLine("Insira novamente os dados");
                    continue;
                }
            }
            Console.WriteLine($"A pessoa mais velha é :");
            Pessoas.maisVelho.ExibirDados();

        }
    }
}
