using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Admin
    {
        public Admin() { }

        ConsultasAdmin _ConsultasAdmin = new ConsultasAdmin();

        public List<FormatoTurnosAdmin> TurnoCargarAdmin()
        {
            return _ConsultasAdmin.TurnoCargarAdmin();
        }

        public List<DatosUsuarioItem> AdminCargarUsuario()
        {
            return _ConsultasAdmin.AdminCargarUsuario();
        }
    }
}
