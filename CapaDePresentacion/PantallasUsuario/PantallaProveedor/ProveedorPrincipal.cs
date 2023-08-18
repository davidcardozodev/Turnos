using CapaComun;
using CapaDeEntidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor
{
    public partial class ProveedorPrincipal : Form
    {
        public ProveedorPrincipal()
        {
            InitializeComponent();
        }

        private void btnTurnosClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ProveedorTurnosVista>();
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

        private void btnLlamador_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ProveedorLlamador>();
        }

        private void ProveedorPrincipal_Load(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorCargarDisponibilidad(DatosUsuario.Id);
        }
    }
}
