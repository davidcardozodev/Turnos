using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminEstablecimientoVistaDetalle : Form
    {
        public AdminEstablecimientoVistaDetalle()
        {
            InitializeComponent();
        }
        private void AdminEstablecimientoVistaDetalle_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public int Id { get; set; }

        public string Nombre { get; set; }

        private void CargarDatos()
        {
            txtNombre.Text = Nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminModificarEstablecimiento(Id, txtNombre.Text);

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

    }
}
