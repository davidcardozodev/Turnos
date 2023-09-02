using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaDeEntidades
{
    public class Cliente
    {
        public Cliente() { }

        private ConsultasCliente _ConsultasCliente = new ConsultasCliente();

        public List<FormatoTurnos> ClienteCargarTurno(int IdCliente)
        {
            return _ConsultasCliente.ClienteCargarTurno(IdCliente);
        }

        public List<FormatoTurnos> ClienteCargarTurnoDetalle(int IdTurno)
        {
            return _ConsultasCliente.ClienteCargarTurnoDetalle(IdTurno);
        }

        public List<FormatoTurnos> ClienteCargarTurnoModificacion(int IdCliente)
        {
            return _ConsultasCliente.ClienteCargarTurnoModificacion(IdCliente);
        }

        public List<FormatoTurnos> ClienteCargarTurnoBusqueda(int IdCliente, string Busqueda)
        {
            return _ConsultasCliente.ClienteCargarTurnoBusqueda(IdCliente, Busqueda);
        }

        public List<FormatoTurnos> ClienteCargarTurnoModificacionBusqueda(int IdCliente, string Busqueda)
        {
            return _ConsultasCliente.ClienteCargarTurnoModificacionBusqueda(IdCliente, Busqueda);
        }

        public void ClienteCrearTurno(int IdCliente, string DiaNombre, string DiaNumero, string Mes, string Anio, string Hora, string Descripcion, string Area, string Establecimiento)
        {
            _ConsultasCliente.ClienteCrearTurno(IdCliente, DiaNombre, DiaNumero, Mes, Anio, Hora, Descripcion, Area, Establecimiento);
        }

        public void ClienteTurnoModificacionAceptar(int IdTurno)
        {
            _ConsultasCliente.ClienteTurnoModificacionAceptar(IdTurno);
        }

        public void ClienteTurnoModificacionCambiarFecha(int IdTurno, string DiaNumero, string DiaNombre, string Mes, string Anio)
        {
            _ConsultasCliente.ClienteTurnoModificacionCambiarFecha(IdTurno, DiaNumero, DiaNombre, Mes, Anio);
        }

        public void ClienteTurnoModificacionCambiarProveedor(int IdTurno, string NombreProveedor)
        {
            _ConsultasCliente.ClienteTurnoModificacionCambiarProveedor(IdTurno, NombreProveedor);
        }

        public void ClienteTurnoModificacionRechazar(int IdTurno)
        {
            _ConsultasCliente.ClienteTurnoModificacionRechazar(IdTurno);
        }

        public bool ClienteBuscarCoincidencia(string Usuario, string Clave)
        {
            return _ConsultasCliente.ClienteBuscarCoincidencia(Usuario, Clave);
        }

        public void ClienteRegistrarPresencia(string Usuario)
        {
            _ConsultasCliente.ClienteRegistrarPresencia(Usuario);
        }

        public DataTable ClienteCargarArea()
        {
            return _ConsultasCliente.ClienteCargarArea();
        }

        public DataTable ClienteCargarEstablecimiento()
        {
            return _ConsultasCliente.ClienteCargarEstablecimiento();
        }
    }
}
