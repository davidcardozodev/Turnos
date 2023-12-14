using CapaDeEntidades;
using CapaDeNegocio;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminRegistrarArea : Form
    {
        public AdminRegistrarArea()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminRegistrarArea(txtNombre.Text);

            MessageBox.Show(Mensajes.GuardadoCambios);
            VolverAtras();
        }

        private void btnVolverAtras_Click(object sender, System.EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }
    }
}
