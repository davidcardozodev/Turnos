using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
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
            CargarRoles();
        }

        private void CargarRoles()
        {
            comboRol.Items.Add("Mostrar todo");
            comboRol.Items.Add(Rol.Admin);
            comboRol.Items.Add(Rol.Cliente);
            comboRol.Items.Add(Rol.Proveedor);
            comboRol.SelectedItem = "Mostrar todo";
        }

        private void AdminCargarUsuario()
        {
            Admin admin = new Admin();

            LimpiarLista();

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

        private void AdminCargarUsuarioFiltrado()
        {
            Admin admin = new Admin();

            LimpiarLista();

            List<DatosUsuarioItem> Usuarios = new List<DatosUsuarioItem>();

            Usuarios = admin.AdminCargarUsuarioFiltrado(comboRol.Text);

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

        private void btnVolverAtras_Click(object sender, System.EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }

        private void comboRol_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboRol.Text == "Mostrar todo")
                AdminCargarUsuario();
            else
                AdminCargarUsuarioFiltrado();
        }

        private void LimpiarLista()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
