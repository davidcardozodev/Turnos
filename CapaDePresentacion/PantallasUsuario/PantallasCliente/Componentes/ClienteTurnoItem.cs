using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasCliente.Componentes
{
    public partial class ClienteTurnoItem : UserControl
    {
        public ClienteTurnoItem()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string DiaNombre { get; set; }
        public string DiaNumero { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
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

        private void picOpciones_Click(object sender, System.EventArgs e)
        {
            ClienteTurnoDetalle clienteTurnoDetalle = new ClienteTurnoDetalle();

            clienteTurnoDetalle.Id = Id;
            clienteTurnoDetalle.DiaNombre = DiaNombre;
            clienteTurnoDetalle.DiaNumero = DiaNumero;
            clienteTurnoDetalle.Mes = Mes;
            clienteTurnoDetalle.Anio = Anio;
            clienteTurnoDetalle.Hora = Hora;
            clienteTurnoDetalle.Descripcion = Descripcion;
            clienteTurnoDetalle.Estado = Estado;

            clienteTurnoDetalle.Show();
        }
    }
}
