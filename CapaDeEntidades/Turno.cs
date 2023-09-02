using CapaDeDatos;

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


    }
}
