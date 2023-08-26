using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminVistaUsuarioDetalle : Form
    {
        public AdminVistaUsuarioDetalle()
        {
            InitializeComponent();
        }

        #region "Atributos"

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Email { get; set; }
        public string RolUsuario { get; set; }
        public string TipoPlan { get; set; }

        #endregion

        private void AdminVistaUsuarioDetalle_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarDatosUsuario();
            CargarPlanes();
            CargarValoresHorarioInicio();
            ValorInicialHorarios();
            ActivarCambioHorarioProveedor();
            ValorInicialProveedor();
        }

        private void CargarPlanes()
        {
            comboPlan.Items.Add(Plan.Basico);
            comboPlan.Items.Add(Plan.Estandar);
            comboPlan.Items.Add(Plan.Premium);
        }

        private void ValorInicialProveedor()
        {
            comboRol.SelectedText = RolUsuario;
        }

        private void ActivarCambioHorarioProveedor()
        {
            if (RolUsuario == Rol.Proveedor)
            {
                comboInicio.Enabled = true;
                comboFin.Enabled = true;
            }
        }

        #region "Horario"

        private void CargarValoresFinHorario()
        {
            for (int i = (int)comboInicio.SelectedItem + 1; i <= 22; i++)
                comboFin.Items.Add(i);
        }

        private void CargarValoresHorarioInicio()
        {
            for (int i = 8; i <= 21; i++)
                comboInicio.Items.Add(i);
        }

        private void ValorInicialHorarios()
        {
            comboInicio.SelectedItem = 8;
            comboFin.SelectedItem = 9;
        }

        private void LimpiarHorarios()
        {
            comboFin.Items.Clear();
        }

        #endregion

        private void CargarDatosUsuario()
        {
            txtUsuario.Text = Usuario;
            txtClave.Text = Clave;
            txtPrimerNombre.Text = PrimerNombre;
            txtSegundoNombre.Text = SegundoNombre;
            txtEmail.Text = Email;
            comboRol.SelectedValue = RolUsuario;
            comboPlan.SelectedValue = TipoPlan;
            comboPlan.SelectedText = TipoPlan;
        }

        private void CargarRoles()
        {
            comboRol.Items.Add(Rol.Cliente);
            comboRol.Items.Add(Rol.Proveedor);
            comboRol.Items.Add(Rol.Admin);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminModificarUsuario(Id, txtUsuario.Text, txtClave.Text, txtPrimerNombre.Text, txtSegundoNombre.Text, txtEmail.Text, comboRol.Text);

            Admin adminDisponibilidad = new Admin();

            adminDisponibilidad.AdminGuardarDisponibilidad(Id, int.Parse(comboInicio.Text), int.Parse(comboFin.Text));

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void comboRol_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiarHorarios();
            CargarValoresFinHorario();
            ActivarOpcionGuardado();
        }

        private void ActivarOpcionGuardado()
        {
            btnGuardar.Enabled = true;
        }

        private void comboInicio_Click(object sender, EventArgs e)
        {
            ActivarOpcionGuardado();
        }

        private void comboInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarHorarios();
            CargarValoresFinHorario();
        }

        private void comboFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarOpcionGuardado();
        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRol.Text == RolUsuario)
                DesactivarOpcionGuardado();
        }

        private void DesactivarOpcionGuardado()
        {
            btnGuardar.Enabled = false;
        }

        private void comboInicio_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiarHorarios();
            CargarValoresFinHorario();
            ActualizarValorHorarioFin();
        }

        private void ActualizarValorHorarioFin()
        {
            comboFin.SelectedItem = (int)comboInicio.SelectedItem + 1;
        }
    }
}
