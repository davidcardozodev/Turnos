using CapaComun;
using CapaDePresentacion.PantallaGenerales;
using CapaDePresentacion.PantallasUsuario;
using CapaDePresentacion.PantallasUsuario.PantallasAdmin;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasGenerales
{
    public partial class PantallaGeneralUsuario : Form
    {
        public PantallaGeneralUsuario()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        #region "Cargar Formulario"

        private void AbrirFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form Formulario = new Form();
            Formulario = panelForm.Controls.OfType<MiFormulario>().FirstOrDefault();
            Formulario = CrearFormulario<MiFormulario>(Formulario);
        }

        private Form CrearFormulario<MiFormulario>(Form Formulario) where MiFormulario : Form, new()
        {
            if (Formulario == null)
                Formulario = CargarFormulario<MiFormulario>();
            else
                Formulario.BringToFront();

            return Formulario;
        }

        private Form CargarFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form Formulario = new MiFormulario();

            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;

            panelForm.Controls.Add(Formulario);
            panelForm.Tag = Formulario;

            Formulario.Show();
            Formulario.BringToFront();

            return Formulario;
        }

        #endregion

        private bool _perfil = false;

        #region "Cargar datos principales"

        private void PantallaGeneralUsuario_Load(object sender, EventArgs e)
        {
            CargarNombreUsuario();
            CargarPantallaUsuario();
        }

        private void CargarPantallaUsuario()
        {
            if (DatosUsuario.Rol == Roles.rolCliente)
                AbrirFormulario<ClientePrincipal>();

            if (DatosUsuario.Rol == Roles.rolAdmin)
                AbrirFormulario<AdminPrincipal>();
        }

        #endregion

        #region "Cargar pantalla generica"

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!_perfil)
                CargarPantallaPerfil();
            else
                CerrarPantallaPerfil();
        }

        private void CargarPantallaPerfil()
        {
            AbrirFormulario<Perfil>();
            linkPerfil.Text = "Cerrar perfil";
            _perfil = true;
        }

        private void CerrarPantallaPerfil()
        {
            CargarPantallaUsuario();
            linkPerfil.Text = "Mi perfil";
            _perfil = false;
        }

        private void CargarNombreUsuario()
        {
            lblPrimerNombre.Text = DatosUsuario.PrimerNombre;
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CerrarForm();
        }

        private void CerrarForm()
        {
            this.Close();
        }



        #endregion


    }
}