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
            txtUsuario.Text = "Usuario";
            txtUsuario.ForeColor = Color.DimGray;
            txtClave.UseSystemPasswordChar = false;
            txtClave.Text = "Clave";
            txtClave.ForeColor = Color.DimGray;
        }

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
            UsuarioIniciarSesion();
        }

        private void VerificarCampos()
        {
            Campo campo = new Campo();
            var Result = campo.VerificarCamposIndividuales(txtUsuario.Text);
            Result = campo.VerificarCamposIndividuales(txtClave.Text);
            Result = campo.VerficarTodosCampos(txtUsuario.Text, txtClave.Text);

            if (Result != "")
                MensajeError(Result);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show("Error: " + Mensaje);
        }

        private void UsuarioIniciarSesion()
        {
            if (txtUsuario.Text != "Usuario" && txtClave.Text != "Clave")
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
                MessageBox.Show("Se registro correctamente");
                RellenarCampos();
            }
            else
                MensajeError("Usuario o Clave incorrecta");
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
