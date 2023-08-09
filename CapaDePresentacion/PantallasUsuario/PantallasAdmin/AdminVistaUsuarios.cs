using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminVistaUsuarios : Form
    {
        public AdminVistaUsuarios()
        {
            InitializeComponent();
        }
        private void AdminVistaUsuarios_Load(object sender, System.EventArgs e)
        {
            AdminCargarUsuario();
        }

        private void AdminCargarUsuario()
        {
            Admin admin = new Admin();

            List<DatosUsuarioItem> Usuarios = new List<DatosUsuarioItem>();

            Usuarios = admin.AdminCargarUsuario();

            foreach (DatosUsuarioItem Usuario in Usuarios)
            {
                UsuarioItem usuarioItem = new UsuarioItem();

                usuarioItem.Id = Usuario.Id;
                usuarioItem.Usuario = Usuario.Usuario;
                usuarioItem.Clave = Usuario.Clave;
                usuarioItem.PrimerNombre = Usuario.PrimerNombre;
                usuarioItem.SegundoNombre = Usuario.SegundoNombre;
                usuarioItem.Email = Usuario.Email;
                usuarioItem.Rol = Usuario.Rol;

                flowLayoutPanel1.Controls.Add(usuarioItem);
            }
        }
    }
}
