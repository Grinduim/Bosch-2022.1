using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Insira um valor para a altura do seu triangulo/retangulo");
            float Altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor para a largunra do seu trinagulo/retaungulo");
            float Largura = float.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(Altura,Largura);

            retangulo.ExibirDadosConsole();

        }
    }
}
