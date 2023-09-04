using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using CapaDePresentacion.PantallasUsuario.PantallasAdmin;
using CapaDePresentacion.PantallasUsuario.PantallasCliente;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallaTurno
{
    public partial class TurnoDetalle : Form
    {
        public TurnoDetalle()
        {
            InitializeComponent();
        }

        private void TurnoDetalle_Load(object sender, EventArgs e)
        {
            CargarInformacion();
            CambiarColorEstado();
            OcultarEtiquetas();
            OcultarOpcionDarBaja();
            CargarProveedores();
            DesactivarOpcionDarBaja();
        }

        private void DesactivarOpcionDarBaja()
        {
            if (Estado == "Pendiente")
                btnDarDeBaja.Enabled = true;
        }

        private void CargarProveedores()
        {
            if (DatosUsuario.Rol == Rol.Admin)
            {
                ActivarOpcionProveedores();
                CargarValorPredeterminadoProveedor();

                Admin admin = new Admin();

                DataTable proveedores = new DataTable();

                proveedores = admin.AdminCargarProveedores();

                foreach (DataRow proveedor in proveedores.Rows)
                    comboProveedores.Items.Add(proveedor["Nombre"].ToString());
            }
        }

        private const int CB_SETCUEBANNER = 0x1703;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void CargarValorPredeterminadoProveedor()
        {
            SendMessage(this.comboProveedores.Handle, CB_SETCUEBANNER, 0, Estados.SinDefinir);
        }

        private void ActivarOpcionProveedores()
        {
            comboProveedores.Visible = true;
            lblCambiarProveedor.Visible = true;
            btnGuardar.Visible = true;
        }

        private void OcultarOpcionDarBaja()
        {
            if (DatosUsuario.Rol == Rol.Proveedor)
                btnDarDeBaja.Visible = false;
        }

        private void OcultarEtiquetas()
        {
            switch (DatosUsuario.Rol)
            {
                case Rol.Cliente:
                    lblUsuario.Visible = false;
                    lblUsuarioCategoria.Visible = false;
                    break;
                case Rol.Proveedor:
                    lblProveedor.Visible = false;
                    lblProveedorCategoria.Visible = false;
                    break;
                case Rol.Admin:
                    dtpFecha.Visible = true;
                    lblFechaModificacion.Visible = true;
                    break;
            }
        }

        #region "Atributos"

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string DiaNombre { get; set; }
        public string DiaNumero { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string NombreProveedor { get; set; }
        public string Presencia { get; set; }

        string AnioGuardar = "";
        string MesGuardar = "";
        string DiaNombreGuardar = "";
        string DiaNumeroGuardar = "";

        private bool GuardarProveedor = false;
        private bool GuardarFecha = false;

        #endregion

        private void CargarInformacion()
        {
            lblFecha.Text = DiaNombre + " " + DiaNumero + ", " + Mes + ", " + Anio;
            lblUsuario.Text = Nombre + " (" + Usuario + ")";
            lblHora.Text = Hora + ":00hs";
            rtxtDecripcion.Text = Descripcion;
            lblEstado.Text = Estado;
            lblProveedor.Text = NombreProveedor;
        }

        private void btnDarDeBaja_Click(object sender, System.EventArgs e)
        {
            DialogResult Alerta = MessageBox.Show("¿Quiere dar de baja el turno?", "Dar de baja", MessageBoxButtons.YesNo);

            if (Alerta == DialogResult.Yes)
            {
                DarBaja();
                btnDarDeBaja.Enabled = false;
                Estado = Estados.Cancelado;
                lblEstado.Text = Estados.Cancelado;
                CambiarColorEstado();
            }
        }

        private void DarBaja()
        {
            Turno turno = new Turno();

            turno.TurnoDarBaja(Id);
            AdminDarBajaTurno();
        }

        private void AdminDarBajaTurno()
        {
            if (DatosUsuario.Rol == Rol.Admin)
            {
                Admin admin = new Admin();

                admin.AdminGuardarBajaNotificacion(Id, DatosUsuario.Id, IdCliente);
            }
        }

        private void CambiarColorEstado()
        {
            switch (Estado)
            {
                case Estados.Cancelado:
                    lblEstado.ForeColor = Color.FromArgb(255, 0, 0);
                    break;
                case Estados.Finalizado:
                    lblEstado.ForeColor = Color.FromArgb(0, 255, 0);
                    break;
                case Estados.Pendiente:
                case Estados.Asignado:
                case Estados.EnCurso:
                    lblEstado.ForeColor = Color.FromArgb(0, 0, 255);
                    break;
            }
        }

        private void comboProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuardarProveedor = true;
            btnGuardar.Enabled = true;

            if (comboProveedores.Text != Estados.SinDefinir || GuardarFecha == true)
                btnGuardar.Enabled = true;
            else
                btnGuardar.Enabled = false;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            GuardarFecha = true;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AdminGuardarModificacion();

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void AdminGuardarModificacion()
        {
            Admin admin = new Admin();

            if (GuardarFecha)
                GuardarNuevaFecha();

            if (!GuardarProveedor)
                comboProveedores.Text = string.Empty;

            admin.AdminGuardarModificacion(Id, DatosUsuario.Id, IdCliente, DiaNombreGuardar, DiaNumeroGuardar, MesGuardar, AnioGuardar, comboProveedores.Text);
        }

        private void GuardarNuevaFecha()
        {
            AnioGuardar = dtpFecha.Value.ToString("yyyy");
            MesGuardar = dtpFecha.Value.ToString("MMMM");
            DiaNombreGuardar = dtpFecha.Value.ToString("dddd");
            DiaNumeroGuardar = dtpFecha.Value.ToString("dd");
        }

        private void TurnoDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActualizarPantallaAdminVistaTurno();
            ActualizarPantallaClienteVistaTurno();
        }

        private static void ActualizarPantallaAdminVistaTurno()
        {
            if (DatosUsuario.Rol == Rol.Admin)
                (Application.OpenForms["AdminTurnosVista"] as AdminTurnosVista).CargarTurnoItem();
        }

        private static void ActualizarPantallaClienteVistaTurno()
        {
            if (DatosUsuario.Rol == Rol.Cliente)
                (Application.OpenForms["ClienteTurnosVista"] as ClienteTurnosVista).CargarTurnoItem();
        }
    }
}
