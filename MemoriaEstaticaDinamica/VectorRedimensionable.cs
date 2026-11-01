using System.Runtime.CompilerServices;

namespace MemoriaEstaticaDinamica;

/// <summary>
/// Vector de enteros respaldado por un arreglo (bloque contiguo de memoria).
/// Un arreglo tiene tamaño fijo: para "redimensionarlo" hay que reservar
/// un arreglo nuevo, copiar los datos y descartar el anterior.
/// </summary>
public class VectorRedimensionable
{
    private int[] _datos;   // bloque contiguo; su tamaño no puede cambiar

    public VectorRedimensionable(int tamano)
    {
        if (tamano <= 0)
            throw new ArgumentOutOfRangeException(nameof(tamano), "El tamaño debe ser mayor que cero.");

        _datos = new int[tamano];   // se reserva en tiempo de ejecución
    }

    public int Tamano => _datos.Length;

    /// <summary>
    /// Número de identidad del objeto arreglo. Si cambia después de redimensionar,
    /// significa que se trata de un bloque de memoria distinto.
    /// </summary>
    public int Identidad => RuntimeHelpers.GetHashCode(_datos);

    /// <summary>Devuelve una copia de los datos (no se expone el arreglo interno).</summary>
    public int[] ObtenerCopia() => (int[])_datos.Clone();

    public void LlenarAleatorio(Random aleatorio, int maximo = 100)
    {
        for (int i = 0; i < _datos.Length; i++)
            _datos[i] = aleatorio.Next(1, maximo + 1);
    }

    /// <summary>
    /// Cambia el tamaño: crea un arreglo nuevo, copia los elementos que caben
    /// y deja el arreglo anterior para que lo libere el recolector de basura.
    /// </summary>
    public void Redimensionar(int nuevoTamano)
    {
        if (nuevoTamano <= 0)
            throw new ArgumentOutOfRangeException(nameof(nuevoTamano), "El tamaño debe ser mayor que cero.");

        int[] nuevo = new int[nuevoTamano];                   // 1) reservar bloque nuevo
        int aCopiar = Math.Min(_datos.Length, nuevoTamano);   // 2) cuántos datos caben
        Array.Copy(_datos, nuevo, aCopiar);                   // 3) copiar
        _datos = nuevo;                                       // 4) reemplazar la referencia
    }
}
