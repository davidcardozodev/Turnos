using CapaDePresentacion.PantallaTurno;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes
{
    public partial class ProveedorTurnoItem : UserControl
    {
        public ProveedorTurnoItem()
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
        public string Usuario { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }

        private void CargarInformacion()
        {
            lblDiaNombre.Text = DiaNombre;
            lblDiaNumero.Text = DiaNumero;
            lblHora.Text = Hora + ":00hs";
            lblCliente.Text = PrimerNombre + " " + SegundoNombre;
        }

        private void ProveedorTurnoItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
        }

        private void linkVerMas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TurnoDetalle turnoDetalle = new TurnoDetalle();


            turnoDetalle.Id = Id;
            turnoDetalle.DiaNombre = DiaNombre;
            turnoDetalle.DiaNumero = DiaNumero;
            turnoDetalle.Mes = Mes;
            turnoDetalle.Anio = Anio;
            turnoDetalle.Hora = Hora;
            turnoDetalle.Descripcion = Descripcion;
            turnoDetalle.Estado = Estado;
            turnoDetalle.Usuario = Usuario;
            turnoDetalle.PrimerNombre = PrimerNombre;
            turnoDetalle.SegundoNombre = SegundoNombre;

            turnoDetalle.Show();
        }
    }
}
