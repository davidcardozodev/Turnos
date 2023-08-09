using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Cliente
    {
        public Cliente() { }

        private ConsultasUsuario _ConsultasUsuario = new ConsultasUsuario();

        public List<FormatoTurnos> CargarTurno(int idCliente)
        {
            return _ConsultasUsuario.CargarTurno(idCliente);
        }

        public void CrearTurno(int idCliente, string diaNombre, string diaNumero, string mes, string anio, string hora, string descripcion)
        {
            _ConsultasUsuario.CrearTurno(idCliente, diaNombre, diaNumero, mes, anio, hora, descripcion);
        }
    }
}
