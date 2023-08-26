using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Data;
using System.Drawing;
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
            ActivarOpcionAsignarProveedor();
            OcultarOpcionDarBaja();
            CargarProveedores();
            DesactivarOpcionAsignar();
            DesactivarOpcionDarBaja();
        }

        private void DesactivarOpcionDarBaja()
        {
            if (Estado == "Pendiente")
                btnDarDeBaja.Enabled = true;
        }

        private void DesactivarOpcionAsignar()
        {
            if (Presencia == "Ausente")
                btnAsignar.Enabled = false;
        }

        private void CargarProveedores()
        {
            if (DatosUsuario.Rol == Rol.Admin)
            {
                ActivarOpcionProveedores();

                comboProveedores.Items.Add(Estados.SinDefinir);
                comboProveedores.SelectedText = Estados.SinDefinir;

                Admin admin = new Admin();

                DataTable proveedores = new DataTable();

                proveedores = admin.AdminCargarProveedores();

                foreach (DataRow proveedor in proveedores.Rows)
                    comboProveedores.Items.Add(proveedor["PrimerNombre"].ToString() + " " + proveedor["SegundoNombre"].ToString());
            }
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

        private void ActivarOpcionAsignarProveedor()
        {
            if (DatosUsuario.Rol == Rol.Proveedor)
                btnAsignar.Visible = true;
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
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string NombreProveedor { get; set; }
        public string Presencia { get; set; }

        string anio = "";
        string mes = "";
        string diaNombre = "";
        string diaNumero = "";

        private bool guardarProveedor = false;
        private bool guardarFecha = false;

        #endregion

        private void CargarInformacion()
        {
            lblFecha.Text = DiaNombre + " " + DiaNumero + ", " + Mes + ", " + Anio;
            lblUsuario.Text = PrimerNombre + " " + SegundoNombre + " (" + Usuario + ")";
            lblHora.Text = Hora + ":00hs";
            rtxtDecripcion.Text = Descripcion;
            lblEstado.Text = Estado;
            lblProveedor.Text = NombreProveedor;
        }

        private void btnDarDeBaja_Click(object sender, System.EventArgs e)
        {
            DialogResult Alerta = MessageBox.Show("¿Quiere dar de baja el turno?", "Dar de baja", MessageBoxButtons.YesNo);

            if (Alerta == DialogResult.Yes)
                DarBaja();
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

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorAsignar(DatosUsuario.Id, Id);

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void comboProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            guardarProveedor = true;
            btnGuardar.Enabled = true;

            if (comboProveedores.Text != Estados.SinDefinir || guardarFecha == true)
                btnGuardar.Enabled = true;
            else
                btnGuardar.Enabled = false;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            guardarFecha = true;
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

            if (guardarFecha)
                GuardarFecha();

            if (!guardarProveedor)
                comboProveedores.Text = string.Empty;

            admin.AdminGuardarModificacion(Id, DatosUsuario.Id, IdCliente, diaNombre, diaNumero, mes, anio, comboProveedores.Text);
        }

        private void GuardarFecha()
        {
            anio = dtpFecha.Value.ToString("yyyy");
            mes = dtpFecha.Value.ToString("MMMM");
            diaNombre = dtpFecha.Value.ToString("dddd");
            diaNumero = dtpFecha.Value.ToString("dd");
        }
    }
}
