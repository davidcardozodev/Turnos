using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallaLlamador
{
    public partial class PantallaLlamadorPresencia : Form
    {
        public PantallaLlamadorPresencia()
        {
            InitializeComponent();
        }

        private void PantallaLlamadorPresencia_Load(object sender, EventArgs e)
        {
            RellenarCampos();
        }

        #region "Campos de inicio de sesion"

        private void RellenarCampos()
        {
            txtUsuario.Text = Campo.Usuario;
            txtUsuario.ForeColor = Color.DimGray;
            txtClave.UseSystemPasswordChar = false;
            txtClave.Text = Campo.Clave;
            txtClave.ForeColor = Color.DimGray;
        }

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
            UsuarioIniciarSesion();
        }

        private void VerificarCampos()
        {
            ComprobacionCampo comprobacionCampo = new ComprobacionCampo();
            var ResultadoCampo = comprobacionCampo.VerificarCamposIndividuales(txtUsuario.Text);
            ResultadoCampo = comprobacionCampo.VerificarCamposIndividuales(txtClave.Text);
            ResultadoCampo = comprobacionCampo.VerficarTodosCampos(txtUsuario.Text, txtClave.Text);

            if (ResultadoCampo != Campo.Vacio)
                MensajeError(ResultadoCampo);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }

        private void UsuarioIniciarSesion()
        {
            if (txtUsuario.Text != Campo.Usuario && txtClave.Text != Campo.Clave)
                BusquedaUsuario();
        }

        private void BusquedaUsuario()
        {
            Cliente cliente = new Cliente();

            try
            {
                var loginValido = cliente.ClienteBuscarCoincidencia(txtUsuario.Text, txtClave.Text);
                RegistroValidado(loginValido);
            }
            catch (Exception)
            {
                MessageBox.Show(Mensajes.ErrorDB);
            }
        }

        private void RegistroValidado(bool inicioSesionValidado)
        {
            Cliente cliente = new Cliente();

            if (inicioSesionValidado)
            {
                cliente.ClienteRegistrarPresencia(txtUsuario.Text);
                MessageBox.Show(Mensajes.GuardadoRegistro);
                RellenarCampos();
            }
            else
                MensajeError(Mensajes.ErrorSesion);
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }
    }
}
