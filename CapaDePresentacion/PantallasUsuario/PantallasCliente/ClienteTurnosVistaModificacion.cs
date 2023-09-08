using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using CapaDePresentacion.PantallasUsuario.PantallasCliente.Componentes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasCliente
{
    public partial class ClienteTurnosVistaModificacion : Form
    {
        public ClienteTurnosVistaModificacion()
        {
            InitializeComponent();
        }

        private void ClienteTurnosVistaModificacion_Load(object sender, System.EventArgs e)
        {
            CargarTurnoItemModificacion();
            CargarEstadosTurno();
        }

        private void CargarEstadosTurno()
        {
            comboEstado.Items.Add(Campo.MostrarTodo);
            comboEstado.Items.Add(Estados.Aceptado);
            comboEstado.Items.Add(Estados.Cancelado);
            comboEstado.Items.Add(Estados.Pendiente);
            comboEstado.Items.Add(Estados.Rechazado);
            comboEstado.SelectedItem = Campo.MostrarTodo;
        }


        private void CargarTurnoItemModificacion()
        {
            Cliente cliente = new Cliente();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.ClienteCargarTurnoModificacion(DatosUsuario.Id);

            DatosTurno(ListaTurnos);
        }

        private void DatosTurno(List<FormatoTurnos> ListaTurnos)
        {
            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                ClienteTurnoItemModificacion clienteTurnoItemModificacion = new ClienteTurnoItemModificacion();

                clienteTurnoItemModificacion.IdTurno = Turno.Id;
                clienteTurnoItemModificacion.DiaNombre = Turno.DiaNombre;
                clienteTurnoItemModificacion.DiaNumero = Turno.DiaNumero;
                clienteTurnoItemModificacion.Mes = Turno.Mes;
                clienteTurnoItemModificacion.Anio = Turno.Anio;
                clienteTurnoItemModificacion.Hora = Turno.Hora;
                clienteTurnoItemModificacion.Descripcion = Turno.Descripcion;
                clienteTurnoItemModificacion.Estado = Turno.Estado;
                clienteTurnoItemModificacion.NombreProveedor = Turno.NombreProveedor;

                flowLayoutPanel1.Controls.Add(clienteTurnoItemModificacion);
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

        private void comboEstado_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboEstado.Text == Campo.MostrarTodo)
                CargarTurnoItemModificacion();
            else
                CargarTurnoModificacionEstadoFiltrado();
        }

        private void CargarTurnoModificacionEstadoFiltrado()
        {
            Cliente cliente = new Cliente();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.ClienteCargarTurnoModificacionFiltrado(DatosUsuario.Id, comboEstado.Text);

            DatosTurno(ListaTurnos);
        }

        private void LimpiarTurnos()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            ClienteCargarTurnoModificacionBusqueda();
        }

        private void ClienteCargarTurnoModificacionBusqueda()
        {
            Cliente cliente = new Cliente();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.ClienteCargarTurnoModificacionBusqueda(DatosUsuario.Id, txtBuscar.Text);

            DatosTurno(ListaTurnos);
        }

    }
}
