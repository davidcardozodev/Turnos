using CapaComun;
using CapaDeEntidades;
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
        }

        private void CargarTurnoItemModificacion()
        {
            Cliente cliente = new Cliente();

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
            this.Close();
        }
    }
}
