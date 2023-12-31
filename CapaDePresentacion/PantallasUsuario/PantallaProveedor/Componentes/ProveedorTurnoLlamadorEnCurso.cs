﻿using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes
{
    public partial class ProveedorTurnoLlamadorEnCurso : UserControl
    {
        public ProveedorTurnoLlamadorEnCurso()
        {
            InitializeComponent();
        }

        private void ProveedorTurnoLlamadorEnCurso_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
            OcultarOpcionFinalizar();
        }

        private void OcultarOpcionFinalizar()
        {
            if (DatosUsuario.Rol == Rol.Llamador)
                btnFinalizar.Visible = false;
        }

        #region "Atributos"

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Lugar { get; set; }

        #endregion

        private void CargarInformacion()
        {
            lblInformacion.Text = Nombre;
            lblLugar.Text = Lugar;
        }

        private void btnFinalizar_Click(object sender, System.EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorFinalizarTurno(Id);

            (Application.OpenForms["ProveedorLlamador"] as ProveedorLlamador).ActualizarTurnos();
        }

        private void ProveedorTurnoLlamadorEnCurso_MouseEnter(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.CambiarColor();
        }

        private void ProveedorTurnoLlamadorEnCurso_MouseLeave(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.RestaurarColor();
        }
    }
}
