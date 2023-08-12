﻿using CapaComun;
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
    }
}
