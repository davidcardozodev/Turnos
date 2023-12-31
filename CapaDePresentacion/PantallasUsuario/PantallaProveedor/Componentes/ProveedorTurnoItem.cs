﻿using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes
{
    public partial class ProveedorTurnoItem : UserControl
    {
        public ProveedorTurnoItem()
        {
            InitializeComponent();
        }

        #region "Atributos"

        public int Id { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string PresenciaEstado { get; set; }
        public string TipoPlan { get; set; }
        string Prioridad;

        #endregion

        private void CargarInformacion()
        {
            lblPresencia.Text = PresenciaEstado;
            lblNombre.Text = Nombre;
            lblHora.Text = Hora + Campo.Hora;
            lblTipoPlan.Text = TipoPlan;
            lblPrioridad.Text = Prioridad;
        }

        private void EstablecerPrioridad()
        {
            switch (TipoPlan)
            {
                case Plan.Basico:
                    Prioridad = Prioridades.Baja;
                    break;
                case Plan.Estandar:
                    Prioridad = Prioridades.Media;
                    break;
                case Plan.Premium:
                    Prioridad = Prioridades.Alta;
                    break;
            }
        }

        private void ProveedorTurnoItem_Load(object sender, System.EventArgs e)
        {
            EstablecerPrioridad();
            CargarInformacion();
            CambiarColorPresencia();
            ActivarOpcionAsignar();
        }

        private void ActivarOpcionAsignar()
        {
            if (PresenciaEstado == Presencia.Presente)
                btnAsignar.Enabled = true;
        }

        private void CambiarColorPresencia()
        {
            SelectorColor selectorColor = new SelectorColor();

            switch (PresenciaEstado)
            {
                case Presencia.Ausente:
                    lblPresencia.ForeColor = selectorColor.Rojo();
                    break;

                case Presencia.Presente:
                    lblPresencia.ForeColor = selectorColor.Verde();
                    break;
            }
        }

        private void btnAsignar_Click(object sender, System.EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorAsignar(DatosUsuario.Id, Id);

            (Application.OpenForms["ProveedorTurnosVista"] as ProveedorTurnosVista).CargarTurnoItem();

            Proveedor proveedor2 = new Proveedor();

            proveedor2.ProveedorGuardarLugar(Id, DatosUsuario.Lugar);

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void ProveedorTurnoItem_MouseEnter(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.CambiarColor();
        }

        private void ProveedorTurnoItem_MouseLeave(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.RestaurarColor();
        }
    }
}
