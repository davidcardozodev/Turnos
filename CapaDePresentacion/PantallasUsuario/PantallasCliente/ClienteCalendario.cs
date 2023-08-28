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
            CargarEstablecimientos();
        }

        #region "Atributos"

        private string DiaNombre { get; set; }
        private string DiaNumero { get; set; }
        private string Mes { get; set; }
        private string Anio { get; set; }

        private bool calendario = false;

        private string Descripcion;
        private string Hora;
        private string Area;
        private string Establecimiento;

        #endregion

        private void CargarAreas()
        {
            Cliente cliente = new Cliente();

            DataTable areas = cliente.ClienteCargarArea();

            foreach (DataRow proveedor in areas.Rows)
                comboArea.Items.Add(proveedor["Nombre"].ToString());
        }

        private void CargarEstablecimientos()
        {
            Cliente cliente = new Cliente();

            DataTable establecimiento = cliente.ClienteCargarEstablecimiento();

            foreach (DataRow proveedor in establecimiento.Rows)
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ActualizarFecha();
            CargarFecha();
        }

        private void ActualizarFecha()
        {
            DiaNombre = monthCalendar1.SelectionRange.Start.ToString("dddd");
            DiaNumero = monthCalendar1.SelectionRange.Start.ToString("dd");
            Mes = monthCalendar1.SelectionRange.Start.ToString("MMMM");
            Anio = monthCalendar1.SelectionRange.Start.ToString("yyyy");
        }

        private void CargarFecha()
        {
            lblFecha.Text = DiaNombre + " " + DiaNumero + ", " + Mes + ", " + Anio;
        }

        private void btnAbrir_Click(object sender, System.EventArgs e)
        {
            if (!calendario)
                MostrarCalendario();
            else
                OcultarCalendario();
        }

        private void MostrarCalendario()
        {
            btnAbrir.Text = "-";
            panelCalendario.Visible = true;
            calendario = true;
        }

        private void OcultarCalendario()
        {
            btnAbrir.Text = "+";
            panelCalendario.Visible = false;
            calendario = false;
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
            Cliente cliente = new Cliente();

            GuardarDatos();

            cliente.TurnoCrear(DatosUsuario.Id, DiaNombre, DiaNumero, Mes, Anio, Hora, Descripcion, Area, Establecimiento);

            MessageBox.Show(Mensajes.GuardadoTurno);
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
    }
}
