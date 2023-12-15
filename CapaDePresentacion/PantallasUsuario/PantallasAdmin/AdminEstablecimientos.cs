using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminEstablecimientos : Form
    {
        public AdminEstablecimientos()
        {
            InitializeComponent();
        }


        public void AdminCargarEstablecimientoItem()
        {
            Admin admin = new Admin();

            LimpiarItems();

            List<FormatoItem> Establecimientos = new List<FormatoItem>();

            Establecimientos = admin.AdminCargarEstablecimientoItem();

            DatosItem(Establecimientos);
        }

        private void DatosItem(List<FormatoItem> Establecimientos)
        {
            foreach (FormatoItem Establecimiento in Establecimientos)
            {
                AdminEstablecimientoItem adminEstablecimientoItem = new AdminEstablecimientoItem();

                adminEstablecimientoItem.Id = Establecimiento.Id;
                adminEstablecimientoItem.Nombre = Establecimiento.Nombre;

                flowLayoutPanel1.Controls.Add(adminEstablecimientoItem);
            }
        }

        private void LimpiarItems()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            LimpiarItems();

            List<FormatoItem> Establecimientos = new List<FormatoItem>();

            Establecimientos = admin.AdminCargarEstablecimientoItemBusqueda(txtBuscar.Text);

            DatosItem(Establecimientos);
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminEstablecimientos_Load(object sender, EventArgs e)
        {
            AdminCargarEstablecimientoItem();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            LimpiarItems();

            List<FormatoItem> Establecimientos = new List<FormatoItem>();

            Establecimientos = admin.AdminCargarEstablecimientoItemBusqueda("");

            DatosItem(Establecimientos);
        }
    }
}
