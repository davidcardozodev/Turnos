using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasGenerales
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        #region "Campos de inicio de sesion"
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Clave")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.Black;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "Clave";
                txtClave.ForeColor = Color.DimGray;
                txtClave.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region "Campos"

        private void VerificarCampos()
        {
            Campo campo = new Campo();
            var Result = campo.VerificarCamposIndividuales(txtUsuario.Text);
            Result = campo.VerificarCamposIndividuales(txtClave.Text);
            Result = campo.VerficarTodosCampos(txtUsuario.Text, txtClave.Text);

            MensajeError(Result);
        }

        private void MensajeError(string Mensaje)
        {
            lblError.Text = "Error: " + Mensaje;
            lblError.Visible = true;
        }

        private void LimpiarPantallaInicio(object sender, FormClosedEventArgs e)
        {
            txtClave.Clear();
            txtUsuario.Clear();
            lblError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void InicioSesionValidado(bool inicioSesionValidado)
        {
            if (inicioSesionValidado)
            {
                this.Hide();
                CrearInterfazUsuario();
            }
            else
                MensajeError("Usuario o Clave incorrecta");
        }

        #endregion

        #region "Acceder"

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            if (txtUsuario.Text != "Usuario" && txtClave.Text != "Clave")
                BusquedaUsuario();
        }

        private void BusquedaUsuario()
        {
            Usuario usuario = new Usuario();

            try
            {
                var loginValido = usuario.IniciarSesion(txtUsuario.Text, txtClave.Text);
                InicioSesionValidado(loginValido);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No se encontro la base de datos o el procedimiento almacenado");
            }
        }

        private void CrearInterfazUsuario()
        {
            PantallaGeneralUsuario interfazUsuario = new PantallaGeneralUsuario();
            interfazUsuario.Show();
            interfazUsuario.FormClosed += LimpiarPantallaInicio;
        }


        #endregion
    }
}
