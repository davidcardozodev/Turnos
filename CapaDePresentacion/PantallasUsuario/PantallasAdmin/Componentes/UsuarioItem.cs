using CapaDeNegocio;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    public partial class UsuarioItem : UserControl
    {
        public UsuarioItem()
        {
            InitializeComponent();
        }

        #region "Atributos"

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string TipoPlan { get; set; }
        public int HorarioInicio { get; set; }
        public int HorarioFin { get; set; }

        #endregion

        private void UsuarioItem_Load(object sender, System.EventArgs e)
        {
            string Espacio = "      ";

            lblInformacion.Text = Usuario + Espacio + Nombre + Espacio + Email + Espacio + Rol;
        }

        private void linkModificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminVistaUsuarioDetalle adminVistaUsuarioDetalle = new AdminVistaUsuarioDetalle();

            adminVistaUsuarioDetalle.Id = Id;
            adminVistaUsuarioDetalle.Usuario = Usuario;
            adminVistaUsuarioDetalle.Clave = Clave;
            adminVistaUsuarioDetalle.Nombre = Nombre;
            adminVistaUsuarioDetalle.Email = Email;
            adminVistaUsuarioDetalle.RolUsuario = Rol;
            adminVistaUsuarioDetalle.TipoPlan = TipoPlan;
            adminVistaUsuarioDetalle.HorarioInicio = HorarioInicio;
            adminVistaUsuarioDetalle.HorarioFin = HorarioFin;

            adminVistaUsuarioDetalle.Show();
        }

        private void UsuarioItem_MouseEnter(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.CambiarColor();
        }

        private void UsuarioItem_MouseLeave(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.RestaurarColor();
        }
    }
}
