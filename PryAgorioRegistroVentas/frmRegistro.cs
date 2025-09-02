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
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            vFecha = dtpFecha.Value;
            vProducto = cmbProducto.Text;
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            vPrecio = Convert.ToInt32(mtbPrecioUnitario.Text);




            lblResultadoRegistro.Text = vFecha + "" + vProducto + "" + vCantidad + "" + vPrecio;

        }
    }
}
