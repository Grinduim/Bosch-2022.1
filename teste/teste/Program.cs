using teste.DAO;

using (var context = new DAOContext())
{
   context.Database.EnsureCreated();
} 

// nesse momento eu deveria criar os metodos apra fazer os inserts e selects no banco de dados...