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
                ProveedorTurnoLlamador proveedorTurnoLlamador = new ProveedorTurnoLlamador();

                proveedorTurnoLlamador.Id = Turno.Id;
                proveedorTurnoLlamador.DiaNombre = Turno.DiaNombre;
                proveedorTurnoLlamador.DiaNumero = Turno.DiaNumero;
                proveedorTurnoLlamador.Mes = Turno.Mes;
                proveedorTurnoLlamador.Anio = Turno.Anio;
                proveedorTurnoLlamador.Hora = Turno.Hora;
                proveedorTurnoLlamador.Descripcion = Turno.Descripcion;
                proveedorTurnoLlamador.Estado = Turno.Estado;
                proveedorTurnoLlamador.Usuario = Turno.Usuario;
                proveedorTurnoLlamador.PrimerNombre = Turno.PrimerNombre;
                proveedorTurnoLlamador.SegundoNombre = Turno.SegundoNombre;

                flowLayoutPanel1.Controls.Add(proveedorTurnoLlamador);
            }
        }

        private void ProveedorLlamador_Load(object sender, EventArgs e)
        {
            CargarTurnoItem();
        }
    }
}
