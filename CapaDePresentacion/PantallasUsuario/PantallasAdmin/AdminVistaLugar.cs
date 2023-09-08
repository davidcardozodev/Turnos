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

            DataRow placeHolder = Lugares.NewRow();

            placeHolder[Campo.Nombre] = PlaceHolder.SeleccionarLugar;
            placeHolder[Campo.Id] = 0;

            Lugares.Rows.InsertAt(placeHolder, 0);

            comboLugar.DisplayMember = Campo.Nombre;
            comboLugar.ValueMember = Campo.Id;
            comboLugar.DataSource = Lugares;
            comboLugar.SelectedIndex = 0;
        }

        private void AdminCargarProveedores()
        {
            Admin admin = new Admin();

            DataTable Proveedores = admin.AdminCargarProveedores();

            DataRow placeHolder = Proveedores.NewRow();

            placeHolder[Campo.Nombre] = PlaceHolder.SeleccionarProveedor;
            placeHolder[Campo.Id] = 0;

            Proveedores.Rows.InsertAt(placeHolder, 0);

            comboProveedor.DisplayMember = Campo.Nombre;
            comboProveedor.ValueMember = Campo.Id;
            comboProveedor.DataSource = Proveedores;
            comboProveedor.SelectedIndex = 0;
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
