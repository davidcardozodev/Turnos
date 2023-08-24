using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Turno
    {
        public Turno() { }

        private ConsultasTurno _ConsultasTurno = new ConsultasTurno();

        public void TurnoDarBaja(int idTurno)
        {
            _ConsultasTurno.TurnoDarBaja(idTurno);
        }

        public List<FormatoTurnos> TurnoFiltrarEstado(int idCliente, string estado)
        {
            return _ConsultasTurno.TurnoFiltrarEstado(idCliente, estado);
        }

        public List<FormatoTurnos> TurnoModificacionFiltrarEstado(int idCliente, string estado)
        {
            return _ConsultasTurno.TurnoModificacionFiltrarEstado(idCliente, estado);
        }
    }
}
