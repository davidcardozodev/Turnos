﻿using CapaDeEntidades;
using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminVistaUsuarioDetalle : Form
    {
        public AdminVistaUsuarioDetalle()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }

        private void AdminVistaUsuarioDetalle_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarDatosUsuario();
            CargarValoresHorarioInicio();
            ValorInicialHorario();
        }

        #region "Horario"

        private void CargarValoresFinHorario()
        {
            for (int i = (int)comboInicio.SelectedItem; i <= 22; i++)
                comboFin.Items.Add(i);
        }

        private void CargarValoresHorarioInicio()
        {
            for (int i = 8; i <= 22; i++)
                comboInicio.Items.Add(i);
        }

        private void ValorInicialHorario()
        {
            comboInicio.SelectedItem = 8;
        }

        private void comboInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarHorarios();
            CargarValoresFinHorario();
        }

        private void LimpiarHorarios()
        {
            comboFin.Items.Clear();
        }

        #endregion

        private void CargarDatosUsuario()
        {
            lblUsuario.Text = PrimerNombre + " " + SegundoNombre + " (" + Usuario + ")";
            lblEmail.Text = Email;
            lblRol.Text = Rol;
        }

        private void CargarRoles()
        {
            comboRol.Items.Add("Cliente");
            comboRol.Items.Add("Proveedor");
            comboRol.Items.Add("Admin");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminModicarUsuario(Id, comboRol.Text);

            Admin adminDisponibilidad = new Admin();

            adminDisponibilidad.AdminGuardarDisponibilidad(Id, int.Parse(comboInicio.Text), int.Parse(comboFin.Text));

            MessageBox.Show("Cambios guardados");
        }
    }
}