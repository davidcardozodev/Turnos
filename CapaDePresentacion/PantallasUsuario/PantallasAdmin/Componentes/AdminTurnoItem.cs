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

        private void AdminTurnoItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
            CambiarColorEstado();
        }

        private void CargarInformacion()
        {
            lblDiaNombre.Text = DiaNombre + " " + DiaNumero;
            lblHora.Text = Hora;
            lblEstado.Text = Estado;
        }

        private void linkVerMas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminTurnoDetalle adminTurnoDetalle = new AdminTurnoDetalle();

            adminTurnoDetalle.Id = Id;
            adminTurnoDetalle.DiaNombre = DiaNombre;
            adminTurnoDetalle.DiaNumero = DiaNumero;
            adminTurnoDetalle.Mes = Mes;
            adminTurnoDetalle.Anio = Anio;
            adminTurnoDetalle.Hora = Hora;
            adminTurnoDetalle.Descripcion = Descripcion;
            adminTurnoDetalle.Estado = Estado;
            adminTurnoDetalle.Usuario = Usuario;
            adminTurnoDetalle.PrimerNombre = PrimerNombre;
            adminTurnoDetalle.SegundoNombre = SegundoNombre;

            adminTurnoDetalle.Show();
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
