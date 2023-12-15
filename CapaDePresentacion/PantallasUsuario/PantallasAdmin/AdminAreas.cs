using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminAreas : Form
    {
        public AdminAreas()
        {
            InitializeComponent();
        }

        private void AdminAreas_Load(object sender, System.EventArgs e)
        {
            CargarAreaItem();
        }

        public void CargarAreaItem()
        {
            Admin admin = new Admin();

            LimpiarAreas();

            List<FormatoItem> Areas = new List<FormatoItem>();

            Areas = admin.AdminCargarAreaItem();

            DatosTurnos(Areas);
        }

        private void DatosTurnos(List<FormatoItem> Areas)
        {
            foreach (FormatoItem Area in Areas)
            {
                AdminAreaItem adminAreaItem = new AdminAreaItem();

                adminAreaItem.Id = Area.Id;
                adminAreaItem.Nombre = Area.Nombre;

                flowLayoutPanel1.Controls.Add(adminAreaItem);
            }
        }

        private void LimpiarAreas()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void btnVolverAtras_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            Admin admin = new Admin();

            LimpiarAreas();

            List<FormatoItem> Areas = new List<FormatoItem>();

            Areas = admin.AdminCargarAreaItemBusqueda(txtBuscar.Text);

            DatosTurnos(Areas);
        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            Admin admin = new Admin();

            LimpiarAreas();

            List<FormatoItem> Areas = new List<FormatoItem>();

            Areas = admin.AdminCargarAreaItemBusqueda("");

            DatosTurnos(Areas);
        }
    }
}
