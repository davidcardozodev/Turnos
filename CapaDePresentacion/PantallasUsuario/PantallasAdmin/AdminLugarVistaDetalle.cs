using CapaDeEntidades;
using CapaDeNegocio;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminLugarVistaDetalle : Form
    {
        public AdminLugarVistaDetalle()
        {
            InitializeComponent();
        }

        private void AdminLugarVistaDetalle_Load(object sender, System.EventArgs e)
        {
            CargarDatos();
        }

        public int Id { get; set; }

        public string Nombre { get; set; }

        private void CargarDatos()
        {
            txtNombre.Text = Nombre;
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminModificarLugar(Id, txtNombre.Text);

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void ActualizarPantalla()
        {
            (Application.OpenForms["AdminLugares"] as AdminLugares).Actualizar();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            DialogResult Alerta = MessageBox.Show(Mensajes.AlertaEliminacion, Mensajes.AlertaEliminacionTitulo, MessageBoxButtons.YesNo);

            if (Alerta == DialogResult.Yes)
            {
                Admin admin2 = new Admin();

                admin2.AdminEliminarLugar(Id);

                ActualizarPantalla();
                this.Close();
            }
        }
    }
}
