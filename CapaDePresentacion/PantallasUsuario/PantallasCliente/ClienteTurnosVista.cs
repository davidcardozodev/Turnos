using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallasCliente.Componentes;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasCliente
{
    public partial class ClienteTurnosVista : Form
    {
        public ClienteTurnosVista()
        {
            InitializeComponent();
        }

        private void ClienteTurnosVista_Load(object sender, System.EventArgs e)
        {
            CargarTurnoItem();
        }

        #region "Cargar Formulario"

        public void AbrirFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form Formulario = new Form();
            Formulario = panel1.Controls.OfType<MiFormulario>().FirstOrDefault();
            Formulario = CrearFormulario<MiFormulario>(Formulario);
        }

        public Form CrearFormulario<MiFormulario>(Form Formulario) where MiFormulario : Form, new()
        {
            if (Formulario == null)
                Formulario = CargarFormulario<MiFormulario>();
            else
                Formulario.BringToFront();

            return Formulario;
        }

        public Form CargarFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form Formulario = new MiFormulario();

            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;

            panel1.Controls.Add(Formulario);
            panel1.Tag = Formulario;

            Formulario.Show();
            Formulario.BringToFront();

            return Formulario;
        }

        #endregion


        private void CargarTurnoItem()
        {
            Cliente cliente = new Cliente();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.TurnoCargar(DatosUsuario.Id);

            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                ClienteTurnoItem clienteTurnoItem = new ClienteTurnoItem();

                clienteTurnoItem.Id = Turno.Id;
                clienteTurnoItem.DiaNombre = Turno.DiaNombre;
                clienteTurnoItem.DiaNumero = Turno.DiaNumero;
                clienteTurnoItem.Mes = Turno.Mes;
                clienteTurnoItem.Anio = Turno.Anio;
                clienteTurnoItem.Hora = Turno.Hora;
                clienteTurnoItem.Descripcion = Turno.Descripcion;
                clienteTurnoItem.Estado = Turno.Estado;
                clienteTurnoItem.NombreProveedor = Turno.NombreProveedor;


                flowLayoutPanel1.Controls.Add(clienteTurnoItem);
            }
        }

        private void btnVolverAtras_Click(object sender, System.EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }

        private void btnNotificaciones_Click(object sender, System.EventArgs e)
        {
            AbrirFormulario<ClienteTurnosVistaModificacion>();
        }
    }
}
