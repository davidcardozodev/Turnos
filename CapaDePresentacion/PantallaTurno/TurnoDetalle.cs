using CapaComun;
using CapaDeEntidades;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallaTurno
{
    public partial class TurnoDetalle : Form
    {
        public TurnoDetalle()
        {
            InitializeComponent();
        }

        private void TurnoDetalle_Load(object sender, EventArgs e)
        {
            CargarInformacion();
            CambiarColorEstado();
            OcultarEtiquetas();
            ActivarOpcionAsignarProveedor();
            OcultarOpcionDarBaja();
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            if (DatosUsuario.Rol == Roles.rolAdmin)
            {
                ActivarOpcionProveedores();

                Admin admin = new Admin();

                DataTable proveedores = new DataTable();

                proveedores = admin.AdminCargarProveedores();

                foreach (DataRow proveedor in proveedores.Rows)
                    comboProveedores.Items.Add(proveedor["PrimerNombre"].ToString() + " " + proveedor["SegundoNombre"].ToString());
            }
        }

        private void ActivarOpcionProveedores()
        {
            comboProveedores.Visible = true;
            lblCambiarProveedor.Visible = true;
            btnGuardar.Visible = true;
        }

        private void OcultarOpcionDarBaja()
        {
            if (DatosUsuario.Rol == Roles.rolProveedor)
                btnDarDeBaja.Visible = false;
        }

        private void ActivarOpcionAsignarProveedor()
        {
            if (DatosUsuario.Rol == Roles.rolProveedor)
                btnAsignar.Visible = true;
        }

        private void OcultarEtiquetas()
        {
            switch (DatosUsuario.Rol)
            {
                case Roles.rolCliente:
                    lblUsuario.Visible = false;
                    lblUsuarioCategoria.Visible = false;
                    break;
                case Roles.rolProveedor:
                    lblProveedor.Visible = false;
                    lblProveedorCategoria.Visible = false;
                    break;
            }
        }

        public int Id { get; set; }
        public string DiaNombre { get; set; }
        public string DiaNumero { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string NombreProveedor { get; set; }


        private void CargarInformacion()
        {
            lblFecha.Text = DiaNombre + " " + DiaNumero + ", " + Mes + ", " + Anio;
            lblUsuario.Text = PrimerNombre + " " + SegundoNombre + " (" + Usuario + ")";
            lblHora.Text = Hora + ":00hs";
            rtxtDecripcion.Text = Descripcion;
            lblEstado.Text = Estado;
            lblProveedor.Text = NombreProveedor;
        }

        private void btnDarDeBaja_Click(object sender, System.EventArgs e)
        {
            Turno turno = new Turno();

            turno.TurnoDarBaja(Id);
        }

        private void CambiarColorEstado()
        {
            switch (Estado)
            {
                case "Cancelado":
                    lblEstado.ForeColor = Color.FromArgb(255, 0, 0);
                    break;
                case "Finalizado":
                    lblEstado.ForeColor = Color.FromArgb(0, 255, 0);
                    break;
                case "Pendiente":
                case "Asignado":
                case "EnCurso":
                    lblEstado.ForeColor = Color.FromArgb(0, 0, 255);
                    break;
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorAsignar(DatosUsuario.Id, Id);

            MessageBox.Show("Cambios guardados");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminGuardarProveedor(Id, comboProveedores.Text);

            MessageBox.Show("Cambios guardados");
        }
    }
}
