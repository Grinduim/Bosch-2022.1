using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countAnimals = 3;
            for (int i = 0; i < countAnimals; i++)
            {

                Console.WriteLine($"\nInsira o nome do {i + 1}º animal:");
                string ReadName = Console.ReadLine();
                Console.WriteLine($"Insira o tipo do animal");
                string ReadType = Console.ReadLine();
                Animal animal = new Animal(ReadName, ReadType);
            }

            Console.WriteLine($"Quantidade de animais:" +
                $"\nGato: {Animal.CountCat}" +
                $"\nCachorro: {Animal.CountDogs}" +
                $"\nPeixe: {Animal.CountFish} ");
        }
    }
}
