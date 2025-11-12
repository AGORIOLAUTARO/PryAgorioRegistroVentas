namespace PryAgorioRegistroVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime vFecha;
        string vProducto;
        int vCantidad;
        int vPrecio;
        int indice = 0;

        //Declaración struct
        public struct datoVentas
        {
            public DateTime Fecha;
            public string Producto;
            public int Cantidad;
            public int Precio;
        }

        //Declaración de array principal
        public datoVentas[] vecProductos = new datoVentas[100];

        private void cmbProducto_TextChanged(object sender, EventArgs e)
        {
            if (cmbProducto.Text != "")
            {
                nudCantidad.Enabled = true;
            }
            else
            {
                nudCantidad.Enabled = false;

            }

        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value > 0)
            {
                mtbPrecioUnitario.Enabled = true;
            }
            else
            {
                mtbPrecioUnitario.Enabled = false;
            }
        }

        private void mtbPrecioUnitario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if ((mtbPrecioUnitario.Text.Any(char.IsDigit)))
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cargar los productos que van a aparecer en el combo box
            cmbProducto.Items.Add("Gabinete");
            cmbProducto.Items.Add("RAM");
            cmbProducto.Items.Add("CPU");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //esto limpia todos los elementos cargados en el form para arrancar de 0 y cargar algo nuevo
            dtpFecha.Value = DateTime.Now;
            cmbProducto.Text = "";
            cmbProducto.SelectedIndex = -1;
            nudCantidad.Value = 0;
            mtbPrecioUnitario.Text = "";

        }
        private void mtbPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validamos que el array no este lleno
            if (indice >= vecProductos.Length)
            {
                MessageBox.Show("El array se encuentra lleno, no se puede grabar más datos.", "Array lleno",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRegistrar.Enabled = false;

            }

            //Otorgo valor a variables             
            vFecha = dtpFecha.Value;
            vProducto = cmbProducto.Text;
            //cmbProducto.SelectedItem
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            //otra manera es: vCantidad = intParce(nudCantidad.Value.ToString));
            vPrecio = Convert.ToInt32(mtbPrecioUnitario.Text);

            //Gabro datos en array
            vecProductos[indice].Fecha = dtpFecha.Value;
            vecProductos[indice].Producto = vProducto;
            vecProductos[indice].Cantidad = vCantidad;
            vecProductos[indice].Precio = vPrecio;
            indice++;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Mostrar los resultados       


            lstResultado.Items.Add("Fecha: " + vFecha);
            lstResultado.Items.Add("Producto: " + vProducto);
            lstResultado.Items.Add("Cantidad: " + vCantidad);
            lstResultado.Items.Add("Precio: $ " + vPrecio);
        }
    }
}
