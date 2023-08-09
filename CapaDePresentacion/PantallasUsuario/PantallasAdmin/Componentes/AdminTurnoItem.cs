using CapaDePresentacion.PantallasUsuario.PantallasCliente;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    public partial class AdminTurnoItem : UserControl
    {
        public AdminTurnoItem()
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

        private void AdminTurnoItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            lblDiaNombre.Text = DiaNombre;
            lblDiaNumero.Text = DiaNumero;
            lblHora.Text = Hora;
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
