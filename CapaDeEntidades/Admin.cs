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

        public List<FormatoTurnos> AdminCargarTurno()
        {
            return _ConsultasAdmin.AdminCargarTurno();
        }

        public List<DatosUsuarioItem> AdminCargarUsuario()
        {
            return _ConsultasAdmin.AdminCargarUsuario();
        }

        public List<FormatoTurnos> AdminCargarTurnoEstadoFiltrado(string Estado)
        {
            return _ConsultasAdmin.AdminCargarTurnoEstadoFiltrado(Estado);
        }

        public List<DatosUsuarioItem> AdminCargarUsuarioFiltrado(string Rol)
        {
            return _ConsultasAdmin.AdminCargarUsuarioFiltrado(Rol);
        }

        public List<FormatoTurnos> AdminCargarTurnoBusqueda(string Busqueda)
        {
            return _ConsultasAdmin.AdminCargarTurnoBusqueda(Busqueda);
        }

        public List<DatosUsuarioItem> AdminCargarUsuarioBusqueda(string Busqueda)
        {
            return _ConsultasAdmin.AdminCargarUsuarioBusqueda(Busqueda);
        }

        public void AdminModificarUsuario(int IdUsuario, string Usuario, string Clave, string PrimerNombre, string SegundoNombre, string Email, string Rol, string Plan)
        {
            _ConsultasAdmin.AdminModificarUsuario(IdUsuario, Usuario, Clave, PrimerNombre, SegundoNombre, Email, Rol, Plan);
        }

        public void AdminGuardarDisponibilidad(int IdUsuario, int HorarioInicio, int HorarioFin)
        {
            _ConsultasAdmin.AdminGuardarDisponibilidad(IdUsuario, HorarioInicio, HorarioFin);
        }

        public DataTable AdminCargarProveedores()
        {
            return _ConsultasAdmin.AdminCargarProveedores();
        }

        public void AdminGuardarModificacion(int IdTurno, int IdAdmin, int IdCliente, string DiaNombre, string DiaNumero, string Mes, string Anio, string NombreProveedor)
        {
            _ConsultasAdmin.AdminGuardarModificacion(IdTurno, IdAdmin, IdCliente, DiaNombre, DiaNumero, Mes, Anio, NombreProveedor);
        }

        public void AdminRegistrarUsuario(string NombreUsuario, string Clave, string PrimerNombre, string SegundoNombre, string Email, string Rol, int HorarioInicio, int HorarioFin, string TipoPlan)
        {
            _ConsultasAdmin.AdminRegistrarUsuario(NombreUsuario, Clave, PrimerNombre, SegundoNombre, Email, Rol, HorarioInicio, HorarioFin, TipoPlan);
        }

        public void AdminGuardarBajaNotificacion(int IdTurno, int IdAdmin, int IdCliente)
        {
            _ConsultasAdmin.AdminGuardarBajaNotificacion(IdTurno, IdAdmin, IdCliente);
        }
    }
}
