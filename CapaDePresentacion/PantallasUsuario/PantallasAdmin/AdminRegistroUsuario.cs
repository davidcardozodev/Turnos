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

        #region "Atributos"


        private string Usuario;
        private string PrimerNombre;
        private string SegundoNombre;
        private string Email;
        private string Clave;
        private string Rol_;
        private string TipoPlan;

        #endregion

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
            return !string.IsNullOrWhiteSpace(Usuario) &&
                   !string.IsNullOrWhiteSpace(PrimerNombre) &&
                   !string.IsNullOrWhiteSpace(SegundoNombre) &&
                   !string.IsNullOrWhiteSpace(Email) &&
                   !string.IsNullOrWhiteSpace(Clave);
        }

        private void AsignarDatos()
        {
            Usuario = txtUsuario.Text;
            PrimerNombre = txtPrimerNombre.Text;
            SegundoNombre = txtSegundoNombre.Text;
            Email = txtEmail.Text;
            Clave = txtClave.Text;
            Rol_ = comboRol.Text;
            TipoPlan = comboTipoPlan.Text;
        }

        private void RegistrarUsuario()
        {
            Admin admin = new Admin();

            admin.AdminRegistrarUsuario(Usuario, Clave, PrimerNombre, SegundoNombre, Email, Rol_, TipoPlan);

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
