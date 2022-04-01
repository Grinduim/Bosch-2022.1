using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

public class ClasseGenerica<T>
{
    public void Select(string select, string where)
    {
        string ConnectionStringSQL = "Server = JVLPC0497; Database = Vinicius; Trusted_Connection = True; "; // string de conexão com o SQLSERVER
        SqlConnection Connection = new SqlConnection(ConnectionStringSQL);
        string Select = $"Select {select} from {typeof(T).Name}";
        if(where != "")
        {
            Select += $"where {where}";
        }
        SqlCommand comando = new SqlCommand(Select, Connection);
        Connection.Open();
        SqlDataReader dr = comando.ExecuteReader();
        while (dr.Read())
        {
            Console.WriteLine(dr[1]);
        }
    }

    public void DropTable()
    {
        string ConnectionStringSQL = "Server = JVLPC0497; Database = Vinicius; Trusted_Connection = True;"; // string de conexao
        SqlConnection Connection = new SqlConnection(ConnectionStringSQL); // conexao sql
        string DropTable = $"Drop table {typeof(T).Name} "; // comando de drop table + nome da tabela
        SqlCommand comando = new SqlCommand(DropTable, Connection);
        Connection.Open(); //abrindo conecao
        comando.ExecuteNonQuery(); // executando comando
        Connection.Close();
        Console.WriteLine($"Drop table sucess: {typeof(T).Name}"); // mensagem de drop table complet 
    }

}
