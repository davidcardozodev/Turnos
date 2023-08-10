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

        public List<FormatoTurnosAdmin> TurnoCargarProveedorAsignado(int idProveedor)
        {
            return _ConsultasProveedor.TurnoCargarProveedorAsignado(idProveedor);
        }

        public List<FormatoTurnosAdmin> TurnoCargarProveedorEnCurso(int idProveedor)
        {
            return _ConsultasProveedor.TurnoCargarProveedorEnCurso(idProveedor);
        }

        public void ProveedorAsignar(int idProveedor, int idTurno)
        {
            _ConsultasProveedor.ProveedorAsignar(idProveedor, idTurno);
        }

        public void ProveedorAgregarEnCurso(int idTurno)
        {
            _ConsultasProveedor.ProveedorAgregarEnCurso(idTurno);
        }

        public void TurnoProveedorFinalizar(int idTurno)
        {
            _ConsultasProveedor.TurnoProveedorFinalizar(idTurno);
        }
    }
}
