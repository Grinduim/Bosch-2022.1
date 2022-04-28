using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Model
{
    public class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Arma(string nome)
        {
            Nome = nome;
        }
    }


    public int Salvar ()
    {
        var ID = 0;
        using(var context =  new DAOContext())
        {
            var Arma = new DAO.Armas
            {
                Nome = this.Nome;
            };
            context.Armas.Add(Arma);
            context.SaveChanges();
            ID = Arma.Id;

        }
        return ID;
    }
}
