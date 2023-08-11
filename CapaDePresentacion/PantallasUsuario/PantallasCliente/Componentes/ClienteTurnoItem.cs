using System.Drawing;
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
        public string NombreProveedor { get; set; }


        private void ClienteTurnoItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
            CambiarColorEstado();
        }

        private void CargarInformacion()
        {
            lblDiaNombre.Text = DiaNombre;
            lblDiaNumero.Text = DiaNumero;
            lblHora.Text = Hora + ":00hs";
            lblDescripcion.Text = Descripcion;
            lblEstado.Text = Estado;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            clienteTurnoDetalle.NombreProveedor = NombreProveedor;

            clienteTurnoDetalle.Show();
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
