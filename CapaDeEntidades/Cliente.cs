﻿using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Cliente
    {
        public Cliente() { }

        private ConsultasUsuario _ConsultasUsuario = new ConsultasUsuario();

        public List<FormatoTurnos> TurnoCargar(int idCliente)
        {
            return _ConsultasUsuario.TurnoCargar(idCliente);
        }

        public void TurnoCrear(int idCliente, string diaNombre, string diaNumero, string mes, string anio, string hora, string descripcion)
        {
            _ConsultasUsuario.TurnoCrear(idCliente, diaNombre, diaNumero, mes, anio, hora, descripcion);
        }
    }
}
