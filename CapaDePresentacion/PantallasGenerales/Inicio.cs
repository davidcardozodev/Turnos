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
            if (txtUsuario.Text == Campo.Usuario)
            {
                txtUsuario.Text = Campo.Vacio;
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = Campo.Usuario;
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == Campo.Clave)
            {
                txtClave.Text = Campo.Vacio;
                txtClave.ForeColor = Color.Black;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                txtClave.Text = Campo.Clave;
                txtClave.ForeColor = Color.DimGray;
                txtClave.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region "Campos"

        private void VerificarCampos()
        {
            ComprobacionCampo comprobacionCampo = new ComprobacionCampo();
            var Resultado = comprobacionCampo.VerificarCamposIndividuales(txtUsuario.Text);
            Resultado = comprobacionCampo.VerificarCamposIndividuales(txtClave.Text);
            Resultado = comprobacionCampo.VerficarTodosCampos(txtUsuario.Text, txtClave.Text);

            MensajeError(Resultado);
        }

        private void MensajeError(string Mensaje)
        {
            lblError.Text = Mensaje;
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
                MensajeError(Mensajes.ErrorSesion);
        }

        #endregion

        #region "Acceder"

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
            UsuarioIniciarSesion();
        }

        private void UsuarioIniciarSesion()
        {
            if (txtUsuario.Text != Campo.Usuario && txtClave.Text != Campo.Clave)
                BusquedaUsuario();
        }

        private void BusquedaUsuario()
        {
            Usuario Usuario = new Usuario();

            try
            {
                var loginValido = Usuario.UsuarioIniciarSesion(txtUsuario.Text, txtClave.Text);
                InicioSesionValidado(loginValido);
            }
            catch (Exception)
            {
                MessageBox.Show(Mensajes.ErrorDB);
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
