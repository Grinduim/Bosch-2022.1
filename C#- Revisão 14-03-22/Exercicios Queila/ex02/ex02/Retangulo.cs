using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    public class Retangulo
    {
        private float altura;
        private float largura;
        private float area;

        public float Altura
        {
            get => altura;
            set
            {
                if (value > 0)
                {
                    altura = value;
                }
                else
                {
                    throw new Exception("Os valores inseridos devem ser maior que Zero");
                }
            }
        }
        public float Largura
        {
            get => largura;
            set
            {
                if (value > 0)
                {
                    largura = value;
                }
                else
                {
                    throw new Exception("Os valores inseridos devem ser maior que Zero");
                }
            }
        }
        public float Area { get => area; set => area = value; }

        public Retangulo(float altura, float largura)
        {
            Altura = altura;
            Largura = largura;
            Area = altura * largura;
        }
        public void ExibirDadosConsole()
        {
            Console.WriteLine($"Altura: {Altura}" +
                $"\nLargura: {largura}" +
                $"\nArea: {Area}");
        }


    }
}
