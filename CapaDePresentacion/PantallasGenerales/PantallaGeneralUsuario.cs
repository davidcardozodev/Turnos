﻿using CapaComun;
using CapaDeNegocio;
using CapaDePresentacion.PantallaGenerales;
using CapaDePresentacion.PantallaLlamador;
using CapaDePresentacion.PantallasUsuario.PantallaProveedor;
using CapaDePresentacion.PantallasUsuario.PantallasAdmin;
using CapaDePresentacion.PantallasUsuario.PantallasCliente;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasGenerales
{
    public partial class PantallaGeneralUsuario : Form
    {
        public PantallaGeneralUsuario()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        #region "Cargar Formulario"

        private void AbrirFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form Formulario = new Form();
            Formulario = panelForm.Controls.OfType<MiFormulario>().FirstOrDefault();
            Formulario = CrearFormulario<MiFormulario>(Formulario);
        }

        private Form CrearFormulario<MiFormulario>(Form Formulario) where MiFormulario : Form, new()
        {
            if (Formulario == null)
                Formulario = CargarFormulario<MiFormulario>();
            else
                Formulario.BringToFront();

            return Formulario;
        }

        private Form CargarFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form Formulario = new MiFormulario();

            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;

            panelForm.Controls.Add(Formulario);
            panelForm.Tag = Formulario;

            Formulario.Show();
            Formulario.BringToFront();

            return Formulario;
        }

        #endregion

        #region "Cargar datos principales"

        private void PantallaGeneralUsuario_Load(object sender, EventArgs e)
        {
            CargarNombreUsuario();
            CargarPantallaUsuario();
        }

        private void CargarPantallaUsuario()
        {
            if (DatosUsuario.Rol == Rol.Cliente)
                AbrirFormulario<ClienteTurnosVista>();

            if (DatosUsuario.Rol == Rol.Admin)
                AbrirFormulario<AdminPrincipal>();

            if (DatosUsuario.Rol == Rol.Proveedor)
                AbrirFormulario<ProveedorPrincipal>();

            if (DatosUsuario.Rol == Rol.Llamador)
                AbrirFormulario<PantallaLlamadorPrincipal>();
        }

        #endregion

        #region "Cargar pantalla generica"

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CargarPantallaPerfil();
        }

        private void CargarPantallaPerfil()
        {
            AbrirFormulario<Perfil>();
        }

        private void CargarNombreUsuario()
        {
            linkPerfil.Text = DatosUsuario.Nombre;
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CerrarForm();
        }

        private void CerrarForm()
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }

        #endregion


    }
}