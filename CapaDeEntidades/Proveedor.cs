using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Proveedor
    {
        public Proveedor() { }

        ConsultasProveedor _ConsultasProveedor = new ConsultasProveedor();

        public List<FormatoTurnosAdmin> TurnoCargarProveedor()
        {
            return _ConsultasProveedor.TurnoCargarProveedor();
        }
    }
}
