using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes
{
    public partial class ProveedorTurnoLlamadorEnCurso : UserControl
    {
        public ProveedorTurnoLlamadorEnCurso()
        {
            InitializeComponent();
        }

        private void ProveedorTurnoLlamadorEnCurso_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
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
            lblCliente.Text = PrimerNombre + " " + SegundoNombre;
        }

    }
}
