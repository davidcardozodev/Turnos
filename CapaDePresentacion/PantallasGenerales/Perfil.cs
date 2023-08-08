﻿using CapaComun;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallaGenerales
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, System.EventArgs e)
        {
            DatosPerfil();
        }

        private void DatosPerfil()
        {
            lblUsuario.Text = DatosUsuario.Usuario;
            lblPrimerNombre.Text = DatosUsuario.PrimerNombre;
            lblSegundoNombre.Text = DatosUsuario.SegundoNombre;
            lblEmail.Text = DatosUsuario.Email;
            lblRol.Text = DatosUsuario.Rol;
        }
    }
}