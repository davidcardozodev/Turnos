using CapaComun;
using CapaDeEntidades;
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
        }

        private void btnVolverAtras_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #region "Datos del turno"

        string anio, mes, diaNombre, diaNumero, hora, descripcion;

        private void CargarHorarios()
        {
            comboHora.Items.Add("08:00");
            comboHora.Items.Add("09:00");
            comboHora.Items.Add("10:00");
            comboHora.Items.Add("11:00");
            comboHora.Items.Add("12:00");
            comboHora.Items.Add("13:00");
            comboHora.Items.Add("14:00");
            comboHora.Items.Add("15:00");
            comboHora.Items.Add("16:00");
            comboHora.Items.Add("17:00");
            comboHora.Items.Add("18:00");
            comboHora.Items.Add("19:00");
            comboHora.Items.Add("20:00");
            comboHora.Items.Add("21:00");
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

            MessageBox.Show("Turno guardado");
        }
    }
}