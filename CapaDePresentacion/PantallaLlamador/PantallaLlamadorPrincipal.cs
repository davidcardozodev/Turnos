using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallaLlamador
{
    public partial class PantallaLlamadorPrincipal : Form
    {
        public PantallaLlamadorPrincipal()
        {
            InitializeComponent();
        }


        #region "Cargar Formulario"

        public void AbrirFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form Formulario = new Form();
            Formulario = panel1.Controls.OfType<MiFormulario>().FirstOrDefault();
            Formulario = CrearFormulario<MiFormulario>(Formulario);
        }

        public Form CrearFormulario<MiFormulario>(Form Formulario) where MiFormulario : Form, new()
        {
            if (Formulario == null)
                Formulario = CargarFormulario<MiFormulario>();
            else
                Formulario.BringToFront();

            return Formulario;
        }

        public Form CargarFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form Formulario = new MiFormulario();

            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;

            panel1.Controls.Add(Formulario);
            panel1.Tag = Formulario;

            Formulario.Show();
            Formulario.BringToFront();

            return Formulario;
        }

        #endregion


        private void btnTurnosEnCurso_Click(object sender, EventArgs e)
        {
            AbrirFormulario<PantallaLlamadorEnCurso>();
        }

        private void btnRegistrarPresencia_Click(object sender, EventArgs e)
        {
            AbrirFormulario<PantallaLlamadorPresencia>();
        }
    }
}
