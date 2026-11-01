# Tarea 1.2 – Memoria estática vs. memoria dinámica

Práctica de la materia **Estructuras de Datos** (Unidad 1).
Aplicación de escritorio en **C# / Windows Forms (.NET 10)** que muestra, en tres pestañas, la diferencia entre guardar datos en un arreglo (bloque contiguo de tamaño fijo) y en objetos enlazados dinámicamente en el Heap.

## Contenido de la aplicación

| Pestaña | Qué demuestra |
|---|---|
| 1. Arreglo (redimensionar) | Crea un arreglo en tiempo de ejecución y lo redimensiona. Muestra que el arreglo cambia de identidad: se reserva un bloque nuevo y se copian los datos. |
| 2. Memoria dinámica (Heap) | Lista enlazada: cada elemento es un objeto `Nodo` creado con `new`, conectado por referencias. Permite agregar, eliminar y liberar con el recolector de basura. |
| 3. Comparación de desempeño | Mide con `Stopwatch` y `GC.GetTotalMemory` el tiempo y la memoria de: arreglo fijo, arreglo que crece de 1 en 1, arreglo que duplica su capacidad y lista enlazada; además compara el acceso por posición. |

## Estructura del código

```
MemoriaEstaticaDinamica/
├── Program.cs                 Punto de entrada
├── Form1.cs                   Lógica de eventos de la interfaz
├── Form1.Designer.cs          Controles creados en el diseñador de Visual Studio
├── VectorRedimensionable.cs   Arreglo con redimensionamiento manual (Array.Copy)
├── Nodo.cs                    Nodo de la lista (objeto en el Heap)
├── ListaEnlazada.cs           Lista enlazada simple con referencias
└── PruebaDesempeno.cs         Pruebas de tiempo y memoria
```

## Cómo ejecutarlo

1. Abre `MemoriaEstaticaDinamica.sln` con Visual Studio 2022 (17.14 o superior) o Visual Studio 2026.
2. Para ver el diseño, abre `Form1.cs` en el diseñador.
3. Ejecuta con **F5**. Para las mediciones de la pestaña 3 usa **Release** y **Ctrl+F5**.

Si tu Visual Studio no tiene .NET 10, cambia en `MemoriaEstaticaDinamica.csproj` la línea
`<TargetFramework>net10.0-windows</TargetFramework>` por `net8.0-windows`.

## Autor

- Nombre: [Tu nombre]
- Grupo: [Tu grupo]
- Materia: Estructuras de Datos

## Subir el proyecto a GitHub

```bash
git init
git add .
git commit -m "Tarea 1.2: memoria estática vs. dinámica"
git branch -M main
git remote add origin https://github.com/TU_USUARIO/TU_REPOSITORIO.git
git push -u origin main
```
