// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// MeuDelegate md = Console.WriteLine;

//public delegate void MeuDelegate(string texto); // delegate -> funções do tipo void que recebe uma string -> console.writeline
// ou qualquer outro tipo de função q pode ser usada assim

Func<int, bool> f = i => i < 5;

int [] arr = {1, 2, 3, 4, 5, 6, 7,8,9,10,11,};

var result = Where(arr, meuteste);

foreach (int i in result)
{
    Console.WriteLine(i);
}

bool meuteste(int[] arr)
{
    return i > 5;
}

IEnumerable<int> Where(IEnumerable<int> coll, Func<int,bool> func)
{
    List<int> result = new List<int>();
    foreach (int item in coll)
    {
        if (func(item))
        {
            result.Add(item);
        }
    }
    return result;
}

public static 