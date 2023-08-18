using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaDeEntidades
{
    public class Admin
    {
        public Admin() { }

        ConsultasAdmin _ConsultasAdmin = new ConsultasAdmin();

        public List<FormatoTurnos> TurnoCargarAdmin()
        {
            return _ConsultasAdmin.TurnoCargarAdmin();
        }

        public List<DatosUsuarioItem> AdminCargarUsuario()
        {
            return _ConsultasAdmin.AdminCargarUsuario();
        }

        public void AdminModificarUsuario(int idUsuario, string rol)
        {
            _ConsultasAdmin.AdminModificarUsuario(idUsuario, rol);
        }

        public void AdminGuardarDisponibilidad(int idUsuario, int horarioInicio, int horarioFin)
        {
            _ConsultasAdmin.AdminGuardarDisponibilidad(idUsuario, horarioInicio, horarioFin);
        }

        public DataTable AdminCargarProveedores()
        {
            return _ConsultasAdmin.AdminCargarProveedores();
        }

        public void AdminGuardarProveedor(int idTurno, string nombreProveedor)
        {
            _ConsultasAdmin.AdminGuardarProveedor(idTurno, nombreProveedor);
        }

        public void AdminGuardarModificacion(int idTurno, int idAdmin, int idCliente, string diaNombre, string diaNumero, string mes, string anio, string nombreProveedor)
        {
            _ConsultasAdmin.AdminGuardarModificacion(idTurno, idAdmin, idCliente, diaNombre, diaNumero, mes, anio, nombreProveedor);
        }

        public void AdminRegistrarUsuario(string nombreUsuario, string clave, string primerNombre, string segundoNombre, string email, string rol)
        {
            _ConsultasAdmin.AdminRegistrarUsuario(nombreUsuario, clave, primerNombre, segundoNombre, email, rol);
        }
    }
}
