using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
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
        }

        private void btnVolverAtras_Click(object sender, System.EventArgs e)
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