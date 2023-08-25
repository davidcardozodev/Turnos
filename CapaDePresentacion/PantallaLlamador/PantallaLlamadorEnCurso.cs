using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallaLlamador
{
    public partial class PantallaLlamadorEnCurso : Form
    {
        public PantallaLlamadorEnCurso()
        {
            InitializeComponent();
        }

        private void PantallaLlamadorPrincipal_Load(object sender, EventArgs e)
        {
            CargarTurnoItemEnCurso();
        }

        public void CargarTurnoItemEnCurso()
        {
            Proveedor proveedor = new Proveedor();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = proveedor.TurnoCargarProveedorEnCurso(DatosUsuario.Id);

            CamposTurno(ListaTurnos);
        }

        private void CamposTurno(List<FormatoTurnos> ListaTurnos)
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
                proveedorTurnoLlamadorEnCurso.PrimerNombre = Turno.PrimerNombre;
                proveedorTurnoLlamadorEnCurso.SegundoNombre = Turno.SegundoNombre;

                flowLayoutPanel1.Controls.Add(proveedorTurnoLlamadorEnCurso);
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }
    }
}
