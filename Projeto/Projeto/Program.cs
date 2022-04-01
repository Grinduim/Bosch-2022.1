using System;
using System.Reflection;
using static System.Console;
//colocar lib do sql

WriteLine("Hello, World!");
// SNCCH01LABF112\TEW_SQLEXPRESS - server 

var assembly = Assembly.GetExecutingAssembly();

//lista.Add(VarcharAttribute);

foreach (var type in assembly.GetTypes())
{
    string Command = " ";
    var talbeatt = type.GetCustomAttribute<TableAttribute>();
    if (talbeatt != null)
    {
        Command = "";
        Command = $"Create Table {type.Name} (\n";

        foreach (var prop in type.GetProperties())
        {
            Command += $"{prop.Name}";
            if (prop.GetCustomAttribute<IntAttribute>() != null)
            {
                Command += " int";
            }

            if (prop.GetCustomAttribute<VarcharAttribute>() != null)
            {
                Command += $" varchar({prop.GetCustomAttribute<VarcharAttribute>().Size})";
            }
            if (prop.GetCustomAttribute<NotNull>() != null)
            {
                Command += " NotNull";
            }
            if (prop.GetCustomAttribute<IndentityAttribute>() != null)
            {
                Command += $" IDENTITY ({prop.GetCustomAttribute<IndentityAttribute>().Initial}.{prop.GetCustomAttribute<IndentityAttribute>().Increment}";
            }
            if (prop.GetCustomAttribute<PrimaryKeyAttribute>() != null)
            {

                Command += " Primary key";
            }
            Command += ",";
            Command += "\n";

        }

        Command += ")";
        WriteLine(Command);
        SqlCommand command = new SqlCommand(queryString, connection); // fazer o insert no banco



    }
}

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



//[Table]
//public class Cliente
//{
//    [PrimaryKey]
//    [Indentity(1, 1)]
//    public int Id { get; set; }

//    [Varchar(200)]
//    [NotNull]
//    public string Name { get; set; }
//}

[Table]
public class Aluno
{
    [PrimaryKey]
    [Indentity(1, 1)]
    [Int]
    public int Id { get; set; }

    [NotNull]
    [Varchar(50)]
    public string Name { get; set; }
}