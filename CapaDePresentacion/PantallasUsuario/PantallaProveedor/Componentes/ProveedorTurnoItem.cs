﻿using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes
{
    public partial class ProveedorTurnoItem : UserControl
    {
        public ProveedorTurnoItem()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string DiaNombre { get; set; }
        public string DiaNumero { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }

        private void CargarInformacion()
        {
            lblDiaNombre.Text = DiaNombre;
            lblDiaNumero.Text = DiaNumero;
            lblHora.Text = Hora;
            lblCliente.Text = PrimerNombre + " " + SegundoNombre;
        }

        private void ProveedorTurnoItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
        }

        private void linkVerMas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProveedorTurnoDetalle proveedorTurnoDetalle = new ProveedorTurnoDetalle();

            proveedorTurnoDetalle.Id = Id;
            proveedorTurnoDetalle.DiaNombre = DiaNombre;
            proveedorTurnoDetalle.DiaNumero = DiaNumero;
            proveedorTurnoDetalle.Mes = Mes;
            proveedorTurnoDetalle.Anio = Anio;
            proveedorTurnoDetalle.Hora = Hora;
            proveedorTurnoDetalle.Descripcion = Descripcion;
            proveedorTurnoDetalle.Estado = Estado;
            proveedorTurnoDetalle.Usuario = Usuario;
            proveedorTurnoDetalle.PrimerNombre = PrimerNombre;
            proveedorTurnoDetalle.SegundoNombre = SegundoNombre;

            proveedorTurnoDetalle.Show();
        }
    }
}
