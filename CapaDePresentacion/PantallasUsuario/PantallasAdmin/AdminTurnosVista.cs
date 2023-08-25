using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes;
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
            CargarEstadosTurno();
        }

        private void CargarEstadosTurno()
        {
            comboEstado.Items.Add("Mostrar todo");
            comboEstado.Items.Add(Estados.Asignado);
            comboEstado.Items.Add(Estados.Cancelado);
            comboEstado.Items.Add(Estados.EnCurso);
            comboEstado.Items.Add(Estados.Pendiente);
            comboEstado.SelectedItem = "Mostrar todo";
        }


        private void CargarTurnoItem()
        {
            Admin admin = new Admin();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = admin.TurnoCargarAdmin();

            DatosTurnos(ListaTurnos);
        }

        private void DatosTurnos(List<FormatoTurnos> ListaTurnos)
        {
            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                AdminTurnoItem adminTurnoItem = new AdminTurnoItem();

                adminTurnoItem.Id = Turno.Id;
                adminTurnoItem.IdCliente = Turno.IdCliente;
                adminTurnoItem.DiaNombre = Turno.DiaNombre;
                adminTurnoItem.DiaNumero = Turno.DiaNumero;
                adminTurnoItem.Mes = Turno.Mes;
                adminTurnoItem.Anio = Turno.Anio;
                adminTurnoItem.Hora = Turno.Hora;
                adminTurnoItem.Descripcion = Turno.Descripcion;
                adminTurnoItem.Estado = Turno.Estado;
                adminTurnoItem.Usuario = Turno.Usuario;
                adminTurnoItem.PrimerNombre = Turno.PrimerNombre;
                adminTurnoItem.SegundoNombre = Turno.SegundoNombre;
                adminTurnoItem.NombreProveedor = Turno.NombreProveedor;

                flowLayoutPanel1.Controls.Add(adminTurnoItem);
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

        private void CargarTurnoEstadoFiltrado()
        {
            Admin admin = new Admin();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = admin.TurnoCargarEstadoFiltradoAdmin(comboEstado.Text);

            DatosTurnos(ListaTurnos);
        }

        private void LimpiarTurnos()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void comboEstado_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboEstado.Text == "Mostrar todo")
                CargarTurnoItem();
            else
                CargarTurnoEstadoFiltrado();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            TurnoCargarBusquedaAdmin();
        }

        private void TurnoCargarBusquedaAdmin()
        {
            Admin admin = new Admin();

            LimpiarTurnos();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = admin.TurnoCargarBusquedaAdmin(txtBuscar.Text);

            DatosTurnos(ListaTurnos);
        }

    }
}
