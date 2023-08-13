using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Cliente
    {
        public Cliente() { }

        private ConsultasCliente _ConsultasCliente = new ConsultasCliente();

        public List<FormatoTurnos> TurnoCargar(int idCliente)
        {
            return _ConsultasCliente.TurnoCargar(idCliente);
        }

        public List<FormatoTurnos> TurnoCargarDetalle(int IdTurno)
        {
            return _ConsultasCliente.TurnoCargarDetalle(IdTurno);
        }

        public List<FormatoTurnos> TurnoCargarModificacion(int idCliente)
        {
            return _ConsultasCliente.TurnoCargarModificacion(idCliente);
        }

        public void TurnoCrear(int idCliente, string diaNombre, string diaNumero, string mes, string anio, string hora, string descripcion)
        {
            _ConsultasCliente.TurnoCrear(idCliente, diaNombre, diaNumero, mes, anio, hora, descripcion);
        }

        public void TurnoModificacionAceptar(int IdTurno)
        {
            _ConsultasCliente.TurnoModificacionAceptar(IdTurno);
        }

        public void TurnoModificacionCambiarFecha(int IdTurno, string diaNumero, string diaNombre, string mes, string anio)
        {
            _ConsultasCliente.TurnoModificacionCambiarFecha(IdTurno, diaNumero, diaNombre, mes, anio);
        }

        public void TurnoModificacionCambiarProveedor(int IdTurno, string nombreProveedor)
        {
            _ConsultasCliente.TurnoModificacionCambiarProveedor(IdTurno, nombreProveedor);
        }

        public void TurnoModificacionRechazar(int IdTurno)
        {
            _ConsultasCliente.TurnoModificacionRechazar(IdTurno);
        }
    }
}
