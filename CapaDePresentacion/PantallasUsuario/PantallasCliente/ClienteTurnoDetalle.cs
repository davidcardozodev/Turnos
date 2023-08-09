using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasCliente
{
    public partial class ClienteTurnoDetalle : Form
    {
        public ClienteTurnoDetalle()
        {
            InitializeComponent();
        }

        public string DiaNombre { get; set; }
        public string DiaNumero { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        private void ClienteTurnoDetalle_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            lblFecha.Text = DiaNombre + " " + DiaNumero + ", " + Mes + ", " + Anio;
            lblHora.Text = Hora;
            rtxtDecripcion.Text = Descripcion;
            lblEstado.Text = Estado;
        }
    }
}
