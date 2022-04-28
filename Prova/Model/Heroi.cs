using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Arma> Armas = new List<Arma>();
        public List<HeroisBatalhas> Batalhas = new List<HeroisBatalhas>();
    }
}
