using System.Runtime.CompilerServices;

namespace MemoriaEstaticaDinamica
{
    public partial class Form1 : Form
    {
        private VectorRedimensionable? _vector;                       // arreglo (bloque contiguo)
        private readonly ListaEnlazada _lista = new ListaEnlazada();  // nodos dispersos en el Heap
        private readonly Random _aleatorio = new Random();

        public Form1()
        {
            InitializeComponent();
            MostrarVector();
            ActualizarLista();
        }

        // ---------------------------------------------------------------
        // PESTAÑA 1: arreglo que se crea y se redimensiona en ejecución
        // ---------------------------------------------------------------

        private void btnCrear_Click(object? sender, EventArgs e)
        {
            _vector = new VectorRedimensionable((int)nudTamano.Value);
            _vector.LlenarAleatorio(_aleatorio);
            MostrarVector();
            MostrarMensaje(lblMensajeVector, $"Se creó un arreglo de {_vector.Tamano} elementos con valores aleatorios.", false);
        }

        private void btnRedimensionar_Click(object? sender, EventArgs e)
        {
            if (_vector == null)
            {
                MostrarMensaje(lblMensajeVector, "Primero crea un arreglo.", true);
                return;
            }

            int tamanoAntes = _vector.Tamano;
            int identidadAntes = _vector.Identidad;

            _vector.Redimensionar((int)nudNuevoTamano.Value);
            MostrarVector();

            MostrarMensaje(lblMensajeVector,
                $"Tamaño: {tamanoAntes} -> {_vector.Tamano}. Identidad del objeto: #{identidadAntes} -> #{_vector.Identidad}. " +
                "El arreglo no crece en su lugar: se reservó un bloque nuevo, se copiaron los datos y se descartó el anterior.",
                false);
        }

        private void MostrarVector()
        {
            lstVector.Items.Clear();

            if (_vector == null)
            {
                lblInfoVector.Text = "Aún no hay arreglo. Presiona \"Crear arreglo\".";
                return;
            }

            int[] datos = _vector.ObtenerCopia();
            for (int i = 0; i < datos.Length; i++)
                lstVector.Items.Add($"[{i}] = {datos[i]}");

            lblInfoVector.Text = $"Tamaño: {_vector.Tamano} elementos   |   Identidad del objeto en el Heap: #{_vector.Identidad}";
        }

        // ---------------------------------------------------------------
        // PESTAÑA 2: memoria dinámica con objetos enlazados por referencias
        // ---------------------------------------------------------------

        private void btnInicio_Click(object? sender, EventArgs e)
        {
            if (!LeerValor(out int valor)) return;

            _lista.AgregarAlInicio(valor);
            MostrarMensaje(lblMensajeLista, $"Se creó un nodo nuevo con el valor {valor} al inicio de la lista.", false);
            ActualizarLista();
        }

        private void btnFinal_Click(object? sender, EventArgs e)
        {
            if (!LeerValor(out int valor)) return;

            _lista.AgregarAlFinal(valor);
            MostrarMensaje(lblMensajeLista, $"Se creó un nodo nuevo con el valor {valor} al final de la lista.", false);
            ActualizarLista();
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            try
            {
                int valor = _lista.EliminarPrimero();
                MostrarMensaje(lblMensajeLista, $"Se eliminó el primer nodo (valor {valor}). Sin referencias, el recolector podrá liberarlo.", false);
            }
            catch (InvalidOperationException ex)
            {
                MostrarMensaje(lblMensajeLista, ex.Message, true);
            }

            ActualizarLista();
        }

        private void btnVaciarLista_Click(object? sender, EventArgs e)
        {
            _lista.Vaciar();

            // Se fuerza la recolección solo con fines de demostración.
            GC.Collect();
            GC.WaitForPendingFinalizers();

            MostrarMensaje(lblMensajeLista, "Se soltaron todas las referencias y se ejecutó el recolector de basura.", false);
            ActualizarLista();
        }

        private bool LeerValor(out int valor)
        {
            if (!int.TryParse(txtValor.Text.Trim(), out valor))
            {
                MostrarMensaje(lblMensajeLista, "Escribe un número entero válido.", true);
                txtValor.Focus();
                return false;
            }

            txtValor.Clear();
            txtValor.Focus();
            return true;
        }

        private void ActualizarLista()
        {
            lstLista.Items.Clear();

            foreach (Nodo nodo in _lista.Recorrer())
            {
                string siguiente = nodo.Siguiente == null
                    ? "null"
                    : $"nodo #{RuntimeHelpers.GetHashCode(nodo.Siguiente)}";

                lstLista.Items.Add($"[{nodo.Valor}]   nodo #{RuntimeHelpers.GetHashCode(nodo)}   -> {siguiente}");
            }

            lblInfoLista.Text = $"Nodos: {_lista.Cantidad}   |   Memoria administrada (GC): {GC.GetTotalMemory(false) / 1024} KB";
        }

        // ---------------------------------------------------------------
        // PESTAÑA 3: comparación de desempeño
        // ---------------------------------------------------------------

        private async void btnEjecutar_Click(object? sender, EventArgs e)
        {
            int n = (int)nudN.Value;

            btnEjecutar.Enabled = false;
            Cursor = Cursors.WaitCursor;
            txtResultados.Text = "Ejecutando la prueba, espera un momento...";

            List<string> lineas = await Task.Run(() => PruebaDesempeno.Ejecutar(n));

            txtResultados.Text = string.Join(Environment.NewLine, lineas);
            Cursor = Cursors.Default;
            btnEjecutar.Enabled = true;
        }

        // ---------------------------------------------------------------

        private static void MostrarMensaje(Label etiqueta, string texto, bool esError)
        {
            etiqueta.ForeColor = esError ? Color.Firebrick : Color.SeaGreen;
            etiqueta.Text = texto;
        }
    }
}
