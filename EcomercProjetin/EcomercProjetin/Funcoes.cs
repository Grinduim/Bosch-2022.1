using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomercProjetin
{
    class Funcoes
    {
        public static void Menu()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\n" +
                                    "[1] - Para cadastrar produto" +
                                    "\n[2] - Para listar produtos" +
                                    "\n[3] - Para comprar produtos" +
                                    "\n[4] - Para Visualizar Carrinho" +
                                    "\n[5] - Para  Fechar Pedido" +
                                    "\n[6] - Para Sair do Sistema" +
                                    "\nR: ");
                    int opc = int.Parse(Console.ReadLine());

                    if(opc < 0 || opc > 7)
                    {
                        throw new ArithmeticException("Valor Invalido");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro: Tente Novamente");
                    continue;
                }
                
            }
           
              
        }
    }
}
