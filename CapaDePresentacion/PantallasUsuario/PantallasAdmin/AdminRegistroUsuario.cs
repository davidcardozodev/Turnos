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
        }

        private void CargarTipoPlanes()
        {
            comboTipoPlan.Items.Add(Plan.Basico);
            comboTipoPlan.Items.Add(Plan.Estandar);
            comboTipoPlan.Items.Add(Plan.Premium);
        }

        private void CargarRoles()
        {
            comboRol.Items.Add(Roles.rolCliente);
            comboRol.Items.Add(Roles.rolProveedor);
            comboRol.Items.Add(Roles.rolAdmin);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminRegistrarUsuario(txtUsuario.Text, txtPrimerNombre.Text, txtSegundoNombre.Text, txtEmail.Text, txtClave.Text, comboRol.Text, comboTipoPlan.Text);

            MessageBox.Show(Mensajes.GuardadoCambios);
        }
    }
}
