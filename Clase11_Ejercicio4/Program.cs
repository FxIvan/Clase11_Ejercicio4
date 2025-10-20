using System;
using System.Collections;

public class Numeros : IEnumerable, IEnumerator
{
    private int[] _items = { 10, 20, 30, 40, 50 };
    private int _position = -1;

    // Propiedad de solo lectura. Retorna el elemento que se está recorriendo.
    public object Current
    {
        get { return _items[_position]; }
    }

    // Método. Determina que elemento se va a colocar en Current y retorna verdadero.Si ya no hay nada por recorrer debe retornar falso.
    public bool MoveNext()
    {
        _position++;
        return _position < _items.Length;
    }

    // Método. Se inicializan valores que se utilizan en la iteración.
    public void Reset()
    {
        _position = -1;
    }

    // IEnumerable - Retorna el enumerador (esta misma clase)
    public IEnumerator GetEnumerator()
    {
        Reset();
        return this;
    }
}

class Program
{
    static void Main()
    {
        Numeros numeros = new Numeros();

        Console.WriteLine("Recorriendo con foreach:");
        foreach (var n in numeros)
        {
            Console.WriteLine($"Número: {n}");
        }
    }
}
