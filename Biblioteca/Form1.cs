namespace Biblioteca
{
    public partial class Form1 : Form
    {
        private List<AreaMuseo> areasMuseo = new List<AreaMuseo>()
        {
            new AreaMuseo("Exposici�n Principal", 40.0m),
            new AreaMuseo("Galer�a de Arte", 55.0m),
            new AreaMuseo("Zona Infantil", 35.0m)
        };

        private int numeroEntrada = 1; // contador para el n�mero de entrada

        public Form1()
        {
            InitializeComponent();
            // Configurar ComboBox de Descuento
            cbDescuento.Items.Add("Adulto (Sin descuento)");
            cbDescuento.Items.Add("Mayor de Edad (50% descuento)");
            cbDescuento.Items.Add("Ni�o (15% descuento)");

            // Configurar ComboBox de �rea
            foreach (var area in areasMuseo)
            {
                cbArea.Items.Add(area.Nombre);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal precioBase = 40; // precio base predeterminado
            decimal descuento = 0;

            // Obtener precio base del �rea seleccionada
            if (cbArea.SelectedItem != null)
            {
                string nombreAreaSeleccionada = cbArea.SelectedItem.ToString();
                precioBase = ObtenerPrecioPorNombreArea(nombreAreaSeleccionada);
            }

            // Calcular descuento
            if (cbDescuento.SelectedIndex == 1) // Mayor de Edad
            {
                descuento = precioBase * 0.5m;
            }
            else if (cbDescuento.SelectedIndex == 2) // Ni�o
            {
                descuento = precioBase * 0.15m;
            }

            // Calcular precio final
            decimal precioFinal = precioBase - descuento;
            tbPrecio.Text = precioFinal.ToString("C");
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            // Obtener la fecha actual
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");

            // Guardar campos en el RichTextBox
            string registro = $"N�mero de Entrada: {numeroEntrada}\n" +
                              $"Descuento: {cbDescuento.SelectedItem}\n" +
                              $"�rea Visitada: {cbArea.SelectedItem}\n" +
                              $"Precio: {tbPrecio.Text}\n" +
                              $"Fecha: {fechaActual}\n\n";

            rtbRegistros.AppendText(registro);

            // Incrementar el n�mero de entrada
            numeroEntrada++;

            // Limpiar campos despu�s de guardar
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cbDescuento.SelectedIndex = -1;
            cbArea.SelectedIndex = -1;
            tbPrecio.Clear();
        }

        private decimal ObtenerPrecioPorNombreArea(string nombreArea)
        {
            foreach (var area in areasMuseo)
            {
                if (area.Nombre == nombreArea)
                {
                    return area.Precio;
                }
            }
            return 0; // Si no se encuentra el �rea, retornar un precio de 0
        }
    }

    public class AreaMuseo
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public AreaMuseo(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}