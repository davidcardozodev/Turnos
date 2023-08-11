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

            ListaTurnos = proveedor.TurnoCargarProveedor();

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

                flowLayoutPanel1.Controls.Add(proveedorTurnoItem);
            }
        }

        private void btnVolverAtras_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
