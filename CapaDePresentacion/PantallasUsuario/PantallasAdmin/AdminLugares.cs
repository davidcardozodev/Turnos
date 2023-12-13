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

            List<FormatoLugares> Lugares = new List<FormatoLugares>();

            Lugares = admin.AdminCargarLugarItem();

            DatosItem(Lugares);
        }

        private void DatosItem(List<FormatoLugares> Lugares)
        {
            foreach (FormatoLugares Lugar in Lugares)
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

            List<FormatoLugares> Lugares = new List<FormatoLugares>();

            Lugares = admin.AdminCargarLugarItem();

            DatosItem(Lugares);
        }
    }
}
