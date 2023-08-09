using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallasCliente.Componentes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminTurnosVista : Form
    {
        public AdminTurnosVista()
        {
            InitializeComponent();
        }

        private void AdminTurnosVista_Load(object sender, System.EventArgs e)
        {
            CargarTurnoItem();
        }

        private void CargarTurnoItem()
        {
            Admin admin = new Admin();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = admin.TurnoCargarAdmin();

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

                flowLayoutPanel1.Controls.Add(clienteTurnoItem);
            }
        }

    }
}
