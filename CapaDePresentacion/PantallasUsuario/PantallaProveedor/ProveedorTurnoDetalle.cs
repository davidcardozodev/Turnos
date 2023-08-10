using CapaComun;
using CapaDeEntidades;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor
{
    public partial class ProveedorTurnoDetalle : Form
    {
        public ProveedorTurnoDetalle()
        {
            InitializeComponent();
        }

        private void ProveedorTurnoDetalle_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
            CambiarColorEstado();
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
            lblFecha.Text = DiaNombre + " " + DiaNumero + ", " + Mes + ", " + Anio;
            lblUsuario.Text = PrimerNombre + " " + SegundoNombre + " (" + Usuario + ")";
            lblHora.Text = Hora + ":00hs";
            rtxtDecripcion.Text = Descripcion;
            lblEstado.Text = Estado;
        }

        private void btnAsignar_Click(object sender, System.EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorAsignar(DatosUsuario.Id, Id);

            MessageBox.Show("Cambios guardados");
        }

        private void CambiarColorEstado()
        {
            switch (Estado)
            {
                case "Cancelado":
                    lblEstado.ForeColor = Color.FromArgb(255, 0, 0);
                    break;
                case "Finalizado":
                    lblEstado.ForeColor = Color.FromArgb(0, 255, 0);
                    break;
                case "Pendiente":
                case "Asignado":
                case "EnCurso":
                    lblEstado.ForeColor = Color.FromArgb(0, 0, 255);
                    break;
            }
        }

    }
}
