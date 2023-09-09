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
            ValorInicialHorario();
            CargarAreas();
            CargarValorPredeterminadoListas();
        }

        private void CargarAreas()
        {
            Cliente cliente = new Cliente();

            DataTable Area = cliente.ClienteCargarArea();

            DataRow placeHolder = Area.NewRow();
            placeHolder[Campo.Nombre] = PlaceHolder.SeleccionarArea;
            placeHolder[Campo.Id] = 0;

            Area.Rows.InsertAt(placeHolder, 0);

            comboArea.DisplayMember = Campo.Nombre;
            comboArea.ValueMember = Campo.Id;
            comboArea.DataSource = Area;
            comboArea.SelectedIndex = 0;
        }

        private void CargarEstablecimientos()
        {
            Cliente cliente = new Cliente();

            DataTable Establecimiento = cliente.ClienteCargarAsociacionEstablecimientoLugar((int)comboArea.SelectedValue);

            DataRow placeHolder = Establecimiento.NewRow();
            placeHolder[Campo.Nombre] = PlaceHolder.SeleccionarEstablecimiento;
            placeHolder[Campo.Id] = 0;

            Establecimiento.Rows.InsertAt(placeHolder, 0);

            comboEstablecimiento.DisplayMember = Campo.Nombre;
            comboEstablecimiento.ValueMember = Campo.Id;
            comboEstablecimiento.DataSource = Establecimiento;
            comboEstablecimiento.SelectedIndex = 0;
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

        private void comboArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarEstablecimientos();
            comboEstablecimiento.Enabled = true;
        }

        private void ValorInicialHorario()
        {
            comboHora.SelectedItem = PlaceHolder.SeleccionarHorario;
        }

        private void CargarHorarios()
        {
            comboHora.Items.Add(PlaceHolder.SeleccionarHorario);

            for (int i = 8; i <= 22; i++)
                comboHora.Items.Add(i);
        }

        private void GuardarDatos()
        {
            Hora = comboHora.Text;
            Descripcion = txtDescripcion.Text;
            Area = comboArea.Text;
            Establecimiento = comboEstablecimiento.Text;

            Anio = dtpFecha.Value.ToString(Fecha.yyyy);
            Mes = dtpFecha.Value.ToString(Fecha.MMMM);
            DiaNombre = dtpFecha.Value.ToString(Fecha.dddd);
            DiaNumero = dtpFecha.Value.ToString(Fecha.dd);
        }

        #endregion

        private void btnCrearTurno_Click(object sender, System.EventArgs e)
        {
            GuardarDatos();
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            string mensajeError = Campo.Vacio;

            if (Area == PlaceHolder.SeleccionarArea)
                mensajeError += Mensajes.ErrorArea + Environment.NewLine;

            if (string.IsNullOrEmpty(Establecimiento))
                mensajeError += Mensajes.ErrorEstablecimiento + Environment.NewLine;

            if (Hora == PlaceHolder.SeleccionarHorario)
                mensajeError += Mensajes.ErrorHorario + Environment.NewLine;

            if (Area == PlaceHolder.SeleccionarArea || string.IsNullOrEmpty(Establecimiento) || Hora == PlaceHolder.SeleccionarHorario)
                MessageBox.Show(mensajeError);

            if (Area != PlaceHolder.SeleccionarArea && !string.IsNullOrEmpty(Establecimiento) && Hora != PlaceHolder.SeleccionarHorario)
                GuardarTurno();
        }

        private void GuardarTurno()
        {
            Cliente cliente = new Cliente();

            cliente.ClienteCrearTurno(DatosUsuario.Id, DiaNombre, DiaNumero, Mes, Anio, Hora, Descripcion, Area, Establecimiento);

            MessageBox.Show(Mensajes.GuardadoTurno);
            VolverAtras();
        }
    }
}