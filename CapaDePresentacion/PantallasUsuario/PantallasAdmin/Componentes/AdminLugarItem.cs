using CapaDeNegocio;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    public partial class AdminLugarItem : UserControl
    {
        public AdminLugarItem()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        private void AdminLugarItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            lblNombre.Text = Nombre;
        }

        private void lblNombre_MouseEnter(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.CambiarColor();
        }

        private void lblNombre_MouseLeave(object sender, System.EventArgs e)
        {
            SelectorColor selectorColor = new SelectorColor();

            this.BackColor = selectorColor.RestaurarColor();
        }

        private void AdminLugarItem_Click(object sender, System.EventArgs e)
        {
            AbrirLugar();
        }

        private void AbrirLugar()
        {
            AdminLugarVistaDetalle adminLugarVistaDetalle = new AdminLugarVistaDetalle();

            adminLugarVistaDetalle.Id = Id;
            adminLugarVistaDetalle.Nombre = Nombre;

            adminLugarVistaDetalle.Show();
        }
    }
}
