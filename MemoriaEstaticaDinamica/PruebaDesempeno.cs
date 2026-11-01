using System.Diagnostics;

namespace MemoriaEstaticaDinamica;

/// <summary>
/// Compara el tiempo y la memoria de distintas formas de guardar N enteros.
/// </summary>
public static class PruebaDesempeno
{
    public static List<string> Ejecutar(int n)
    {
        var r = new List<string>();
        var cronometro = new Stopwatch();

        r.Add($"=== Prueba con N = {n:N0} elementos ===");
        r.Add("");

        // 1) Arreglo de tamaño fijo: se reserva una sola vez.
        long base1 = GC.GetTotalMemory(true);
        cronometro.Restart();
        int[] fijo = new int[n];
        for (int i = 0; i < n; i++) fijo[i] = i;
        cronometro.Stop();
        long mem1 = GC.GetTotalMemory(true) - base1;
        double t1 = cronometro.Elapsed.TotalMilliseconds;
        GC.KeepAlive(fijo);

        r.Add("1) Arreglo de tamaño fijo (una sola reserva)");
        r.Add($"   Tiempo: {t1:F2} ms   Memoria: {mem1 / 1024.0:F1} KB");
        r.Add("");

        // 2) Arreglo que crece de 1 en 1: cada inserción crea y copia un arreglo nuevo.
        cronometro.Restart();
        int[] creceUno = new int[0];
        for (int i = 0; i < n; i++)
        {
            Array.Resize(ref creceUno, creceUno.Length + 1);
            creceUno[i] = i;
        }
        cronometro.Stop();

        r.Add("2) Arreglo que crece de 1 en 1 (Array.Resize en cada inserción)");
        r.Add($"   Tiempo: {cronometro.Elapsed.TotalMilliseconds:F2} ms");
        r.Add("");

        // 3) Arreglo que duplica su capacidad cuando se llena (como List<T>).
        cronometro.Restart();
        int[] duplica = new int[1];
        int usados = 0;
        for (int i = 0; i < n; i++)
        {
            if (usados == duplica.Length)
                Array.Resize(ref duplica, duplica.Length * 2);
            duplica[usados] = i;
            usados++;
        }
        cronometro.Stop();

        r.Add("3) Arreglo que duplica su capacidad al llenarse");
        r.Add($"   Tiempo: {cronometro.Elapsed.TotalMilliseconds:F2} ms");
        r.Add("");

        // 4) Lista enlazada: un objeto Nodo por elemento en el Heap.
        long base4 = GC.GetTotalMemory(true);
        cronometro.Restart();
        ListaEnlazada lista = new ListaEnlazada();
        for (int i = 0; i < n; i++) lista.AgregarAlFinal(i);
        cronometro.Stop();
        long mem4 = GC.GetTotalMemory(true) - base4;
        double t4 = cronometro.Elapsed.TotalMilliseconds;
        GC.KeepAlive(lista);

        r.Add("4) Lista enlazada (un objeto Nodo por elemento)");
        r.Add($"   Tiempo: {t4:F2} ms   Memoria: {mem4 / 1024.0:F1} KB");
        r.Add("");

        // 5) Acceso por posición al elemento central, repetido 1000 veces.
        const int lecturas = 1000;
        long suma = 0;

        cronometro.Restart();
        for (int k = 0; k < lecturas; k++) suma += fijo[n / 2];
        cronometro.Stop();
        double tArreglo = cronometro.Elapsed.TotalMilliseconds * 1000;

        cronometro.Restart();
        for (int k = 0; k < lecturas; k++) suma += lista.ObtenerEn(n / 2);
        cronometro.Stop();
        double tLista = cronometro.Elapsed.TotalMilliseconds * 1000;

        r.Add($"5) Acceso al elemento central ({lecturas} lecturas)");
        r.Add($"   Arreglo: {tArreglo:F1} µs   Lista enlazada: {tLista:F1} µs   (control: {suma})");
        r.Add("");

        r.Add("--- Qué observar ---");
        r.Add("* El arreglo fijo es compacto y su acceso por índice es inmediato.");
        r.Add("* Crecer de 1 en 1 es muy costoso: cada paso copia todo el arreglo.");
        r.Add("* Duplicar la capacidad reduce mucho los copiados (costo amortizado).");
        r.Add("* La lista inserta sin copiar, pero usa más memoria por nodo y");
        r.Add("  acceder por posición obliga a recorrer los nodos.");

        return r;
    }
}
