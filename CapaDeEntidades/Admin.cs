﻿using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Admin
    {
        public Admin() { }

        ConsultasAdmin _ConsultasAdmin = new ConsultasAdmin();

        public List<FormatoTurnos> TurnoCargarAdmin()
        {
            return _ConsultasAdmin.TurnoCargarAdmin();
        }

        public List<DatosUsuarioItem> AdminCargarUsuario()
        {
            return _ConsultasAdmin.AdminCargarUsuario();
        }

        public void TurnoDarBaja(int idTurno)
        {
            _ConsultasAdmin.TurnoDarBaja(idTurno);
        }

        public void AdminModicarUsuario(int idUsuario, string rol)
        {
            _ConsultasAdmin.AdminModicarUsuario(idUsuario, rol);
        }

        public void AdminGuardarDisponibilidad(int idUsuario, int horarioInicio, int horarioFin)
        {
            _ConsultasAdmin.AdminGuardarDisponibilidad(idUsuario, horarioInicio, horarioFin);
        }
    }
}
