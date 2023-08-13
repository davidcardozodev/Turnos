using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
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
        }

        private string DiaNombre { get; set; }
        private string DiaNumero { get; set; }
        private string Mes { get; set; }
        private string Anio { get; set; }

        private bool calendario = false;

        private string Descripcion;
        private string Hora;

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

        private void GuardarHoraDescripcion()
        {
            Hora = comboHora.Text;
            Descripcion = txtDescripcion.Text;
        }

        private void CargarValoresHorario()
        {
            for (int i = 8; i <= 22; i++)
                comboHora.Items.Add(i);
        }

        private void btnCrearTurno_Click(object sender, System.EventArgs e)
        {
            Cliente cliente = new Cliente();

            GuardarHoraDescripcion();

            cliente.TurnoCrear(DatosUsuario.Id, DiaNombre, DiaNumero, Mes, Anio, Hora, Descripcion);

            MessageBox.Show(Mensajes.GuardadoTurno);
        }

        private void ValorInicialHorario()
        {
            comboHora.SelectedItem = 8;
        }
    }
}
