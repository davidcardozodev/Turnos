using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminAsociarEstablecimientoArea : Form
    {
        public AdminAsociarEstablecimientoArea()
        {
            InitializeComponent();
        }

        private void AdminAsociarEstablecimientoArea_Load(object sender, EventArgs e)
        {
            CargarEstablecimientos();
            CargarAreas();
        }

        private void CargarEstablecimientos()
        {
            Admin admin = new Admin();

            DataTable Establecimiento = admin.AdminCargarEstablecimiento();

            comboEstablecimiento.DataSource = Establecimiento;
            comboEstablecimiento.DisplayMember = "Nombre";
            comboEstablecimiento.ValueMember = "Id";
        }

        private void CargarAreas()
        {
            Admin admin = new Admin();

            DataTable Area = admin.AdminCargarArea();

            comboArea.DataSource = Area;
            comboArea.DisplayMember = "Nombre";
            comboArea.ValueMember = "Id";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminAsociarEstablecimientoArea((int)comboEstablecimiento.SelectedValue, (int)comboArea.SelectedValue);

            MessageBox.Show(Mensajes.GuardadoCambios);
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
