using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Turno
    {
        public Turno() { }

        private ConsultasTurno _ConsultasTurno = new ConsultasTurno();

        public void TurnoDarBaja(int IdTurno)
        {
            _ConsultasTurno.TurnoDarBaja(IdTurno);
        }

        public List<FormatoTurnos> TurnoFiltrarEstado(int IdCliente, string Estado)
        {
            return _ConsultasTurno.TurnoFiltrarEstado(IdCliente, Estado);
        }

        public List<FormatoTurnos> TurnoModificacionFiltrarEstado(int IdCliente, string Estado)
        {
            return _ConsultasTurno.TurnoModificacionFiltrarEstado(IdCliente, Estado);
        }
    }
}
