﻿using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminAreaVistaDetalle : Form
    {
        public AdminAreaVistaDetalle()
        {
            InitializeComponent();
        }

        public int Id { get; set; }

        public string Nombre { get; set; }

        private void AdminAreaVistaDetalle_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtNombre.Text = Nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminModificarArea(Id, txtNombre.Text);

            MessageBox.Show(Mensajes.GuardadoCambios);
        }
    }
}
