using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminVistaLugar : Form
    {
        public AdminVistaLugar()
        {
            InitializeComponent();
        }

        private void AdminVistaLugar_Load(object sender, EventArgs e)
        {
            AdminCargarLugares();
            AdminCargarProveedores();
        }

        private void AdminCargarLugares()
        {
            Admin admin = new Admin();

            DataTable Lugares = admin.AdminCargarLugares();

            comboLugar.DataSource = Lugares;
            comboLugar.DisplayMember = "Nombre";
            comboLugar.ValueMember = "Id";
        }

        private void AdminCargarProveedores()
        {
            Admin admin = new Admin();

            DataTable Proveedores = admin.AdminCargarProveedores();

            comboProveedor.DataSource = Proveedores;
            comboProveedor.DisplayMember = "Nombre";
            comboProveedor.ValueMember = "Id";
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            VolverAtras();
        }

        private void VolverAtras()
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminAsociarLugar((int)comboLugar.SelectedValue, (int)comboProveedor.SelectedValue);

            MessageBox.Show(Mensajes.GuardadoCambios);

            AdminCargarLugares();
            AdminCargarProveedores();
        }
    }
}
