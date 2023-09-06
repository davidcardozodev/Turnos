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

        private void ProveedorLlamador_Load(object sender, EventArgs e)
        {
            ActualizarTurnos();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }

        public void CargarTurnoItem()
        {
            Proveedor proveedor = new Proveedor();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = proveedor.ProveedorCargarTurnoAsignado(DatosUsuario.Id);

            CamposTurnoAsignado(ListaTurnos);
        }

        private void CamposTurnoAsignado(List<FormatoTurnos> ListaTurnos)
        {
            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                ProveedorTurnoLlamadorAsignado proveedorTurnoLlamador = new ProveedorTurnoLlamadorAsignado();

                proveedorTurnoLlamador.Id = Turno.Id;
                proveedorTurnoLlamador.DiaNombre = Turno.DiaNombre;
                proveedorTurnoLlamador.DiaNumero = Turno.DiaNumero;
                proveedorTurnoLlamador.Mes = Turno.Mes;
                proveedorTurnoLlamador.Anio = Turno.Anio;
                proveedorTurnoLlamador.Hora = Turno.Hora;
                proveedorTurnoLlamador.Descripcion = Turno.Descripcion;
                proveedorTurnoLlamador.Estado = Turno.Estado;
                proveedorTurnoLlamador.Usuario = Turno.Usuario;
                proveedorTurnoLlamador.Nombre = Turno.Nombre;
                proveedorTurnoLlamador.TipoPlan = Turno.TipoPlan;

                flowLayoutPanel1.Controls.Add(proveedorTurnoLlamador);
            }
        }

        public void CargarTurnoItemEnCurso()
        {
            Proveedor proveedor = new Proveedor();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = proveedor.ProveedorCargarTurnoEnCurso(DatosUsuario.Id);

            CamposTurnoEnCurso(ListaTurnos);
        }

        private void CamposTurnoEnCurso(List<FormatoTurnos> ListaTurnos)
        {
            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                ProveedorTurnoLlamadorEnCurso proveedorTurnoLlamadorEnCurso = new ProveedorTurnoLlamadorEnCurso();

                proveedorTurnoLlamadorEnCurso.Id = Turno.Id;
                proveedorTurnoLlamadorEnCurso.DiaNombre = Turno.DiaNombre;
                proveedorTurnoLlamadorEnCurso.DiaNumero = Turno.DiaNumero;
                proveedorTurnoLlamadorEnCurso.Mes = Turno.Mes;
                proveedorTurnoLlamadorEnCurso.Anio = Turno.Anio;
                proveedorTurnoLlamadorEnCurso.Hora = Turno.Hora;
                proveedorTurnoLlamadorEnCurso.Descripcion = Turno.Descripcion;
                proveedorTurnoLlamadorEnCurso.Estado = Turno.Estado;
                proveedorTurnoLlamadorEnCurso.Usuario = Turno.Usuario;
                proveedorTurnoLlamadorEnCurso.Nombre = Turno.Nombre;
                proveedorTurnoLlamadorEnCurso.Lugar = Turno.Lugar;

                flowLayoutPanel2.Controls.Add(proveedorTurnoLlamadorEnCurso);
            }
        }

        public void ActualizarTurnos()
        {
            LimpiarTurnos();
            CargarTurnoItem();
            CargarTurnoItemEnCurso();
        }

        public void LimpiarTurnos()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
        }
    }
}
