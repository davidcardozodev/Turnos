using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using CapaDePresentacion.PantallasUsuario.PantallasAdmin;
using CapaDePresentacion.PantallasUsuario.PantallasCliente;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallaTurno
{
    public partial class TurnoCliente : Form
    {
        public TurnoCliente()
        {
            InitializeComponent();
        }

        private void TurnoDetalle_Load(object sender, EventArgs e)
        {
            CargarInformacion();
            CambiarColorEstado();
            OcultarOpcionDarBaja();
            DesactivarOpcionDarBaja();
        }

        private void DesactivarOpcionDarBaja()
        {
            if (Estado == Estados.Pendiente)
                btnDarDeBaja.Enabled = true;
        }

        private void OcultarOpcionDarBaja()
        {
            if (DatosUsuario.Rol == Rol.Proveedor)
                btnDarDeBaja.Visible = false;
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
      
        public string NombreProveedor { get; set; }

        #endregion

        private void CargarInformacion()
        {
            lblFecha.Text = DiaNombre + Campo.EspacioSimple + DiaNumero + ", " + Mes + ", " + Anio;
            lblHora.Text = Hora + Campo.Hora;
            rtxtDecripcion.Text = Descripcion;
            lblEstado.Text = Estado;
            lblProveedor.Text = NombreProveedor;
        }

        private void btnDarDeBaja_Click(object sender, System.EventArgs e)
        {
            DialogResult Alerta = MessageBox.Show(Mensajes.AlertaBajaOpcion, Mensajes.AlertaBajaTitulo, MessageBoxButtons.YesNo);

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
            SelectorColor selectorColor = new SelectorColor();

            switch (Estado)
            {
                case Estados.Cancelado:
                    lblEstado.ForeColor = selectorColor.Rojo();
                    break;
                case Estados.Finalizado:
                    lblEstado.ForeColor = selectorColor.Verde();
                    break;
                case Estados.Pendiente:
                case Estados.Asignado:
                case Estados.EnCurso:
                    lblEstado.ForeColor = selectorColor.Azul();
                    break;
            }
        }

        private void TurnoDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActualizarPantallaClienteVistaTurno();
        }

        private static void ActualizarPantallaClienteVistaTurno()
        {
            if (DatosUsuario.Rol == Rol.Cliente)
                (Application.OpenForms["ClienteTurnosVista"] as ClienteTurnosVista).CargarTurnoItem();
        }
    }
}
