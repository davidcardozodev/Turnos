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

        private void UsuarioItem_Load(object sender, System.EventArgs e)
        {
            lblUsuario.Text = Usuario;
            lblNombre.Text = PrimerNombre;
            lblApellido.Text = SegundoNombre;
            lblEmail.Text = Email;
            lblRol.Text = Rol;
        }
    }
}
