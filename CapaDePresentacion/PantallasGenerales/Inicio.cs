using CapaDeNegocio;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PresentationLayer.GeneralScreens
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        #region "Mover ventana"
        private void MoverVentana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("Usuario32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("Usuario32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion


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

        #endregion

    }
}
