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

        public List<FormatoItem> AdminCargarAreaItem()
        {
            return _ConsultasAdmin.AdminCargarAreaItem();
        }

        public List<FormatoItem> AdminCargarAreaItemBusqueda(string Busqueda)
        {
            return _ConsultasAdmin.AdminCargarAreaItemBusqueda(Busqueda);
        }

        public List<FormatoItem> AdminCargarLugarItem()
        {
            return _ConsultasAdmin.AdminCargarLugarItem();
        }

        public List<FormatoItem> AdminCargarLugarItemBusqueda(string Busqueda)
        {
            return _ConsultasAdmin.AdminCargarLugarItemBusqueda(Busqueda);
        }

        public List<FormatoItem> AdminCargarEstablecimientoItem()
        {
            return _ConsultasAdmin.AdminCargarEstablecimientoItem();
        }

        public List<FormatoItem> AdminCargarEstablecimientoItemBusqueda(string Busqueda)
        {
            return _ConsultasAdmin.AdminCargarEstablecimientoItemBusqueda(Busqueda);
        }

        public void AdminModificarUsuario(int IdUsuario, string Usuario, string Clave, string Nombre, string Email, string Rol, string Plan)
        {
            _ConsultasAdmin.AdminModificarUsuario(IdUsuario, Usuario, Clave, Nombre, Email, Rol, Plan);
        }

        public void AdminGuardarDisponibilidad(int IdUsuario, int HorarioInicio, int HorarioFin)
        {
            _ConsultasAdmin.AdminGuardarDisponibilidad(IdUsuario, HorarioInicio, HorarioFin);
        }

        public DataTable AdminCargarProveedores()
        {
            return _ConsultasAdmin.AdminCargarProveedores();
        }

        public DataTable AdminCargarLugares()
        {
            return _ConsultasAdmin.AdminCargarLugares();
        }

        public DataTable AdminCargarEstablecimiento()
        {
            return _ConsultasAdmin.AdminCargarEstablecimiento();
        }

        public DataTable AdminCargarArea()
        {
            return _ConsultasAdmin.AdminCargarArea();
        }

        public void AdminGuardarModificacion(int IdTurno, int IdAdmin, int IdCliente, string DiaNombre, string DiaNumero, string Mes, string Anio, string NombreProveedor)
        {
            _ConsultasAdmin.AdminGuardarModificacion(IdTurno, IdAdmin, IdCliente, DiaNombre, DiaNumero, Mes, Anio, NombreProveedor);
        }

        public void AdminRegistrarUsuario(string NombreUsuario, string Clave, string Nombre, string Email, string Rol, int HorarioInicio, int HorarioFin, string TipoPlan)
        {
            _ConsultasAdmin.AdminRegistrarUsuario(NombreUsuario, Clave, Nombre, Email, Rol, HorarioInicio, HorarioFin, TipoPlan);
        }

        public void AdminRegistrarArea(string Nombre)
        {
            _ConsultasAdmin.AdminRegistrarArea(Nombre);
        }

        public void AdminRegistrarLugar(string Nombre)
        {
            _ConsultasAdmin.AdminRegistrarLugar(Nombre);
        }

        public void AdminRegistrarEstablecimiento(string Nombre)
        {
            _ConsultasAdmin.AdminRegistrarEstablecimiento(Nombre);
        }

        public void AdminGuardarBajaNotificacion(int IdTurno, int IdAdmin, int IdCliente)
        {
            _ConsultasAdmin.AdminGuardarBajaNotificacion(IdTurno, IdAdmin, IdCliente);
        }

        public void AdminAsociarLugar(int IdLugar, int IdProveedor)
        {
            _ConsultasAdmin.AdminAsociarLugar(IdLugar, IdProveedor);
        }

        public void AdminAsociarEstablecimientoArea(int IdEstablecimiento, int IdArea)
        {
            _ConsultasAdmin.AdminAsociarEstablecimientoArea(IdEstablecimiento, IdArea);
        }

        public void AdminModificarArea(int IdArea, string Nombre)
        {
            _ConsultasAdmin.AdminModificarArea(IdArea, Nombre);
        }

        public void AdminModificarLugar(int IdArea, string Nombre)
        {
            _ConsultasAdmin.AdminModificarLugar(IdArea, Nombre);
        }

        public void AdminModificarEstablecimiento(int IdEstablecimiento, string Nombre)
        {
            _ConsultasAdmin.AdminModificarEstablecimiento(IdEstablecimiento, Nombre);
        }

    }
}
