using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using CapaDePresentacion.PantallaTurno;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes
{
    public partial class ProveedorTurnoItem : UserControl
    {
        public ProveedorTurnoItem()
        {
            InitializeComponent();
        }

        #region "Atributos"

        public int Id { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string PresenciaEstado { get; set; }
        public string TipoPlan { get; set; }

        #endregion

        private void CargarInformacion()
        {
            string Espacio = "      ";

            Hora += ":00hs";

            lblPresencia.Text = PresenciaEstado;

            lblInformacion.Text = Nombre + Espacio + Hora + Espacio + TipoPlan;
        }

        private void ProveedorTurnoItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
            CambiarColorPresencia();
            ActivarOpcionAsignar();
        }

        private void ActivarOpcionAsignar()
        {
            if (PresenciaEstado == Presencia.Presente)
                btnAsignar.Enabled = true;
        }

        private void linkVerMas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TurnoDetalle turnoDetalle = new TurnoDetalle();

            turnoDetalle.Id = Id;
            turnoDetalle.Hora = Hora;
            turnoDetalle.Descripcion = Descripcion;
            turnoDetalle.Estado = Estado;
            turnoDetalle.Usuario = Usuario;
            turnoDetalle.Nombre = Nombre;
            turnoDetalle.Presencia = PresenciaEstado;

            turnoDetalle.Show();
        }


        private void CambiarColorPresencia()
        {
            switch (PresenciaEstado)
            {
                case Presencia.Ausente:
                    lblPresencia.ForeColor = Color.FromArgb(255, 0, 0);
                    break;

                case Presencia.Presente:
                    lblPresencia.ForeColor = Color.FromArgb(0, 255, 0);
                    break;
            }
        }

        private void btnAsignar_Click(object sender, System.EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorAsignar(DatosUsuario.Id, Id);

            (Application.OpenForms["ProveedorTurnosVista"] as ProveedorTurnosVista).CargarTurnoItem();

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void ProveedorTurnoItem_MouseEnter(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.CambiarColor();
        }

        private void ProveedorTurnoItem_MouseLeave(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.RestaurarColor();
        }
    }
}
