using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Data;
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
            CargarValoresHorarioInicio();
            CargarValoresFinHorario();
            AdminCargarLugares();
            ValorInicialHorarios();
        }

        #region "Atributos"

        private string Usuario;
        private string Nombre;
        private string Email;
        private string Clave;
        private string Rol_;
        private string TipoPlan;
        private int HorarioInicio = 0;
        private int HorarioFin = 0;
        private bool CambiarHorarioProveedor = false;

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

        private void AdminCargarLugares()
        {
            Admin admin = new Admin();

            DataTable Lugares = admin.AdminCargarLugares();

            comboLugar.DataSource = Lugares;
            comboLugar.DisplayMember = "Nombre";
            comboLugar.ValueMember = "Id";
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
                   !string.IsNullOrWhiteSpace(Nombre) &&
                   !string.IsNullOrWhiteSpace(Email) &&
                   !string.IsNullOrWhiteSpace(Clave);
        }

        private void AsignarDatos()
        {
            Usuario = txtUsuario.Text;
            Nombre = txtNombre.Text;
            Email = txtEmail.Text;
            Clave = txtClave.Text;
            Rol_ = comboRol.Text;
            TipoPlan = comboTipoPlan.Text;
        }

        private void RegistrarUsuario()
        {
            Admin admin = new Admin();

            admin.AdminRegistrarUsuario(Usuario, Clave, Nombre, Email, Rol_, HorarioInicio, HorarioFin, TipoPlan);

            AdminGuardarLugarProveedor();

            MessageBox.Show(Mensajes.GuardadoCambios);
            VolverAtras();
        }

        private void AdminGuardarLugarProveedor()
        {
            Admin admin = new Admin();

            if (comboRol.Text == Rol.Proveedor)
                admin.AdminGuardarLugarProveedor((int)comboLugar.SelectedValue);
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRol.Text == Rol.Proveedor)
            {
                comboHorarioInicio.Enabled = true;
                comboHorarioFin.Enabled = true;
                CambiarHorarioProveedor = true;
                comboLugar.Enabled = true;
                HorarioInicio = 8;
                HorarioFin = 9;
            }
            else
            {
                comboHorarioInicio.Enabled = false;
                comboHorarioFin.Enabled = false;
                CambiarHorarioProveedor = false;
                comboLugar.Enabled = false;
                HorarioInicio = 0;
                HorarioFin = 0;
            }
        }

        private void ValorInicialHorarios()
        {
            comboHorarioInicio.SelectedItem = 8;
            comboHorarioFin.SelectedItem = 9;
        }

        private void CargarValoresFinHorario()
        {
            for (int i = HorarioInicio + 1; i <= 22; i++)
                comboHorarioFin.Items.Add(i);
        }

        private void CargarValoresHorarioInicio()
        {
            for (int i = 8; i <= 21; i++)
                comboHorarioInicio.Items.Add(i);
        }

        private void comboHorarioInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CambiarHorarioProveedor)
            {
                HorarioInicio = int.Parse(comboHorarioInicio.Text);
                LimpiarHorarios();
                CargarValoresFinHorario();
                ActualizarValorHorarioFin();
            }
        }

        private void LimpiarHorarios()
        {
            comboHorarioFin.Items.Clear();
        }

        private void ActualizarValorHorarioFin()
        {
            comboHorarioFin.SelectedItem = (int)comboHorarioInicio.SelectedItem + 1;
        }

        private void comboHorarioFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CambiarHorarioProveedor)
                HorarioFin = int.Parse(comboHorarioFin.Text);
        }
    }
}
