using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
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
            OcultarOpcionFinalizar();
        }

        private void OcultarOpcionFinalizar()
        {
            if (DatosUsuario.Rol == Rol.Llamador)
                btnFinalizar.Visible = false;
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
        public string Nombre { get; set; }

        #endregion

        private void CargarInformacion()
        {
            lblCliente.Text = Nombre;
        }

        private void btnFinalizar_Click(object sender, System.EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorFinalizarTurno(Id);

            (Application.OpenForms["ProveedorLlamador"] as ProveedorLlamador).ActualizarTurnos();
        }
    }
}
