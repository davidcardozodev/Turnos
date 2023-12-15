using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminPrincipal : Form
    {
        public AdminPrincipal()
        {
            InitializeComponent();
        }

        #region "Cargar Formulario"

        public void AbrirFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form Formulario = new Form();
            Formulario = panel1.Controls.OfType<MiFormulario>().FirstOrDefault();
            Formulario = CrearFormulario<MiFormulario>(Formulario);
        }

        public Form CrearFormulario<MiFormulario>(Form Formulario) where MiFormulario : Form, new()
        {
            if (Formulario == null)
                Formulario = CargarFormulario<MiFormulario>();
            else
                Formulario.BringToFront();

            return Formulario;
        }

        public Form CargarFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form Formulario = new MiFormulario();

            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;

            panel1.Controls.Add(Formulario);
            panel1.Tag = Formulario;

            Formulario.Show();
            Formulario.BringToFront();

            return Formulario;
        }

        #endregion

        #region "Botones"

        private void btnTurnosClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminTurnosVista>();
        }

        #endregion

        private void btnListaUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminVistaUsuarios>();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminRegistroUsuario>();
        }

        private void btnAdministrarLugares_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminVistaLugar>();
        }

        private void btnAsociarEstablecimientosAreas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminAsociarEstablecimientoArea>();
        }

        private void btnVerAreas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminAreas>();
        }

        private void btnVerLugares_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminLugares>();
        }

        private void btnRegistrarArea_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminRegistrarArea>();
        }

        private void btnRegistrarLugar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminRegistrarLugar>();
        }

        private void btnRegistrarEstablecimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminRegistrarEstablecimiento>();
        }

        private void btnVerEstablecimientos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdminEstablecimientos>();
        }
    }
}
