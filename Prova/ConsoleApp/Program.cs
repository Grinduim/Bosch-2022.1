using Model;
using DAO;

//using (var context =  new DAOContext())
//{
//    context.Database.EnsureCreated();
//}

while (true)
{
    Console.WriteLine("Insira um o nome para inserir uma arma: ");
    string nome = Console.ReadLine();
    Arma NovaArma = new Model.Arma(nome);
    
    
}