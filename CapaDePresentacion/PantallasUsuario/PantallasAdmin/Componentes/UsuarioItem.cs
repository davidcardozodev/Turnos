﻿using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    public partial class UsuarioItem : UserControl
    {
        public UsuarioItem()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }

        private void UsuarioItem_Load(object sender, System.EventArgs e)
        {
            lblUsuario.Text = Usuario;
            lblNombre.Text = PrimerNombre;
            lblApellido.Text = SegundoNombre;
            lblEmail.Text = Email;
            lblRol.Text = Rol;
        }

        private void linkModificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminVistaUsuarioDetalle adminVistaUsuarioDetalle = new AdminVistaUsuarioDetalle();

            adminVistaUsuarioDetalle.Id = Id;
            adminVistaUsuarioDetalle.Usuario = Usuario;
            adminVistaUsuarioDetalle.PrimerNombre = PrimerNombre;
            adminVistaUsuarioDetalle.SegundoNombre = SegundoNombre;
            adminVistaUsuarioDetalle.Email = Email;
            adminVistaUsuarioDetalle.Rol = Rol;

            adminVistaUsuarioDetalle.Show();
        }
    }
}
