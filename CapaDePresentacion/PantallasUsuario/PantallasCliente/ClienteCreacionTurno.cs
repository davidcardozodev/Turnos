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
            CargarValorPredeterminadoArea();
        }

        private void CargarAreas()
        {
            Cliente cliente = new Cliente();

            DataTable areas = cliente.ClienteCargarArea();

            foreach (DataRow proveedor in areas.Rows)
                comboArea.Items.Add(proveedor["Nombre"].ToString());
        }

        private const int CB_SETCUEBANNER = 0x1703;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void CargarValorPredeterminadoArea()
        {
            SendMessage(this.comboArea.Handle, CB_SETCUEBANNER, 0, Estados.SinDefinir);
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

        string anio, mes, diaNombre, diaNumero, hora, descripcion;

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
            anio = dtpFecha.Value.ToString("yyyy");
            mes = dtpFecha.Value.ToString("MMMM");
            diaNombre = dtpFecha.Value.ToString("dddd");
            diaNumero = dtpFecha.Value.ToString("dd");
        }

        private void GuardarHoraDescripcion()
        {
            hora = comboHora.Text;
            descripcion = txtDescripcion.Text;
        }

        #endregion

        private void btnCrearTurno_Click(object sender, System.EventArgs e)
        {
            Cliente cliente = new Cliente();

            GuardarHoraDescripcion();
            GuardarFecha();

            cliente.TurnoCrear(DatosUsuario.Id, diaNombre, diaNumero, mes, anio, hora, descripcion);

            MessageBox.Show(Mensajes.GuardadoTurno);
        }
    }
}