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

            DataRow placeHolder = Establecimiento.NewRow();
            placeHolder[Campo.Nombre] = PlaceHolder.SeleccionarEstablecimiento;
            placeHolder[Campo.Id] = 0;

            Establecimiento.Rows.InsertAt(placeHolder, 0);

            comboEstablecimiento.DisplayMember = Campo.Nombre;
            comboEstablecimiento.ValueMember = Campo.Id;
            comboEstablecimiento.DataSource = Establecimiento;
            comboEstablecimiento.SelectedIndex = 0;
        }

        private void CargarAreas()
        {
            Admin admin = new Admin();

            DataTable Area = admin.AdminCargarArea();

            DataRow placeHolder = Area.NewRow();
            placeHolder[Campo.Nombre] = PlaceHolder.SeleccionarArea;
            placeHolder[Campo.Id] = 0;

            Area.Rows.InsertAt(placeHolder, 0);

            comboArea.DisplayMember = Campo.Nombre;
            comboArea.ValueMember = Campo.Id;
            comboArea.DataSource = Area;
            comboArea.SelectedIndex = 0;
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
