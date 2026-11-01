namespace MemoriaEstaticaDinamica;

/// <summary>
/// Nodo de una lista enlazada. Cada nodo es un objeto independiente en el Heap
/// y se conecta con el siguiente mediante una referencia.
/// </summary>
public class Nodo
{
    public int Valor { get; set; }
    public Nodo? Siguiente { get; set; }   // referencia al siguiente objeto (null = fin)

    public Nodo(int valor)
    {
        Valor = valor;
    }
}
