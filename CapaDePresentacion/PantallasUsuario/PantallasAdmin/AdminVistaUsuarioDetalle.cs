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

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }

        private void AdminVistaUsuarioDetalle_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarDatosUsuario();
            CargarValoresHorarioInicio();
            ValorInicialHorarios();
            ActivarCambioHorarioProveedor();
            ValorInicialProveedor();
        }

        private void ValorInicialProveedor()
        {
            comboRol.SelectedText = Rol;
        }

        private void ActivarCambioHorarioProveedor()
        {
            if (Rol == Roles.rolProveedor)
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
            lblUsuario.Text = PrimerNombre + " " + SegundoNombre + " (" + Usuario + ")";
            lblEmail.Text = Email;
            lblRol.Text = Rol;
        }

        private void CargarRoles()
        {
            comboRol.Items.Add(Roles.rolCliente);
            comboRol.Items.Add(Roles.rolProveedor);
            comboRol.Items.Add(Roles.rolAdmin);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminModificarUsuario(Id, comboRol.Text);

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
            if (comboRol.Text == Rol)
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
