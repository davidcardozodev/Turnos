using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasCliente.Componentes
{
    public partial class ClienteTurnoItem : UserControl
    {
        public ClienteTurnoItem()
        {
            InitializeComponent();
        }

        public string DiaNombre { get; set; }
        public string DiaNumero { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        private void ClienteTurnoItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            lblDiaNombre.Text = DiaNombre;
            lblDiaNumero.Text = DiaNumero;
            lblHora.Text = Hora;
            lblDescripcion.Text = Descripcion;
            lblEstado.Text = Estado;
        }
    }
}
