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
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            dtpFecha = new DateTimePicker();
            cmbProducto = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            nudCantidad = new NumericUpDown();
            mtbPrecioUnitario = new MaskedTextBox();
            lblResultadoRegistro = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.White;
            lblFecha.Location = new Point(60, 59);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BackColor = Color.White;
            lblProducto.Location = new Point(60, 104);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.White;
            lblCantidad.Location = new Point(60, 155);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.BackColor = Color.White;
            lblPrecioUnitario.Location = new Point(60, 225);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(85, 15);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "";
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(205, 59);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(101, 23);
            dtpFecha.TabIndex = 4;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(205, 104);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 5;
            cmbProducto.TextChanged += cmbProducto_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Location = new Point(505, 292);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(144, 34);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(332, 292);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 34);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(205, 155);
            nudCantidad.Margin = new Padding(3, 2, 3, 2);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(131, 23);
            nudCantidad.TabIndex = 10;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Enabled = false;
            mtbPrecioUnitario.Location = new Point(204, 226);
            mtbPrecioUnitario.Margin = new Padding(3, 2, 3, 2);
            mtbPrecioUnitario.Mask = "0";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(110, 23);
            mtbPrecioUnitario.TabIndex = 11;
            mtbPrecioUnitario.MaskInputRejected += mtbPrecioUnitario_MaskInputRejected;
            // 
            // lblResultadoRegistro
            // 
            lblResultadoRegistro.BackColor = Color.White;
            lblResultadoRegistro.ForeColor = SystemColors.ActiveCaptionText;
            lblResultadoRegistro.Location = new Point(60, 393);
            lblResultadoRegistro.Name = "lblResultadoRegistro";
            lblResultadoRegistro.Size = new Size(444, 38);
            lblResultadoRegistro.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoRegistro);
            Controls.Add(mtbPrecioUnitario);
            Controls.Add(nudCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbProducto);
            Controls.Add(dtpFecha);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "Form1";
            Text = "Form1";
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
        private Button btnAceptar;
        private Button btnCancelar;
        private NumericUpDown nudCantidad;
        private MaskedTextBox mtbPrecioUnitario;
        private Label lblResultadoRegistro;
    }
}
