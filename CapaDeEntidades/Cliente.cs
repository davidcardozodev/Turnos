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

        public List<FormatoTurnos> TurnoCargar(int IdCliente)
        {
            return _ConsultasCliente.TurnoCargar(IdCliente);
        }

        public List<FormatoTurnos> TurnoCargarDetalle(int IdTurno)
        {
            return _ConsultasCliente.TurnoCargarDetalle(IdTurno);
        }

        public List<FormatoTurnos> TurnoCargarModificacion(int IdCliente)
        {
            return _ConsultasCliente.TurnoCargarModificacion(IdCliente);
        }

        public List<FormatoTurnos> TurnoCargarBusqueda(int IdCliente, string Busqueda)
        {
            return _ConsultasCliente.TurnoCargarBusqueda(IdCliente, Busqueda);
        }

        public List<FormatoTurnos> CargarTurnoModificacionBusqueda(int IdCliente, string Busqueda)
        {
            return _ConsultasCliente.CargarTurnoModificacionBusqueda(IdCliente, Busqueda);
        }

        public void TurnoCrear(int IdCliente, string DiaNombre, string DiaNumero, string Mes, string Anio, string Hora, string Descripcion, string Area, string Establecimiento)
        {
            _ConsultasCliente.TurnoCrear(IdCliente, DiaNombre, DiaNumero, Mes, Anio, Hora, Descripcion, Area, Establecimiento);
        }

        public void TurnoModificacionAceptar(int IdTurno)
        {
            _ConsultasCliente.TurnoModificacionAceptar(IdTurno);
        }

        public void TurnoModificacionCambiarFecha(int IdTurno, string DiaNumero, string DiaNombre, string Mes, string Anio)
        {
            _ConsultasCliente.TurnoModificacionCambiarFecha(IdTurno, DiaNumero, DiaNombre, Mes, Anio);
        }

        public void TurnoModificacionCambiarProveedor(int IdTurno, string NombreProveedor)
        {
            _ConsultasCliente.TurnoModificacionCambiarProveedor(IdTurno, NombreProveedor);
        }

        public void TurnoModificacionRechazar(int IdTurno)
        {
            _ConsultasCliente.TurnoModificacionRechazar(IdTurno);
        }

        public bool BuscarCliente(string Usuario, string Clave)
        {
            return _ConsultasCliente.BuscarCliente(Usuario, Clave);
        }

        public void RegistrarPresencia(string Usuario)
        {
            _ConsultasCliente.RegistrarPresencia(Usuario);
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
