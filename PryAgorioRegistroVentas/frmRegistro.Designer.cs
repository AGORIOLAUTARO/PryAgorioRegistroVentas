namespace PryAgorioRegistroVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            dtpFecha = new DateTimePicker();
            cmbProducto = new ComboBox();
            btnCancelar = new Button();
            nudCantidad = new NumericUpDown();
            mtbPrecioUnitario = new MaskedTextBox();
            btnRegistrar = new Button();
            btnMostrar = new Button();
            lstResultado = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblFecha.Location = new Point(68, 44);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(55, 23);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BackColor = Color.Transparent;
            lblProducto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblProducto.Location = new Point(43, 96);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(80, 23);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblCantidad.Location = new Point(43, 164);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(79, 23);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.BackColor = Color.Transparent;
            lblPrecioUnitario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPrecioUnitario.Location = new Point(16, 231);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(123, 23);
            lblPrecioUnitario.TabIndex = 6;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "";
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(145, 40);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(115, 27);
            dtpFecha.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(145, 96);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(115, 28);
            cmbProducto.TabIndex = 3;
            cmbProducto.TextChanged += cmbProducto_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.GradientActiveCaption;
            btnCancelar.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnCancelar.Location = new Point(145, 489);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 34);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(145, 164);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(67, 27);
            nudCantidad.TabIndex = 5;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Enabled = false;
            mtbPrecioUnitario.Location = new Point(145, 231);
            mtbPrecioUnitario.Mask = "99999";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(67, 27);
            mtbPrecioUnitario.TabIndex = 7;
            mtbPrecioUnitario.ValidatingType = typeof(int);
            mtbPrecioUnitario.MaskInputRejected += mtbPrecioUnitario_MaskInputRejected;
            mtbPrecioUnitario.KeyPress += mtbPrecioUnitario_KeyPress;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.GradientActiveCaption;
            btnRegistrar.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnRegistrar.Location = new Point(16, 298);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(115, 34);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = SystemColors.GradientActiveCaption;
            btnMostrar.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnMostrar.Location = new Point(145, 298);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(115, 34);
            btnMostrar.TabIndex = 9;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(16, 359);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(244, 104);
            lstResultado.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(308, 554);
            Controls.Add(lstResultado);
            Controls.Add(btnMostrar);
            Controls.Add(btnRegistrar);
            Controls.Add(mtbPrecioUnitario);
            Controls.Add(nudCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(cmbProducto);
            Controls.Add(dtpFecha);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VENTA HARDWARE";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private DateTimePicker dtpFecha;
        private ComboBox cmbProducto;
        private Button btnCancelar;
        private NumericUpDown nudCantidad;
        private MaskedTextBox mtbPrecioUnitario;
        private Button btnRegistrar;
        private Button btnMostrar;
        private ListBox lstResultado;
    }
}
