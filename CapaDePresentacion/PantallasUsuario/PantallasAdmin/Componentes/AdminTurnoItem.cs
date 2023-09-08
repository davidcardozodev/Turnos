using CapaDeNegocio;
using CapaDePresentacion.PantallaTurno;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    public partial class AdminTurnoItem : UserControl
    {
        public AdminTurnoItem()
        {
            InitializeComponent();
        }

        #region "Atributos"

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string DiaNombre { get; set; }
        public string DiaNumero { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string NombreProveedor { get; set; }

        #endregion

        private void AdminTurnoItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
            CambiarColorEstado();
        }

        private void CargarInformacion()
        {
            lblEstado.Text = Estado;

            string Espacio = "      ";

            lblInformacion.Text = Nombre + Espacio + DiaNombre + " " + DiaNumero + " " + Mes + " " + Anio + Espacio + Hora + ":00hs";
        }

        private void linkVerMas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TurnoDetalle turnoDetalle = new TurnoDetalle();

            turnoDetalle.Id = Id;
            turnoDetalle.IdCliente = IdCliente;
            turnoDetalle.DiaNombre = DiaNombre;
            turnoDetalle.DiaNumero = DiaNumero;
            turnoDetalle.Mes = Mes;
            turnoDetalle.Anio = Anio;
            turnoDetalle.Hora = Hora;
            turnoDetalle.Descripcion = Descripcion;
            turnoDetalle.Estado = Estado;
            turnoDetalle.Usuario = Usuario;
            turnoDetalle.Nombre = Nombre;
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

        private void AdminTurnoItem_MouseEnter(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.CambiarColor();
        }

        private void AdminTurnoItem_MouseLeave(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.RestaurarColor();
        }
    }
}
