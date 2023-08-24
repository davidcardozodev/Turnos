using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminRegistroUsuario : Form
    {
        public AdminRegistroUsuario()
        {
            InitializeComponent();
        }

        private void AdminRegistroUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarTipoPlanes();
            CargarRolTipoPlanDefecto();
        }

        private string usuario;
        private string primerNombre;
        private string segundoNombre;
        private string email;
        private string clave;
        private string rol;
        private string tipoPlan;

        private void CargarRolTipoPlanDefecto()
        {
            comboRol.SelectedItem = Rol.Cliente;
            comboTipoPlan.SelectedItem = Plan.Basico;
        }

        private void CargarTipoPlanes()
        {
            comboTipoPlan.Items.Add(Plan.Basico);
            comboTipoPlan.Items.Add(Plan.Estandar);
            comboTipoPlan.Items.Add(Plan.Premium);
        }

        private void CargarRoles()
        {
            comboRol.Items.Add(Rol.Cliente);
            comboRol.Items.Add(Rol.Proveedor);
            comboRol.Items.Add(Rol.Admin);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AsignarDatos();

            if (ComprobarCampos())
                RegistrarUsuario();
            else
                MessageBox.Show("Todos los campos deben estar llenos");
        }

        private bool ComprobarCampos()
        {
            return !string.IsNullOrWhiteSpace(usuario) &&
                   !string.IsNullOrWhiteSpace(primerNombre) &&
                   !string.IsNullOrWhiteSpace(segundoNombre) &&
                   !string.IsNullOrWhiteSpace(email) &&
                   !string.IsNullOrWhiteSpace(clave);
        }

        private void AsignarDatos()
        {
            usuario = txtUsuario.Text;
            primerNombre = txtPrimerNombre.Text;
            segundoNombre = txtSegundoNombre.Text;
            email = txtEmail.Text;
            clave = txtClave.Text;
            rol = comboRol.Text;
            tipoPlan = comboTipoPlan.Text;
        }

        private void RegistrarUsuario()
        {
            Admin admin = new Admin();

            admin.AdminRegistrarUsuario(usuario, primerNombre, segundoNombre, email, clave, rol, tipoPlan);

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }
    }
}
