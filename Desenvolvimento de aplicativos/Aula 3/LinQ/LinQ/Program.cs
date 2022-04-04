using System.Collections;
using static System.Console;

Console.WriteLine("Hello, World!");

MinhaColecao coll  = new MinhaColecao();

coll.Add(8);
coll.Add(10);

WriteLine(coll.Get(1));

public class MinhaColecao : IEnumerable<int>
{
    public List<int> lista = new List<int>();

    public void Add(int i)
    {
        this.lista.Add(i);
    }

    public int Get( int index)
    {
        return this.lista[index];
    }

    public IEnumerator<int> GetEnumerator()
    {
        for(int i = 0; i < this.lista.Count; i++)
        {
            yield return this.lista[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}

public class MeuInteirador : IEnumerator<int>
{
    private MinhaColecao collection;
    int i = -1;

    public MeuInteirador(MinhaColecao coll)
    {
        this.collection = coll;
    }
    

    public int Current => throw new NotImplementedException();

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        i++;
        if( i >= collection.lista.Count)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Reset()
    {
        i = -1;
    }
}