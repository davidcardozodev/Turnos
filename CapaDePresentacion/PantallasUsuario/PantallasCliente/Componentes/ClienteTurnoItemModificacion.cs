using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using CapaDePresentacion.PantallaTurno;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            CambiarColorEstado();
        }

        private void DesactivarOpcionesTurnoEstado()
        {
            if (Estado != Estados.Pendiente)
            {
                btnAceptar.Visible = false;
                btnRechazar.Visible = false;
            }

            if (Estado == Estados.Cancelado)
            {
                lblInformacion.Text = "Dado de baja por el administrador";
                lblEstado.Visible = false;
            }
        }

        private void RellenarTextoInformacion()
        {
            lblInformacion.Text = "";
            lblEstado.Text = Estado;

            if (NombreProveedor != Estados.SinDefinir)
                lblInformacion.Text += "Nuevo proveedor: " + NombreProveedor + Environment.NewLine;

            if (DiaNombre != "")
                lblInformacion.Text += "Nueva fecha: " + DiaNombre + " " + DiaNumero + " " + Mes + " " + Anio;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.TurnoModificacionAceptar(IdTurno);

            if (NombreProveedor != Estados.SinDefinir)
            {
                Cliente clienteTurnoModificacionCambiarProveedor = new Cliente();

                clienteTurnoModificacionCambiarProveedor.TurnoModificacionCambiarProveedor(IdTurno, NombreProveedor);
            }

            if (DiaNombre != "")
            {
                Cliente clienteTurnoModificacionCambiarFecha = new Cliente();

                clienteTurnoModificacionCambiarFecha.TurnoModificacionCambiarFecha(IdTurno, DiaNumero, DiaNombre, Mes, Anio);
            }

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.TurnoModificacionRechazar(IdTurno);

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void CambiarColorEstado()
        {
            switch (Estado)
            {
                case Estados.Rechazado:
                case Estados.Cancelado:
                    lblEstado.ForeColor = Color.FromArgb(255, 0, 0);
                    lblInformacion.ForeColor = Color.FromArgb(255, 0, 0);
                    break;
                case Estados.Aceptado:
                    lblEstado.ForeColor = Color.FromArgb(0, 255, 0);
                    break;
                case Estados.Pendiente:
                    lblEstado.ForeColor = Color.FromArgb(0, 0, 255);
                    break;
            }
        }

    }
}
