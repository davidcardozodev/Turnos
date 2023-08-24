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
            comboEstado.Items.Add("Mostrar todo");
            comboEstado.Items.Add(Estados.Aceptado);
            comboEstado.Items.Add(Estados.Cancelado);
            comboEstado.Items.Add(Estados.Pendiente);
            comboEstado.Items.Add(Estados.Rechazado);
            comboEstado.SelectedItem = "Mostrar todo";
        }


        private void CargarTurnoItemModificacion()
        {
            Cliente cliente = new Cliente();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.TurnoCargarModificacion(DatosUsuario.Id);

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
            if (comboEstado.Text == "Mostrar todo")
                CargarTurnoItemModificacion();
            else
                CargarTurnoModificacionEstadoFiltrado();
        }

        private void CargarTurnoModificacionEstadoFiltrado()
        {
            Turno turno = new Turno();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = turno.TurnoModificacionFiltrarEstado(DatosUsuario.Id, comboEstado.Text);

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

        private void LimpiarTurnos()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
