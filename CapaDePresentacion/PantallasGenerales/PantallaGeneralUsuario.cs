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
    }
}