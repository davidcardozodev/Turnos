﻿using CapaComun;
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

        #region "Atributos"

        public int IdTurno { get; set; }
        public string DiaNombre { get; set; }
        public string DiaNumero { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string NombreProveedor { get; set; }

        private string Espacio = "   ";

        #endregion

        #region "Cargar informacion"

        private void ClienteTurnoItemModificacion_Load(object sender, EventArgs e)
        {
            RellenarTextoInformacion();
            DesactivarOpcionesTurnoEstado();
            CambiarColorEstado();
            MostrarNotificacionBaja();
        }

        private void RellenarTextoInformacion()
        {
            lblInformacion.Text = "";
            lblEstado.Text = Estado;
            RellenarInformacionProveedor();
            RellenarInformacionFecha();
        }

        private void RellenarInformacionFecha()
        {
            string de = " de ";


            if (DiaNombre != "")
                lblInformacion.Text += DiaNombre + " " + DiaNumero + de + Mes + de + Anio + Espacio;
        }

        private void RellenarInformacionProveedor()
        {
            if (NombreProveedor != Estados.SinDefinir)
                lblInformacion.Text += NombreProveedor + Espacio;
        }

        private void CargarTurnoItem()
        {
            Cliente cliente = new Cliente();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = cliente.ClienteCargarTurnoDetalle(IdTurno);

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

        #endregion

        private void linkTurnoOriginal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CargarTurnoItem();
        }

        private void DesactivarOpcionesTurnoEstado()
        {
            if (Estado != Estados.Pendiente)
            {
                btnAceptar.Enabled = false;
                btnRechazar.Enabled = false;
            }
        }

        private void MostrarNotificacionBaja()
        {
            if (Estado == Estados.Cancelado)
                lblInformacion.Text = "Dado de baja por el administrador";
        }

        #region "Aceptar cambios"

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.ClienteTurnoModificacionAceptar(IdTurno);
            CambiarProveedor();
            CambiarFecha();

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void CambiarFecha()
        {
            if (DiaNombre != "")
            {
                Cliente clienteTurnoModificacionCambiarFecha = new Cliente();

                clienteTurnoModificacionCambiarFecha.ClienteTurnoModificacionCambiarFecha(IdTurno, DiaNumero, DiaNombre, Mes, Anio);
            }
        }

        private void CambiarProveedor()
        {
            if (NombreProveedor != Estados.SinDefinir)
            {
                Cliente clienteClienteTurnoModificacionCambiarProveedor = new Cliente();

                clienteClienteTurnoModificacionCambiarProveedor.ClienteTurnoModificacionCambiarProveedor(IdTurno, NombreProveedor);
            }
        }

        #endregion

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.ClienteTurnoModificacionRechazar(IdTurno);

            MessageBox.Show(Mensajes.GuardadoCambios);
        }

        private void CambiarColorEstado()
        {
            SelectorColor selectorColor = new SelectorColor();

            switch (Estado)
            {
                case Estados.Rechazado:
                case Estados.Cancelado:
                    lblEstado.ForeColor = selectorColor.Rojo();
                    break;
                case Estados.Aceptado:
                    lblEstado.ForeColor = selectorColor.Verde();
                    break;
                case Estados.Pendiente:
                    lblEstado.ForeColor = selectorColor.Azul();
                    break;
            }
        }

        private void ClienteTurnoItemModificacion_MouseEnter(object sender, EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.CambiarColor();
        }

        private void ClienteTurnoItemModificacion_MouseLeave(object sender, EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.RestaurarColor();
        }
    }
}
