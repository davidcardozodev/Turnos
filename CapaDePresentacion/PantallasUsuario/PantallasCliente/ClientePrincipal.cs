using CapaDePresentacion.PantallasUsuario.PantallasCliente;
using System.Linq;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario
{
    public partial class ClientePrincipal : Form
    {
        public ClientePrincipal()
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

        private void btnMisTurnos_Click(object sender, System.EventArgs e)
        {
            AbrirFormulario<ClienteTurnosVista>();
        }

        private void btnCrearTurno_Click(object sender, System.EventArgs e)
        {
            AbrirFormulario<ClienteCreacionTurno>();
        }

        #endregion
    }
}
