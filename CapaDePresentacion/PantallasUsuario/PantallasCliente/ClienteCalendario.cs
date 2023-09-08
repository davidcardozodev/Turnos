using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasCliente
{
    public partial class ClienteCalendario : Form
    {
        public ClienteCalendario()
        {
            InitializeComponent();
        }

        private void ClienteCalendario_Load(object sender, System.EventArgs e)
        {
            ActualizarFecha();
            OcultarCalendario();
            CargarValoresHorario();
            ValorInicialHorario();
            CargarAreas();
            CargarValorPredeterminadoListas();
        }

        #region "Atributos"

        private string DiaNombre { get; set; }
        private string DiaNumero { get; set; }
        private string Mes { get; set; }
        private string Anio { get; set; }

        private bool Calendario = false;

        private string Descripcion;
        private string Hora;
        private string Area;
        private string Establecimiento;

        #endregion

        private void CargarAreas()
        {
            Cliente cliente = new Cliente();

            DataTable Area = cliente.ClienteCargarArea();

            comboArea.DataSource = Area;
            comboArea.DisplayMember = Campo.Nombre;
            comboArea.ValueMember = Campo.Id;
        }

        private void CargarEstablecimientos()
        {
            Cliente cliente = new Cliente();

            DataTable Establecimiento = cliente.ClienteCargarAsociacionEstablecimientoLugar((int)comboArea.SelectedValue);

            comboEstablecimiento.DataSource = Establecimiento;
            comboEstablecimiento.DisplayMember = Campo.Nombre;
            comboEstablecimiento.ValueMember = Campo.Id;
        }


        private const int CB_SETCUEBANNER = 0x1703;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void CargarValorPredeterminadoListas()
        {
            SendMessage(this.comboArea.Handle, CB_SETCUEBANNER, 0, Estados.SinDefinir);
            SendMessage(this.comboEstablecimiento.Handle, CB_SETCUEBANNER, 0, Estados.SinDefinir);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ActualizarFecha();
            CargarFecha();
        }

        private void ActualizarFecha()
        {
            DiaNombre = monthCalendar1.SelectionRange.Start.ToString(Fecha.dddd);
            DiaNumero = monthCalendar1.SelectionRange.Start.ToString(Fecha.dd);
            Mes = monthCalendar1.SelectionRange.Start.ToString(Fecha.MMMM);
            Anio = monthCalendar1.SelectionRange.Start.ToString(Fecha.yyyy);
        }

        private void CargarFecha()
        {
            lblFecha.Text = DiaNombre + Campo.EspacioSimple + DiaNumero + ", " + Mes + ", " + Anio;
        }

        private void btnAbrir_Click(object sender, System.EventArgs e)
        {
            if (!Calendario)
                MostrarCalendario();
            else
                OcultarCalendario();
        }

        private void MostrarCalendario()
        {
            btnAbrir.Text = PlaceHolder.CerrarCreacionTurno;
            panelCalendario.Visible = true;
            Calendario = true;
        }

        private void OcultarCalendario()
        {
            btnAbrir.Text = PlaceHolder.AbrirCreacionTurno;
            panelCalendario.Visible = false;
            Calendario = false;
        }

        private void GuardarDatos()
        {
            Hora = comboHora.Text;
            Descripcion = txtDescripcion.Text;
            Area = comboArea.Text;
            Establecimiento = comboEstablecimiento.Text;
        }

        private void CargarValoresHorario()
        {
            for (int i = 8; i <= 22; i++)
                comboHora.Items.Add(i);
        }

        private void btnCrearTurno_Click(object sender, System.EventArgs e)
        {
            GuardarDatos();
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            string mensajeError = Campo.Vacio;

            if (string.IsNullOrEmpty(Area))
                mensajeError += Mensajes.ErrorArea + Environment.NewLine;

            if (string.IsNullOrEmpty(Establecimiento))
                mensajeError += Mensajes.ErrorEstablecimiento;

            if (string.IsNullOrEmpty(Area) || string.IsNullOrEmpty(Establecimiento))
                MessageBox.Show(mensajeError);

            if (!string.IsNullOrEmpty(Area) && !string.IsNullOrEmpty(Establecimiento))
                GuardarTurno();
        }

        private void GuardarTurno()
        {
            Cliente cliente = new Cliente();

            cliente.ClienteCrearTurno(DatosUsuario.Id, DiaNombre, DiaNumero, Mes, Anio, Hora, Descripcion, Area, Establecimiento);

            MessageBox.Show(Mensajes.GuardadoTurno);
            VolverAtras();
        }

        private void ValorInicialHorario()
        {
            comboHora.SelectedItem = 8;
        }

        private void btnVolverAtras_Click(object sender, System.EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }

        private void comboArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarEstablecimientos();
            comboEstablecimiento.Enabled = true;
        }
    }
}
