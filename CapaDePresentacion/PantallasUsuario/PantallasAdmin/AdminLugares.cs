using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminLugares : Form
    {
        public AdminLugares()
        {
            InitializeComponent();
        }

        private void AdminLugares_Load(object sender, EventArgs e)
        {
            CargarLugarItem();
        }

        public void CargarLugarItem()
        {
            Admin admin = new Admin();

            LimpiarItems();

            List<FormatoItem> Lugares = new List<FormatoItem>();

            Lugares = admin.AdminCargarLugarItem();

            DatosItem(Lugares);
        }

        private void DatosItem(List<FormatoItem> Lugares)
        {
            foreach (FormatoItem Lugar in Lugares)
            {
                AdminLugarItem adminLugarItem = new AdminLugarItem();

                adminLugarItem.Id = Lugar.Id;
                adminLugarItem.Nombre = Lugar.Nombre;

                flowLayoutPanel1.Controls.Add(adminLugarItem);
            }
        }

        private void LimpiarItems()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            LimpiarItems();

            List<FormatoItem> Lugares = new List<FormatoItem>();

            Lugares = admin.AdminCargarLugarItemBusqueda(txtBuscar.Text);

            DatosItem(Lugares);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            LimpiarItems();

            List<FormatoItem> Lugares = new List<FormatoItem>();

            Lugares = admin.AdminCargarLugarItemBusqueda("");

            DatosItem(Lugares);
        }
    }
}
