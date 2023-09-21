using CapaDeNegocio;
using CapaDePresentacion.PantallaTurno;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasCliente.Componentes
{
    public partial class ClienteTurnoItem : UserControl
    {
        public ClienteTurnoItem()
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
        public string NombreProveedor { get; set; }

        #endregion

        private void ClienteTurnoItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
            CambiarColorEstado();
        }

        private void CargarInformacion()
        {
            lblEstado.Text = Estado;
            lblFecha.Text = DiaNombre + Campo.EspacioSimple + DiaNumero + Campo.De + Mes + Campo.De + Anio;
            lblHora.Text = Hora + Campo.Hora;
        }

        private void AbrirTurno()
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
            turnoDetalle.NombreProveedor = NombreProveedor;

            turnoDetalle.Show();
        }

        private void CambiarColorEstado()
        {
            SelectorColor selectorColor = new SelectorColor();

            switch (Estado)
            {
                case Estados.Cancelado:
                    lblEstado.ForeColor = selectorColor.Rojo();
                    break;
                case Estados.Finalizado:
                    lblEstado.ForeColor = selectorColor.Verde();
                    break;
                case Estados.Pendiente:
                case Estados.Asignado:
                case Estados.EnCurso:
                    lblEstado.ForeColor = selectorColor.Azul();
                    break;
            }
        }

        private void ClienteTurnoItem_MouseEnter(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.CambiarColor();
        }

        private void ClienteTurnoItem_MouseLeave(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.RestaurarColor();
        }

        private void ClienteTurnoItem_Click(object sender, System.EventArgs e)
        {
            AbrirTurno();
        }
    }
}
