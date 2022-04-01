using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    public class Team
    {
        private string name;
        private string nickName;
        private DateTime foundation;
        private List<Jogador> plantel = new List<Jogador>();
        private List<Jogador> related = new List<Jogador>();

        public Team(string name, string nickName, DateTime foundation, List<Jogador> plantel, List<Jogador> related)
        {
            Name = name;
            NickName = nickName;
            Foundation = foundation;
            Plantel = plantel;
            Related = related;
        }

        public Team()
        {

        }

        public string Name { get => name; set => name = value; }
        public string NickName { get => nickName; set => nickName = value; }
        public DateTime Foundation { get => foundation; set => foundation = value; }
        public List<Jogador> Plantel { get => plantel; set => plantel = value; }
        public List<Jogador> Related { get => related; set => related = value; }

        public void ChoseRelatedPlayers()
        {
            Plantel = Plantel.OrderByDescending(x => x.Quality).ToList();
            Related.Clear();
            for (int i = 0; i < 12; i++)
            {
                Related.Add(Plantel[i]);
            }
        }
    }
}
