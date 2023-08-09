using CapaComun;
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
    }
}
