using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor
{
    public partial class ProveedorLlamador : Form
    {
        public ProveedorLlamador()
        {
            InitializeComponent();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarTurnoItem()
        {
            Proveedor proveedor = new Proveedor();

            List<FormatoTurnosAdmin> ListaTurnos = new List<FormatoTurnosAdmin>();

            ListaTurnos = proveedor.TurnoCargarProveedorAsignado(DatosUsuario.Id);

            foreach (FormatoTurnosAdmin Turno in ListaTurnos)
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

        private void ProveedorLlamador_Load(object sender, EventArgs e)
        {
            CargarTurnoItem();
        }
    }
}
