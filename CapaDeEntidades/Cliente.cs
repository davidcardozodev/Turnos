using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Cliente
    {
        public Cliente() { }

        private ConsultasUsuario _ConsultasUsuario = new ConsultasUsuario();

        public List<FormatoTurnos> CargarTurno()
        {
            return _ConsultasUsuario.CargarTurno();
        }
    }
}
