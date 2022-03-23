using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    public class Animal
    {
        private string name;
        private string type;

        public static int CountDogs;
        public static int CountFish;
        public static int CountCat;

        public string Name { get => name; set => name = value; }
        public string Type
        {
            get => type;
            set{
                List<string> list = new List<string>();
                list.Add("Cachorro");
                list.Add("Gato");

                if (list.Contains(value))
                {
                    type = value;
                    if (type == list[0])
                    {
                        CountDogs++;
                    }
                    else if (type == list[1])
                    {
                        CountCat++;
                    }

                }
                else
                {
                    type = "Peixe";
                    CountFish++;
                }
            }
        }

        public Animal(string name, string type)
        {
            Name = name;
            Type = type;
        }

    }
}
