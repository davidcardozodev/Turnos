using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallaLlamador.Componentes
{
    public partial class LlamadorTurnoEnCurso : UserControl
    {
        public LlamadorTurnoEnCurso()
        {
            InitializeComponent();
        }

        private void LlamadorTurnoEnCurso_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Nombre;
            lblLugar.Text = Lugar;
        }

        public string Nombre { get; set; }
        public string Lugar { get; set; }
    }
}
