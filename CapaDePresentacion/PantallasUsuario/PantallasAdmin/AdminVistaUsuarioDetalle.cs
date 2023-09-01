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
        public int HorarioInicio { get; set; }
        public int HorarioFin { get; set; }

        #endregion

        private void AdminVistaUsuarioDetalle_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarPlanes();
            CargarValoresHorarioInicio();
            ValorInicialHorarios();
            ActivarCambioHorarioProveedor();
            ValorInicialProveedor();
            CargarDatosUsuario();
            CargarDisponibilidadProveedor();

        }

        private void CargarDisponibilidadProveedor()
        {
            if (RolUsuario == Rol.Proveedor)
            {
                comboInicio.SelectedItem = HorarioInicio;
                comboFin.SelectedItem = HorarioFin;
            }
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
                comboInicio.Visible = true;
                comboFin.Visible = true;
                lblInicio.Visible = true;
                lblFin.Visible = true;
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
            comboRol.SelectedItem = RolUsuario;
            comboPlan.SelectedItem = TipoPlan;
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

            admin.AdminModificarUsuario(Id, txtUsuario.Text, txtClave.Text, txtPrimerNombre.Text, txtSegundoNombre.Text, txtEmail.Text, comboRol.Text, comboPlan.Text);

            Admin adminDisponibilidad = new Admin();

            adminDisponibilidad.AdminGuardarDisponibilidad(Id, int.Parse(comboInicio.Text), int.Parse(comboFin.Text));

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void comboRol_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiarHorarios();
            CargarValoresFinHorario();
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
