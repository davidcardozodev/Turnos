using CapaDeEntidades;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes
{
    public partial class ProveedorTurnoLlamadorAsignado : UserControl
    {
        public ProveedorTurnoLlamadorAsignado()
        {
            InitializeComponent();
        }

        #region "Atributos"

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
        public string TipoPlan { get; set; }

        private string Prioridad = "Prioridad: ";

        #endregion

        private void CargarInformacion()
        {
            lblCliente.Text = PrimerNombre + " " + SegundoNombre;
            EstablecerPrioridad();
        }

        private void EstablecerPrioridad()
        {
            switch (TipoPlan)
            {
                case "Basico":
                    Prioridad += "Baja";
                    break;
                case "Estandar":
                    Prioridad += "Media";
                    break;
                case "Premium":
                    Prioridad += "Alta";
                    break;
            }

            lblPrioridad.Text = Prioridad;
        }

        private void ProveedorTurnoLlamador_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
        }

        private void btnAgregarEnCurso_Click(object sender, System.EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorAgregarEnCurso(Id);

            (Application.OpenForms["ProveedorLlamador"] as ProveedorLlamador).ActualizarTurnos();
        }
    }
}
