using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    public partial class UsuarioItem : UserControl
    {
        public UsuarioItem()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string TipoPlan { get; set; }

        private void UsuarioItem_Load(object sender, System.EventArgs e)
        {
            string espacio = "      ";

            lblInformacion.Text = Usuario + espacio + PrimerNombre + " " + SegundoNombre + espacio + Email + espacio + Rol;
        }

        private void linkModificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminVistaUsuarioDetalle adminVistaUsuarioDetalle = new AdminVistaUsuarioDetalle();

            adminVistaUsuarioDetalle.Id = Id;
            adminVistaUsuarioDetalle.Usuario = Usuario;
            adminVistaUsuarioDetalle.Clave = Clave;
            adminVistaUsuarioDetalle.PrimerNombre = PrimerNombre;
            adminVistaUsuarioDetalle.SegundoNombre = SegundoNombre;
            adminVistaUsuarioDetalle.Email = Email;
            adminVistaUsuarioDetalle.RolUsuario = Rol;
            adminVistaUsuarioDetalle.TipoPlan = TipoPlan;

            adminVistaUsuarioDetalle.Show();
        }
    }
}
