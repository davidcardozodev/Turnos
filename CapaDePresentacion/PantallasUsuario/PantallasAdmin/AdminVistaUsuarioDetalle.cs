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
    }
}
