using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
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
            CargarEstadosTurno();
        }

        private void CargarEstadosTurno()
        {
            comboEstado.Items.Add(Campo.MostrarTodo);
            comboEstado.Items.Add(Estados.Asignado);
            comboEstado.Items.Add(Estados.Cancelado);
            comboEstado.Items.Add(Estados.EnCurso);
            comboEstado.Items.Add(Estados.Pendiente);
            comboEstado.SelectedItem = Campo.MostrarTodo;
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


        public void CargarTurnoItem()
        {
            Cliente cliente = new Cliente();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.ClienteCargarTurno(DatosUsuario.Id);

            DatosTurno(ListaTurnos);
        }

        private void DatosTurno(List<FormatoTurnos> ListaTurnos)
        {
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

        private void comboEstado_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboEstado.Text == Campo.MostrarTodo)
                CargarTurnoItem();
            else
                CargarTurnoEstadoFiltrado();
        }

        private void CargarTurnoEstadoFiltrado()
        {
            Cliente cliente = new Cliente();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.ClienteCargarTurnoFiltrado(DatosUsuario.Id, comboEstado.Text);

            DatosTurno(ListaTurnos);
        }

        private void LimpiarTurnos()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            ClienteCargarTurnoBusqueda();
        }

        private void ClienteCargarTurnoBusqueda()
        {
            Cliente cliente = new Cliente();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.ClienteCargarTurnoBusqueda(DatosUsuario.Id, txtBuscar.Text);

            DatosTurno(ListaTurnos);
        }

        private void btnCrearTurno_Click(object sender, System.EventArgs e)
        {
            AbrirFormulario<ClienteCreacionTurno>();
        }

        private void btnCalendario_Click(object sender, System.EventArgs e)
        {
            AbrirFormulario<ClienteCalendario>();
        }
    }
}
