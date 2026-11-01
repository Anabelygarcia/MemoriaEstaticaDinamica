#nullable disable
namespace MemoriaEstaticaDinamica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabVector = new TabPage();
            tabLista = new TabPage();
            tabDesempeno = new TabPage();
            lblTamano = new Label();
            nudTamano = new NumericUpDown();
            btnCrear = new Button();
            lblNuevoTamano = new Label();
            nudNuevoTamano = new NumericUpDown();
            btnRedimensionar = new Button();
            lblInfoVector = new Label();
            lstVector = new ListBox();
            lblMensajeVector = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            btnInicio = new Button();
            btnFinal = new Button();
            btnEliminar = new Button();
            btnVaciarLista = new Button();
            lblInfoLista = new Label();
            lstLista = new ListBox();
            lblMensajeLista = new Label();
            lblN = new Label();
            nudN = new NumericUpDown();
            btnEjecutar = new Button();
            txtResultados = new TextBox();
            lblNota = new Label();
            tabControl1.SuspendLayout();
            tabVector.SuspendLayout();
            tabLista.SuspendLayout();
            tabDesempeno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTamano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNuevoTamano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudN).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabVector);
            tabControl1.Controls.Add(tabLista);
            tabControl1.Controls.Add(tabDesempeno);
            tabControl1.Location = new Point(12, 12);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(616, 476);
            tabControl1.Name = "tabControl1";
            tabControl1.TabIndex = 0;
            // 
            // tabVector
            // 
            tabVector.Controls.Add(lblTamano);
            tabVector.Controls.Add(nudTamano);
            tabVector.Controls.Add(btnCrear);
            tabVector.Controls.Add(lblNuevoTamano);
            tabVector.Controls.Add(nudNuevoTamano);
            tabVector.Controls.Add(btnRedimensionar);
            tabVector.Controls.Add(lblInfoVector);
            tabVector.Controls.Add(lstVector);
            tabVector.Controls.Add(lblMensajeVector);
            tabVector.Location = new Point(4, 24);
            tabVector.Padding = new Padding(3);
            tabVector.Size = new Size(608, 448);
            tabVector.Text = "1. Arreglo (redimensionar)";
            tabVector.UseVisualStyleBackColor = true;
            tabVector.Name = "tabVector";
            // 
            // tabLista
            // 
            tabLista.Controls.Add(lblValor);
            tabLista.Controls.Add(txtValor);
            tabLista.Controls.Add(btnInicio);
            tabLista.Controls.Add(btnFinal);
            tabLista.Controls.Add(btnEliminar);
            tabLista.Controls.Add(btnVaciarLista);
            tabLista.Controls.Add(lblInfoLista);
            tabLista.Controls.Add(lstLista);
            tabLista.Controls.Add(lblMensajeLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(608, 448);
            tabLista.Text = "2. Memoria dinámica (Heap)";
            tabLista.UseVisualStyleBackColor = true;
            tabLista.Name = "tabLista";
            // 
            // tabDesempeno
            // 
            tabDesempeno.Controls.Add(lblN);
            tabDesempeno.Controls.Add(nudN);
            tabDesempeno.Controls.Add(btnEjecutar);
            tabDesempeno.Controls.Add(txtResultados);
            tabDesempeno.Controls.Add(lblNota);
            tabDesempeno.Location = new Point(4, 24);
            tabDesempeno.Padding = new Padding(3);
            tabDesempeno.Size = new Size(608, 448);
            tabDesempeno.Text = "3. Comparación de desempeño";
            tabDesempeno.UseVisualStyleBackColor = true;
            tabDesempeno.Name = "tabDesempeno";
            // 
            // lblTamano
            // 
            lblTamano.AutoSize = true;
            lblTamano.Location = new Point(15, 22);
            lblTamano.Size = new Size(90, 15);
            lblTamano.Text = "Tamaño inicial:";
            lblTamano.Name = "lblTamano";
            lblTamano.TabIndex = 0;
            // 
            // nudTamano
            // 
            nudTamano.Location = new Point(125, 18);
            nudTamano.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            nudTamano.Minimum = new decimal(new int[] {1, 0, 0, 0});
            nudTamano.Size = new Size(70, 23);
            nudTamano.Value = new decimal(new int[] {5, 0, 0, 0});
            nudTamano.Name = "nudTamano";
            nudTamano.TabIndex = 1;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(215, 14);
            btnCrear.Size = new Size(160, 30);
            btnCrear.Text = "Crear arreglo";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            btnCrear.Name = "btnCrear";
            btnCrear.TabIndex = 2;
            // 
            // lblNuevoTamano
            // 
            lblNuevoTamano.AutoSize = true;
            lblNuevoTamano.Location = new Point(15, 62);
            lblNuevoTamano.Size = new Size(90, 15);
            lblNuevoTamano.Text = "Nuevo tamaño:";
            lblNuevoTamano.Name = "lblNuevoTamano";
            lblNuevoTamano.TabIndex = 3;
            // 
            // nudNuevoTamano
            // 
            nudNuevoTamano.Location = new Point(125, 58);
            nudNuevoTamano.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            nudNuevoTamano.Minimum = new decimal(new int[] {1, 0, 0, 0});
            nudNuevoTamano.Size = new Size(70, 23);
            nudNuevoTamano.Value = new decimal(new int[] {8, 0, 0, 0});
            nudNuevoTamano.Name = "nudNuevoTamano";
            nudNuevoTamano.TabIndex = 4;
            // 
            // btnRedimensionar
            // 
            btnRedimensionar.Location = new Point(215, 54);
            btnRedimensionar.Size = new Size(160, 30);
            btnRedimensionar.Text = "Redimensionar";
            btnRedimensionar.UseVisualStyleBackColor = true;
            btnRedimensionar.Click += btnRedimensionar_Click;
            btnRedimensionar.Name = "btnRedimensionar";
            btnRedimensionar.TabIndex = 5;
            // 
            // lblInfoVector
            // 
            lblInfoVector.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoVector.Location = new Point(15, 100);
            lblInfoVector.Size = new Size(575, 20);
            lblInfoVector.Text = "Información del arreglo";
            lblInfoVector.Name = "lblInfoVector";
            lblInfoVector.TabIndex = 6;
            // 
            // lstVector
            // 
            lstVector.FormattingEnabled = true;
            lstVector.ItemHeight = 15;
            lstVector.Location = new Point(15, 125);
            lstVector.Size = new Size(575, 229);
            lstVector.Name = "lstVector";
            lstVector.TabIndex = 7;
            // 
            // lblMensajeVector
            // 
            lblMensajeVector.Location = new Point(15, 362);
            lblMensajeVector.Size = new Size(575, 60);
            lblMensajeVector.Text = "Mensaje";
            lblMensajeVector.Name = "lblMensajeVector";
            lblMensajeVector.TabIndex = 8;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(15, 22);
            lblValor.Size = new Size(36, 15);
            lblValor.Text = "Valor:";
            lblValor.Name = "lblValor";
            lblValor.TabIndex = 0;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(60, 18);
            txtValor.MaxLength = 9;
            txtValor.Size = new Size(100, 23);
            txtValor.Name = "txtValor";
            txtValor.TabIndex = 1;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(175, 14);
            btnInicio.Size = new Size(130, 30);
            btnInicio.Text = "Agregar al inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            btnInicio.Name = "btnInicio";
            btnInicio.TabIndex = 2;
            // 
            // btnFinal
            // 
            btnFinal.Location = new Point(315, 14);
            btnFinal.Size = new Size(130, 30);
            btnFinal.Text = "Agregar al final";
            btnFinal.UseVisualStyleBackColor = true;
            btnFinal.Click += btnFinal_Click;
            btnFinal.Name = "btnFinal";
            btnFinal.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(455, 14);
            btnEliminar.Size = new Size(135, 30);
            btnEliminar.Text = "Eliminar primero";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.TabIndex = 4;
            // 
            // btnVaciarLista
            // 
            btnVaciarLista.Location = new Point(15, 54);
            btnVaciarLista.Size = new Size(200, 30);
            btnVaciarLista.Text = "Vaciar lista y liberar (GC)";
            btnVaciarLista.UseVisualStyleBackColor = true;
            btnVaciarLista.Click += btnVaciarLista_Click;
            btnVaciarLista.Name = "btnVaciarLista";
            btnVaciarLista.TabIndex = 5;
            // 
            // lblInfoLista
            // 
            lblInfoLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoLista.Location = new Point(15, 100);
            lblInfoLista.Size = new Size(575, 20);
            lblInfoLista.Text = "Información de la lista";
            lblInfoLista.Name = "lblInfoLista";
            lblInfoLista.TabIndex = 6;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.ItemHeight = 15;
            lstLista.Location = new Point(15, 125);
            lstLista.Size = new Size(575, 229);
            lstLista.Name = "lstLista";
            lstLista.TabIndex = 7;
            // 
            // lblMensajeLista
            // 
            lblMensajeLista.Location = new Point(15, 362);
            lblMensajeLista.Size = new Size(575, 60);
            lblMensajeLista.Text = "Mensaje";
            lblMensajeLista.Name = "lblMensajeLista";
            lblMensajeLista.TabIndex = 8;
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Location = new Point(15, 22);
            lblN.Size = new Size(170, 15);
            lblN.Text = "Cantidad de elementos (N):";
            lblN.Name = "lblN";
            lblN.TabIndex = 0;
            // 
            // nudN
            // 
            nudN.Location = new Point(200, 18);
            nudN.Increment = new decimal(new int[] {1000, 0, 0, 0});
            nudN.Maximum = new decimal(new int[] {50000, 0, 0, 0});
            nudN.Minimum = new decimal(new int[] {1000, 0, 0, 0});
            nudN.Size = new Size(90, 23);
            nudN.Value = new decimal(new int[] {10000, 0, 0, 0});
            nudN.Name = "nudN";
            nudN.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(310, 14);
            btnEjecutar.Size = new Size(160, 30);
            btnEjecutar.Text = "Ejecutar prueba";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.TabIndex = 2;
            // 
            // txtResultados
            // 
            txtResultados.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultados.Location = new Point(15, 60);
            txtResultados.Multiline = true;
            txtResultados.ReadOnly = true;
            txtResultados.ScrollBars = ScrollBars.Vertical;
            txtResultados.Size = new Size(575, 350);
            txtResultados.Name = "txtResultados";
            txtResultados.TabIndex = 3;
            // 
            // lblNota
            // 
            lblNota.Location = new Point(15, 416);
            lblNota.Size = new Size(575, 20);
            lblNota.Text = "Nota: para mediciones más fiables ejecuta en modo Release (Ctrl+F5).";
            lblNota.Name = "lblNota";
            lblNota.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 500);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memoria estática vs. dinámica - Tarea 1.2";
            tabVector.ResumeLayout(false);
            tabVector.PerformLayout();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabDesempeno.ResumeLayout(false);
            tabDesempeno.PerformLayout();
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudTamano).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNuevoTamano).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabVector;
        private TabPage tabLista;
        private TabPage tabDesempeno;
        private Label lblTamano;
        private NumericUpDown nudTamano;
        private Button btnCrear;
        private Label lblNuevoTamano;
        private NumericUpDown nudNuevoTamano;
        private Button btnRedimensionar;
        private Label lblInfoVector;
        private ListBox lstVector;
        private Label lblMensajeVector;
        private Label lblValor;
        private TextBox txtValor;
        private Button btnInicio;
        private Button btnFinal;
        private Button btnEliminar;
        private Button btnVaciarLista;
        private Label lblInfoLista;
        private ListBox lstLista;
        private Label lblMensajeLista;
        private Label lblN;
        private NumericUpDown nudN;
        private Button btnEjecutar;
        private TextBox txtResultados;
        private Label lblNota;
    }
}
