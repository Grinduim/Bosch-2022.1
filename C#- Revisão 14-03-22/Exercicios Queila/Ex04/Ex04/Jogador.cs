using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    public class Jogador
    {
        private int id;
        private string name;
        private string nickName;
        private DateTime birth;
        private int number;
        private int quality;
        private int countYellowCard;
        private int countRedCard;
        private bool suspended;

        //Struct
        public Jogador(int id, string name, string nickName, DateTime birth, int number, int quality, int countYellowCard, int countRedCard, bool suspended)
        {
            this.id = id;
            this.name = name;
            this.nickName = nickName;
            this.birth = birth;
            this.number = number;
            this.quality = quality;
            this.countYellowCard = countYellowCard;
            this.countRedCard = countRedCard;
            this.suspended = suspended;
        }

        //all getter e setters
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string NickName { get => nickName; set => nickName = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public int Number { get => number; set => number = value; }
        public int Quality { get => quality; set => quality = value; }
        public int CountYellowCard { get => countYellowCard; set => countYellowCard = value; }
        public int CountRedCard { get => countRedCard; set => countRedCard = value; }
        public bool Suspended { get => suspended; set => suspended = value; }

        public bool PlayerSuspened()
        {
            if(countRedCard == 1 || countYellowCard == 3)
            {
                suspended = true;
                return true;
            }else
            {
                suspended = false;
                return false;
            }
        }

        public bool PlayerSuspenedConsole()
        {
            if (countRedCard == 1 || countYellowCard == 3)
            {
                Console.WriteLine("Fora de Jogo");
                suspended = true;
                return true;
            }
            else
            {
                Console.WriteLine("Ta pra jogo baby");
                suspended = false;
                return false;
            }
        }


    }
}
