namespace MemoriaEstaticaDinamica;

/// <summary>
/// Lista enlazada simple: ejemplo de memoria dinámica.
/// La memoria se pide objeto por objeto (new Nodo) conforme se necesita
/// y se libera cuando ya no hay referencias hacia los nodos.
/// </summary>
public class ListaEnlazada
{
    private Nodo? _cabeza;   // primer nodo
    private Nodo? _cola;     // último nodo (permite insertar al final en O(1))

    public int Cantidad { get; private set; }

    public void AgregarAlInicio(int valor)
    {
        Nodo nuevo = new Nodo(valor);   // se reserva un objeto nuevo en el Heap
        nuevo.Siguiente = _cabeza;
        _cabeza = nuevo;
        _cola ??= nuevo;                // si estaba vacía, también es la cola
        Cantidad++;
    }

    public void AgregarAlFinal(int valor)
    {
        Nodo nuevo = new Nodo(valor);

        if (_cola == null)
        {
            _cabeza = nuevo;
            _cola = nuevo;
        }
        else
        {
            _cola.Siguiente = nuevo;
            _cola = nuevo;
        }
        Cantidad++;
    }

    public int EliminarPrimero()
    {
        if (_cabeza == null)
            throw new InvalidOperationException("La lista está vacía.");

        int valor = _cabeza.Valor;
        _cabeza = _cabeza.Siguiente;    // el nodo viejo queda sin referencias: el GC lo libera
        if (_cabeza == null)
            _cola = null;
        Cantidad--;
        return valor;
    }

    /// <summary>Acceso por posición: hay que recorrer los nodos desde la cabeza (O(n)).</summary>
    public int ObtenerEn(int indice)
    {
        if (indice < 0 || indice >= Cantidad)
            throw new ArgumentOutOfRangeException(nameof(indice));

        Nodo? actual = _cabeza;
        for (int i = 0; i < indice; i++)
            actual = actual!.Siguiente;

        return actual!.Valor;
    }

    /// <summary>Suelta todas las referencias; el recolector podrá liberar los nodos.</summary>
    public void Vaciar()
    {
        _cabeza = null;
        _cola = null;
        Cantidad = 0;
    }

    public IEnumerable<Nodo> Recorrer()
    {
        Nodo? actual = _cabeza;
        while (actual != null)
        {
            yield return actual;
            actual = actual.Siguiente;
        }
    }
}
