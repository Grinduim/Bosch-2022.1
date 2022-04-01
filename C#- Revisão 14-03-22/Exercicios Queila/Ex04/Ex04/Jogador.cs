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
        private string position;
        private double quality;
        private int countYellowCard;
        private int countRedCard;
        private bool suspended;
        private bool trainingBeforeGame;

        private static int lastID;

        //Struct

        public Jogador()
        {

        }

        public Jogador(int id, string name, string nickName, DateTime birth, int number, string position, double quality, int countYellowCard, int countRedCard, bool suspended, bool trainingBeforeGame)
        {
            this.id = id;
            this.name = name;
            this.nickName = nickName;
            this.birth = birth;
            this.number = number;
            this.position = position;
            this.quality = quality;
            this.countYellowCard = countYellowCard;
            this.countRedCard = countRedCard;
            this.suspended = suspended;
            this.trainingBeforeGame = trainingBeforeGame;
        }


        //all getter e setters
        public int Id
        {
            get => id;
            set
            {
                LastID++;
                id = value;
            }
        }
        public string Name { get => name; set => name = value; }
        public string NickName { get => nickName; set => nickName = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public int Number { get => number; set => number = value; }
        public double Quality { get => quality; set => quality = value; }
        public int CountYellowCard
        {
            get => countYellowCard;
            set
            {
                countYellowCard = value;
                Console.WriteLine(value);
                if (countYellowCard >= 3)
                {
                    suspended = true;
                }
            }
        }
        public int CountRedCard
        {
            get => countRedCard;
            set
            {
                countRedCard = value;
                if (countRedCard >= 1)
                {
                    suspended = true;
                }
            }
        }
        public bool Suspended { get => suspended; set => suspended = value; }
        public static int LastID { get => lastID; set => lastID = value; }
        public string Position { get => position; set => position = value; }
        public bool TrainingBeforeGame { get => trainingBeforeGame; set => trainingBeforeGame = value; }

        public bool PlayerSuspened()
        {
            if (countRedCard == 1 || countYellowCard == 3)
            {
                suspended = true;
                return true;
            }
            else
            {
                suspended = false;
                return false;
            }
        }

        public string PlayerSuspenedString()
        {
            if (countRedCard == 1 || countYellowCard == 3 || Suspended == true)
            {
                suspended = true;
                return "Fora de Jogo";
            }
            else
            {

                suspended = false;
                return "Tá pra jogo";

            }
        }

        public void ConsolePlayerInfo()
        {
            Console.WriteLine($"{Position}: {number} - {Name} ({NickName}) - {birth.ToString("dd/MMM/yyyy")} Condição : {PlayerSuspenedString()} - Qualidade : {Quality}");
        }

        public void ApplyYellowCard(int quantity)
        {
            CountYellowCard += quantity;
        }

        public void ApplyRedCard(int quantity)
        {
            CountRedCard += quantity;
        }

        public void DoneSuspension()
        {
            countYellowCard = 0;
            countRedCard = 0;
            suspended = false;
        }

        public void SufferInjury()
        {
            Random random = new Random();
            while (Quality > 0)
            {
                int probability = random.Next(1, 101);
                if (probability <= 5 && Quality * 0.85 > 0)
                {
                    Quality = Quality * 0.85;
                }
                else if (probability <= 15 && Quality * 0.90 > 0)
                {
                    Quality = Quality * 0.90;
                }
                else if (probability <= 30 && Quality * 0.95 > 0)
                {
                    Quality = Quality * 0.95;
                }
                else if (probability <= 60 && Quality - 2 > 0)
                {
                    Quality = Quality - 2;
                }
                else if (probability <= 100 && Quality - 1 > 0)
                {
                    quality = Quality - 1;
                }
                else
                {
                    continue;
                }
                break;
            }
        }

        public void TrainingPlayer()
        {
            if (!TrainingBeforeGame && Quality < 100)
            {
                Random random = new Random();
                while (true)
                {
                    int probability = random.Next(1, 101);
                    if (probability <= 5 && Quality + 5 <= 0)
                    {
                        Quality += 5;
                    }
                    else if (probability <= 15 && Quality + 4 <= 100)
                    {
                        Quality += 4;
                    }
                    else if (probability <= 30 && Quality+3 <= 100)
                    {
                        Quality +=3;
                    }
                    else if (probability <= 60 && Quality  +2 <= 100)
                    {
                        Quality = Quality + 2;
                    }
                    else if (probability <= 100 && Quality + 1 <= 100)
                    {
                        quality = Quality + 1;
                    }
                    else
                    {
                        continue;
                    }
                    TrainingBeforeGame = true;
                    break;
                }
            }
        }
    
    }
}
