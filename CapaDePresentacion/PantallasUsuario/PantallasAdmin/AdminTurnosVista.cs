using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    public partial class AdminTurnosVista : Form
    {
        public AdminTurnosVista()
        {
            InitializeComponent();
        }

        private void AdminTurnosVista_Load(object sender, System.EventArgs e)
        {
            CargarTurnoItem();
        }

        private void CargarTurnoItem()
        {
            Admin admin = new Admin();

            List<FormatoTurnos> ListaTurnos = new List<FormatoTurnos>();

            ListaTurnos = admin.TurnoCargarAdmin();

            foreach (FormatoTurnos Turno in ListaTurnos)
            {
                AdminTurnoItem adminTurnoItem = new AdminTurnoItem();

                adminTurnoItem.Id = Turno.Id;
                adminTurnoItem.IdCliente = Turno.IdCliente;
                adminTurnoItem.DiaNombre = Turno.DiaNombre;
                adminTurnoItem.DiaNumero = Turno.DiaNumero;
                adminTurnoItem.Mes = Turno.Mes;
                adminTurnoItem.Anio = Turno.Anio;
                adminTurnoItem.Hora = Turno.Hora;
                adminTurnoItem.Descripcion = Turno.Descripcion;
                adminTurnoItem.Estado = Turno.Estado;
                adminTurnoItem.Usuario = Turno.Usuario;
                adminTurnoItem.PrimerNombre = Turno.PrimerNombre;
                adminTurnoItem.SegundoNombre = Turno.SegundoNombre;
                adminTurnoItem.NombreProveedor = Turno.NombreProveedor;

                flowLayoutPanel1.Controls.Add(adminTurnoItem);
            }
        }

        private void btnVolverAtras_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
