using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogador> jogadores = new List<Jogador>();

            jogadores.Add(new Jogador(1, "Marcos", "Marcão", DateTime.Parse("04/09/1973"), 1, "Goleiro", 90, 0, 0, false,false));

           
            jogadores.Add(new Jogador(2, "Cafú", "Capita", DateTime.Parse("07/06/1970"), 2, "Lateral Esquerdo", 100, 1, 0, false, false));
             jogadores.Add(new Jogador(3, "Lúcio", "Lúcio", DateTime.Parse("08/03/1978"), 3, "Zagueiro", 70, 0, 0, false, false));
             jogadores.Add(new Jogador(4, "Roque Júnior", "Roque", DateTime.Parse("03/08/1976"), 4, "Zagueiro", 70, 1, 0, false, false));
             jogadores.Add(new Jogador(5, "José Edmílson", "Edmílson", DateTime.Parse("07/07/1976"), 5, "Zagueiro", 80, 0, 0, false, false));
             jogadores.Add(new Jogador(6, "Roberto Carlos", "R6", DateTime.Parse("10/04/1973"), 6, "Lateral Direito", 100, 0, 0, false, false));
             jogadores.Add(new Jogador(7, "Ricardo Luís", "Ricardinhos", DateTime.Parse("23/03/1976"), 7, "Meio-campista", 80, 0, 1, true, false));
             jogadores.Add(new Jogador(8, "Gilberto Silva", "Gilberto", DateTime.Parse("07/10/1976"), 8, "Volante", 90, 1, 0, false, false));
             jogadores.Add(new Jogador(9, "Ronaldo", "R9", DateTime.Parse("22/09/1976"), 9, "Atacante", 100, 0, 0, false, false));
             jogadores.Add(new Jogador(10, "Rivaldo Vítor", "Rivaldo", DateTime.Parse("19/04/1972"), 10, "Atacante", 95, 0, 0, false, false));
             jogadores.Add(new Jogador(11, "Ronaldinho Gaúcho", "R10", DateTime.Parse("21/03/1980"), 11, "Meio-campista", 90, 0, 0, false, false));

             jogadores.Add(new Jogador(1, "Marcos2", "Marcão", DateTime.Parse("04/09/1973"), 1, "Goleiro", 90, 0, 0, false, false));
             jogadores.Add(new Jogador(2, "Cafú2", "Capita", DateTime.Parse("07/06/1970"), 2, "Lateral Esquerdo", 100, 1, 0, false, false));
             jogadores.Add(new Jogador(3, "Lúcio2", "Lúcio", DateTime.Parse("08/03/1978"), 3, "Zagueiro", 70, 0, 0, false, false));
             jogadores.Add(new Jogador(4, "Roque Júnior2", "Roque", DateTime.Parse("03/08/1976"), 4, "Zagueiro", 70, 1, 0, false, false));
             jogadores.Add(new Jogador(5, "José Edmílson2", "Edmílson", DateTime.Parse("07/07/1976"), 5, "Zagueiro", 80, 0, 0, false, false));
             jogadores.Add(new Jogador(6, "Roberto Carlos2", "R6", DateTime.Parse("10/04/1973"), 6, "Lateral Direito", 100, 0, 0, false, false));
             jogadores.Add(new Jogador(7, "Ricardo Luís2", "Ricardinhos", DateTime.Parse("23/03/1976"), 7, "Meio-campista", 80, 0, 1, true, false));
             jogadores.Add(new Jogador(8, "Gilberto Silva2", "Gilberto", DateTime.Parse("07/10/1976"), 8, "Volante", 90, 1, 0, false, false));
             jogadores.Add(new Jogador(9, "Ronaldo2", "R9", DateTime.Parse("22/09/1976"), 9, "Atacante", 100, 0, 0, false, false));
             jogadores.Add(new Jogador(10, "Rivaldo Vítor2", "Rivaldo", DateTime.Parse("19/04/1972"), 10, "Atacante", 95, 0, 0, false, false));
             jogadores.Add(new Jogador(11, "Ronaldinho Gaúcho2", "R10", DateTime.Parse("21/03/1980"), 11, "Meio-campista", 90, 0, 0, false, false));

             Team team = new Team();
             team.Name = "Brazil 2002";
             team.NickName = "Pau Brasil";
             team.Foundation = DateTime.Now;
             team.Plantel = jogadores;

            team.ChoseRelatedPlayers();
            foreach (Jogador players in team.Related){
                players.ConsolePlayerInfo();
            }


        }

        public Jogador CadastrarJogador()
        {
            Jogador Jogador = new Jogador();
            Console.WriteLine("Insert a Name of player");
            Jogador.Name = Console.ReadLine();
            Console.WriteLine("Insert a nickName: ");
            Jogador.NickName = Console.ReadLine();
            Console.WriteLine("Insert a Date of birth: (dd/mm/yyyy) ");
            Jogador.Birth = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-br"));
            Console.WriteLine("Insert a position: ");
            Jogador.Position = Console.ReadLine();
            Console.WriteLine("Insert a Quality: (range 0, 100): ");
            Jogador.Quality = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert how many yellow card he have ");
            Jogador.CountYellowCard = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert how many red card he have ");
            Jogador.CountRedCard = int.Parse(Console.ReadLine());
            Console.WriteLine("Player is supended ? True or false: ");
            Jogador.Suspended = bool.Parse(Console.ReadLine());

            Jogador.Id = Jogador.LastID;

            return Jogador;
        }
    }
}
