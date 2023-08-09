using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallasCliente.Componentes;
using System.Collections.Generic;
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
        private void CargarTurnoItem()
        {
            Cliente cliente = new Cliente();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.CargarTurno(DatosUsuario.Id);

            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                ClienteTurnoItem clienteTurnoItem = new ClienteTurnoItem();

                clienteTurnoItem.DiaNombre = Turno.DiaNombre;
                clienteTurnoItem.DiaNumero = Turno.DiaNumero;
                clienteTurnoItem.Hora = Turno.Hora;
                clienteTurnoItem.Descripcion = Turno.Descripcion;
                clienteTurnoItem.Estado = Turno.Estado;

                flowLayoutPanel1.Controls.Add(clienteTurnoItem);
            }
        }
    }
}
