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

        public List<FormatoTurnos> TurnoCargarEstadoFiltradoAdmin(string Estado)
        {
            return _ConsultasAdmin.TurnoCargarEstadoFiltradoAdmin(Estado);
        }

        public List<DatosUsuarioItem> AdminCargarUsuarioFiltrado(string Rol)
        {
            return _ConsultasAdmin.AdminCargarUsuarioFiltrado(Rol);
        }

        public List<FormatoTurnos> TurnoCargarBusquedaAdmin(string Busqueda)
        {
            return _ConsultasAdmin.TurnoCargarBusquedaAdmin(Busqueda);
        }

        public List<DatosUsuarioItem> AdminCargarUsuarioBusqueda(string Busqueda)
        {
            return _ConsultasAdmin.AdminCargarUsuarioBusqueda(Busqueda);
        }

        public void AdminModificarUsuario(int IdUsuario, string Usuario, string Clave, string PrimerNombre, string SegundoNombre, string Email, string Rol)
        {
            _ConsultasAdmin.AdminModificarUsuario(IdUsuario, Usuario, Clave, PrimerNombre, SegundoNombre, Email, Rol);
        }

        public void AdminGuardarDisponibilidad(int IdUsuario, int HorarioInicio, int HorarioFin)
        {
            _ConsultasAdmin.AdminGuardarDisponibilidad(IdUsuario, HorarioInicio, HorarioFin);
        }

        public DataTable AdminCargarProveedores()
        {
            return _ConsultasAdmin.AdminCargarProveedores();
        }

        public void AdminGuardarProveedor(int IdTurno, string NombreProveedor)
        {
            _ConsultasAdmin.AdminGuardarProveedor(IdTurno, NombreProveedor);
        }

        public void AdminGuardarModificacion(int IdTurno, int IdAdmin, int IdCliente, string DiaNombre, string DiaNumero, string Mes, string Anio, string NombreProveedor)
        {
            _ConsultasAdmin.AdminGuardarModificacion(IdTurno, IdAdmin, IdCliente, DiaNombre, DiaNumero, Mes, Anio, NombreProveedor);
        }

        public void AdminRegistrarUsuario(string NombreUsuario, string Clave, string PrimerNombre, string SegundoNombre, string Email, string Rol, string TipoPlan)
        {
            _ConsultasAdmin.AdminRegistrarUsuario(NombreUsuario, Clave, PrimerNombre, SegundoNombre, Email, Rol, TipoPlan);
        }

        public void AdminGuardarBajaNotificacion(int IdTurno, int IdAdmin, int IdCliente)
        {
            _ConsultasAdmin.AdminGuardarBajaNotificacion(IdTurno, IdAdmin, IdCliente);
        }
    }
}
