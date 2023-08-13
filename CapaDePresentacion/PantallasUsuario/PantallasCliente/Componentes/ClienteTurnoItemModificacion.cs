using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallaTurno;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasCliente.Componentes
{
    public partial class ClienteTurnoItemModificacion : UserControl
    {
        public ClienteTurnoItemModificacion()
        {
            InitializeComponent();
        }


        public int IdTurno { get; set; }
        public string DiaNombre { get; set; }
        public string DiaNumero { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string NombreProveedor { get; set; }



        private void linkTurnoOriginal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CargarTurnoItem();
        }

        private void CargarTurnoItem()
        {
            Cliente cliente = new Cliente();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.TurnoCargarDetalle(IdTurno);

            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                TurnoDetalle turnoDetalle = new TurnoDetalle();

                turnoDetalle.Id = Turno.Id;
                turnoDetalle.DiaNombre = Turno.DiaNombre;
                turnoDetalle.DiaNumero = Turno.DiaNumero;
                turnoDetalle.Mes = Turno.Mes;
                turnoDetalle.Anio = Turno.Anio;
                turnoDetalle.Hora = Turno.Hora;
                turnoDetalle.Descripcion = Turno.Descripcion;
                turnoDetalle.Estado = Turno.Estado;
                turnoDetalle.NombreProveedor = Turno.NombreProveedor;

                turnoDetalle.Show();
            }
        }

        private void ClienteTurnoItemModificacion_Load(object sender, EventArgs e)
        {
            RellenarTextoInformacion();
            DesactivarOpcionesTurnoEstado();
        }

        private void DesactivarOpcionesTurnoEstado()
        {
            if (Estado != "Pendiente")
            {
                btnAceptar.Enabled = false;
                btnRechazar.Enabled = false;
            }
        }

        private void RellenarTextoInformacion()
        {
            lblInformacion.Text = "";

            if (NombreProveedor != "Sin definir")
                lblInformacion.Text += "Nuevo proveedor: " + NombreProveedor + Environment.NewLine;

            if (DiaNombre != "")
                lblInformacion.Text += "Nueva fecha: " + DiaNombre + " " + DiaNumero + " " + Mes + " " + Anio;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.TurnoModificacionAceptar(IdTurno);

            if (NombreProveedor != "Sin definir")
            {
                Cliente clienteTurnoModificacionCambiarProveedor = new Cliente();

                clienteTurnoModificacionCambiarProveedor.TurnoModificacionCambiarProveedor(IdTurno, NombreProveedor);
            }

            if (DiaNombre != "")
            {
                Cliente clienteTurnoModificacionCambiarFecha = new Cliente();

                clienteTurnoModificacionCambiarFecha.TurnoModificacionCambiarFecha(IdTurno, DiaNumero, DiaNombre, Mes, Anio);
            }

            MessageBox.Show("Cambios guardados");
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.TurnoModificacionRechazar(IdTurno);

            MessageBox.Show("Cambios guardados");
        }
    }
}
