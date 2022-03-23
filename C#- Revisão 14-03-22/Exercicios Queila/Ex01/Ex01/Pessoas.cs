using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class Pessoas
    {
        private string nome;
        private int idade;
        public static Pessoas maisVelho = null;


        public string Nome { get => nome; set => nome = value; }
        public int Idade
        {
            get => idade;
            set
            {
                if (value > 0)
                {
                    idade = value;
                    if(maisVelho == null)
                    {
                        Pessoas.maisVelho = this;
                    }
                    else if(value > maisVelho.Idade)
                    {
                        Pessoas.maisVelho = this;
                    }
                }
                else
                {
                    throw new Exception("Erro: a pessoa precisa ter idade positiva");
                }
            }
        }

        public Pessoas()
        {

        }



        public Pessoas(string nome, int idade)
        {
            Idade = idade;
            Nome = nome;

        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome:{Nome} Idade: {Idade}");

        }
    }
}
