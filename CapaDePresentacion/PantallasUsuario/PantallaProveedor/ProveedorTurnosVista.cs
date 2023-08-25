using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor
{
    public partial class ProveedorTurnosVista : Form
    {
        public ProveedorTurnosVista()
        {
            InitializeComponent();
        }

        private void ProveedorTurnosVista_Load(object sender, System.EventArgs e)
        {
            CargarTurnoItem();
        }

        private void CargarTurnoItem()
        {
            Proveedor proveedor = new Proveedor();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = proveedor.ProveedorCargarTurnos(DatosDisponibilidad.HorarioInicio, DatosDisponibilidad.HorarioFin);

            DatosTurno(ListaTurnos);
        }

        private void DatosTurno(List<FormatoTurnos> ListaTurnos)
        {
            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                ProveedorTurnoItem proveedorTurnoItem = new ProveedorTurnoItem();

                proveedorTurnoItem.Id = Turno.Id;
                proveedorTurnoItem.DiaNombre = Turno.DiaNombre;
                proveedorTurnoItem.DiaNumero = Turno.DiaNumero;
                proveedorTurnoItem.Mes = Turno.Mes;
                proveedorTurnoItem.Anio = Turno.Anio;
                proveedorTurnoItem.Hora = Turno.Hora;
                proveedorTurnoItem.Descripcion = Turno.Descripcion;
                proveedorTurnoItem.Estado = Turno.Estado;
                proveedorTurnoItem.Usuario = Turno.Usuario;
                proveedorTurnoItem.PrimerNombre = Turno.PrimerNombre;
                proveedorTurnoItem.SegundoNombre = Turno.SegundoNombre;
                proveedorTurnoItem.PresenciaEstado = Turno.Presencia;
                proveedorTurnoItem.TipoPlan = Turno.TipoPlan;

                flowLayoutPanel1.Controls.Add(proveedorTurnoItem);
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

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            CargarTurnosBusqueda();
        }

        private void CargarTurnosBusqueda()
        {
            Proveedor proveedor = new Proveedor();

            LimpiarLista();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = proveedor.ProveedorCargarTurnosBusqueda(DatosDisponibilidad.HorarioInicio, DatosDisponibilidad.HorarioFin, txtBuscar.Text);

            DatosTurno(ListaTurnos);
        }

        private void LimpiarLista()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
