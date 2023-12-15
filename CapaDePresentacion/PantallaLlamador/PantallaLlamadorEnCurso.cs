using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallaLlamador.Componentes;
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

            ListaTurnos = proveedor.ProveedorCargarTurnoEnCurso(DatosUsuario.Id);

            CamposTurno(ListaTurnos);
        }

        private void CamposTurno(List<FormatoTurnos> ListaTurnos)
        {
            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                LlamadorTurnoEnCurso llamadorTurnoEnCurso = new LlamadorTurnoEnCurso();

                llamadorTurnoEnCurso.Nombre = Turno.Nombre;
                llamadorTurnoEnCurso.Lugar = Turno.Lugar;

                flowLayoutPanel1.Controls.Add(llamadorTurnoEnCurso);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            Limpiar();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = proveedor.ProveedorCargarTurnoEnCurso(DatosUsuario.Id);

            CamposTurno(ListaTurnos);
        }

        private void Limpiar()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
