using CapaDeEntidades;
using CapaDeNegocio;
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
        public string Nombre { get; set; }
        public string TipoPlan { get; set; }
        private string Prioridad;
        public string Lugar { get; set; }

        #endregion

        private void CargarInformacion()
        {
            lblCliente.Text = Nombre;
            EstablecerPrioridad();
        }

        private void EstablecerPrioridad()
        {
            SelectorColor selectorColor = new SelectorColor();

            switch (TipoPlan)
            {
                case Plan.Basico:
                    Prioridad = Prioridades.Baja;
                    lblPrioridad.ForeColor = selectorColor.Verde();
                    break;

                case Plan.Estandar:
                    Prioridad = Prioridades.Media;
                    lblPrioridad.ForeColor = selectorColor.Naranja();
                    break;

                case Plan.Premium:
                    Prioridad = Prioridades.Alta;
                    lblPrioridad.ForeColor = selectorColor.Rojo();
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

        private void ProveedorTurnoLlamadorAsignado_MouseEnter(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.CambiarColor();
        }

        private void ProveedorTurnoLlamadorAsignado_MouseLeave(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.RestaurarColor();
        }

    }
}
