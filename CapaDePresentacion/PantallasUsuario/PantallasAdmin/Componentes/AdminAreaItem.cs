using CapaDeNegocio;
using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    public partial class AdminAreaItem : UserControl
    {
        public AdminAreaItem()
        {
            InitializeComponent();
        }

        public int Id { get; set; }

        public string Nombre { get; set; }

        private void AdminAreaItem_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }
        private void CargarInformacion()
        {
            lblNombre.Text = Nombre;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            AbrirArea();
        }

        private void AbrirArea()
        {
            AdminAreaVistaDetalle adminAreaVistaDetalle = new AdminAreaVistaDetalle();

            adminAreaVistaDetalle.Id = Id;
            adminAreaVistaDetalle.Nombre = Nombre;

            adminAreaVistaDetalle.Show();
        }

        private void AdminAreaItem_MouseEnter(object sender, EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.CambiarColor();
        }

        private void AdminAreaItem_MouseLeave(object sender, EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.RestaurarColor();
        }
    }
}
