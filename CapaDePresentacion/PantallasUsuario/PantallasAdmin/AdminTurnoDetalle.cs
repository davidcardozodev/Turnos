using CapaDeEntidades;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminTurnoDetalle : Form
    {
        public AdminTurnoDetalle()
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

        private void AdminTurnoDetalle_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            lblFecha.Text = DiaNombre + " " + DiaNumero + ", " + Mes + ", " + Anio;
            lblUsuario.Text = PrimerNombre + " " + SegundoNombre + " (" + Usuario + ")";
            lblHora.Text = Hora;
            rtxtDecripcion.Text = Descripcion;
            lblEstado.Text = Estado;
        }

        private void btnDarDeBaja_Click(object sender, System.EventArgs e)
        {
            Admin admin = new Admin();

            admin.TurnoDarBaja(Id);
        }
    }
}
