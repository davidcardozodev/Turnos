using CapaDeNegocio;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    public partial class AdminEstablecimientoItem : UserControl
    {
        public AdminEstablecimientoItem()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }


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

        private void AbrirEstablecimiento()
        {
            AdminEstablecimientoVistaDetalle adminEstablecimientoVistaDetalle = new AdminEstablecimientoVistaDetalle();

            adminEstablecimientoVistaDetalle.Id = Id;
            adminEstablecimientoVistaDetalle.Nombre = Nombre;

            adminEstablecimientoVistaDetalle.Show();
        }

        private void AdminEstablecimientoItem_Load(object sender, System.EventArgs e)
        {
            CargarInformacion();
        }

        private void lblNombre_Click(object sender, System.EventArgs e)
        {
            AbrirEstablecimiento();
        }
    }
}
