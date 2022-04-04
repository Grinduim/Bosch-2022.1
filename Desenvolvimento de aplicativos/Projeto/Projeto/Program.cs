using System;
using System.Reflection;
using static System.Console;
using System.Data.SqlClient;
using System.Data;
string ConnectionStringSQL = "Server = JVLPC0497; Database = Vinicius; Trusted_Connection = True; "; // string de conexão com o SQLSERVER

var assembly = Assembly.GetExecutingAssembly();
// criação das tabelas se necessario
foreach (var type in assembly.GetTypes()) // para criação das tabelas 
{
    string CommandQuery = " ";
    var talbeatt = type.GetCustomAttribute<TableAttribute>();
    
    if (talbeatt != null)
    {

        SqlConnection Connection = new SqlConnection(ConnectionStringSQL);// instanciando a conexao com o SQL
        Connection.Open();
        string CmdSysString = $"select * from sys.Tables where name = '{type.Name}'"; // query no Banco em si, vendo se ele tem uma tabela com o nome da tabela atual
        SqlCommand SqlCommand = new SqlCommand(CmdSysString, Connection);
        DataTable dt = new DataTable(); // instancia de uma table 
        dt.Load(SqlCommand.ExecuteReader()); // executando o comando e carregando em dataTable
        if (dt.Rows.Count == 0) // se a quantidade de linhas = 0, ou seja, se não existir linhas
        {
            CommandQuery = $"Create Table {type.Name} (\n"; // começo do comando de criação de tabela

            foreach (var prop in type.GetProperties()) // pegando as propries de cada clase
            {
                CommandQuery += $"{prop.Name}"; // concatenação do nome da propriedade
                if (prop.GetCustomAttribute<IntAttribute>() != null) // verificando se a propriedade tem o atributo de inteiro 
                {
                    CommandQuery += " int"; // se sim concatennado a propriedade na string de criação
                }
                if (prop.GetCustomAttribute<DecimalAttribute>() != null)
                {
                    CommandQuery += $" decimal";
                }
                if (prop.GetCustomAttribute<VarcharAttribute>() != null) // verificando se a prop é var
                {
                    CommandQuery += $" varchar({prop.GetCustomAttribute<VarcharAttribute>().Size})";
                }
                if (prop.GetCustomAttribute<NotNull>() != null) // verificando se a prop é not null
                {
                    CommandQuery += " Not Null";
                }
                if (prop.GetCustomAttribute<IndentityAttribute>() != null) // verificando se a prop é indenity
                {
                    CommandQuery += $" IDENTITY ({prop.GetCustomAttribute<IndentityAttribute>().Initial},{prop.GetCustomAttribute<IndentityAttribute>().Increment})";
                }
                if (prop.GetCustomAttribute<PrimaryKeyAttribute>() != null) // verificando se a prop é primary key
                {

                    CommandQuery += " Primary key";
                }
                CommandQuery += ","; // indicando que é o final da linha da propriedade
                CommandQuery += "\n";
            }
            CommandQuery += ")"; // fechando o parentese das propriedades do Creat table
            WriteLine(CommandQuery);

            SqlCommand Command = new SqlCommand(CommandQuery, Connection); // fazer o Creat da table no banco
            Command.ExecuteNonQuery(); // executando o comando
            WriteLine("Executado query ");
            Connection.Close();
        }
    }
}


//exemplo de classe generica
//ClasseGenerica<int> numeros = new ClasseGenerica<int>();
//numeros.AdicionarValor(2);
//numeros.AdicionarValor(5);
//ClasseGenerica<string> palavras = new ClasseGenerica<string>();
//palavras.AdicionarValor("Texto");
//palavras.AdicionarValor("Alfabeto");
//Console.WriteLine($"ultimo valor numeros : {numeros.RetornarUltimoValor()}");
//Console.WriteLine($"Ultima palavra: {palavras.RetornarUltimoValor()}");

// SNCCH01LABF112\TEW_SQLEXPRESS - server  senai
//JVLPC0497 - server bosch

ClasseGenerica<Aluno> aluno = new ClasseGenerica<Aluno>();
aluno.DropTable();
// falta criar as "telas" para o input dos dados do insert into
// falta criar  delete



public class IndentityAttribute : Attribute
{
    public int Initial { get; set; } = 1;
    public int Increment { get; set; } = 1;

    public IndentityAttribute(int initial, int increment)
    {
        this.Initial = initial;
        this.Increment = increment;
    }
}

public class TableAttribute : Attribute
{

}

public class PrimaryKeyAttribute : Attribute
{

}


public class VarcharAttribute : Attribute
{
    public int Size { get; set; }

    public VarcharAttribute(int size)
    {
        this.Size = size;
    }
}

public class IntAttribute : Attribute
{

}

public class NotNull : Attribute
{
}

public class DecimalAttribute: Attribute
{

}


[Table]
public class Aluno // class de alunos
{
    [PrimaryKey]
    [Indentity(1, 1)]
    [Int]
    public int Id { get; set; }

    [NotNull]
    [Varchar(50)]
    public string Name { get; set; }
}

[Table]
public class Professor // class de professor 
{
    [PrimaryKey]
    [Indentity(1, 1)]
    [Int]
    public int Id { get; set; }

    [NotNull]
    [Varchar(50)]
    public string Name { set; get; }
}

[Table]
public class Produto // classe de produtos
{
    [PrimaryKey]
    [Indentity(1,1)]
    [Int]
    public int Id { get; set; }
    [NotNull]
    [Varchar(255)]
    public string Name { get; set; }
    [NotNull]
    [Decimal]
    public decimal Price { get; set; }
}


