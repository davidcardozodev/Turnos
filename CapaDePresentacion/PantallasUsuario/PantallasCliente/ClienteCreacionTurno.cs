using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasCliente
{
    public partial class ClienteCreacionTurno : Form
    {
        public ClienteCreacionTurno()
        {
            InitializeComponent();
        }

        private void ClienteCreacionTurno_Load(object sender, System.EventArgs e)
        {
            CargarHorarios();
            GuardarFecha();
            ValorInicialHorario();
            CargarAreas();
            CargarValorPredeterminadoListas();
            CargarEstablecimientos();
        }

        private void CargarAreas()
        {
            Cliente cliente = new Cliente();

            DataTable Areas = cliente.ClienteCargarArea();

            foreach (DataRow proveedor in Areas.Rows)
                comboArea.Items.Add(proveedor["Nombre"].ToString());
        }

        private void CargarEstablecimientos()
        {
            Cliente cliente = new Cliente();

            DataTable Establecimiento = cliente.ClienteCargarEstablecimiento();

            foreach (DataRow proveedor in Establecimiento.Rows)
                comboEstablecimiento.Items.Add(proveedor["Nombre"].ToString());
        }

        private const int CB_SETCUEBANNER = 0x1703;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void CargarValorPredeterminadoListas()
        {
            SendMessage(this.comboArea.Handle, CB_SETCUEBANNER, 0, Estados.SinDefinir);
            SendMessage(this.comboEstablecimiento.Handle, CB_SETCUEBANNER, 0, Estados.SinDefinir);
        }

        private void btnVolverAtras_Click(object sender, System.EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }

        #region "Datos del turno"

        private string Anio, Mes, DiaNombre, DiaNumero, Hora, Descripcion, Area, Establecimiento;

        private void ValorInicialHorario()
        {
            comboHora.SelectedItem = 8;
        }

        private void CargarHorarios()
        {
            for (int i = 8; i <= 22; i++)
                comboHora.Items.Add(i);
        }

        private void GuardarFecha()
        {
            Anio = dtpFecha.Value.ToString("yyyy");
            Mes = dtpFecha.Value.ToString("MMMM");
            DiaNombre = dtpFecha.Value.ToString("dddd");
            DiaNumero = dtpFecha.Value.ToString("dd");
        }

        private void GuardarDatos()
        {
            Hora = comboHora.Text;
            Descripcion = txtDescripcion.Text;
            Area = comboArea.Text;
            Establecimiento = comboEstablecimiento.Text;
        }

        #endregion

        private void btnCrearTurno_Click(object sender, System.EventArgs e)
        {
            Cliente cliente = new Cliente();

            GuardarDatos();
            GuardarFecha();

            cliente.TurnoCrear(DatosUsuario.Id, DiaNombre, DiaNumero, Mes, Anio, Hora, Descripcion, Area, Establecimiento);

            MessageBox.Show(Mensajes.GuardadoTurno);
        }
    }
}