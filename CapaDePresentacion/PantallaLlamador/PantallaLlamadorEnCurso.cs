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

            ListaTurnos = proveedor.ProveedorCargarTurnoEnCurso(DatosUsuario.Id);

            CamposTurno(ListaTurnos);
        }

        private void CamposTurno(List<FormatoTurnos> ListaTurnos)
        {
            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                ProveedorTurnoLlamadorEnCurso proveedorTurnoLlamadorEnCurso = new ProveedorTurnoLlamadorEnCurso();

                proveedorTurnoLlamadorEnCurso.Id = Turno.Id;
                proveedorTurnoLlamadorEnCurso.Usuario = Turno.Usuario;
                proveedorTurnoLlamadorEnCurso.Nombre = Turno.Nombre;
                proveedorTurnoLlamadorEnCurso.Lugar = Turno.Lugar;

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
