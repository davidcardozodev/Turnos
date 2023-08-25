using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Proveedor
    {
        public Proveedor() { }

        ConsultasProveedor _ConsultasProveedor = new ConsultasProveedor();

        public List<FormatoTurnos> ProveedorCargarTurnos(int horarioInicio, int horarioFin)
        {
            return _ConsultasProveedor.ProveedorCargarTurnos(horarioInicio, horarioFin);
        }

        public List<FormatoTurnos> TurnoCargarProveedorAsignado(int idProveedor)
        {
            return _ConsultasProveedor.TurnoCargarProveedorAsignado(idProveedor);
        }

        public List<FormatoTurnos> TurnoCargarProveedorEnCurso(int idProveedor)
        {
            return _ConsultasProveedor.TurnoCargarProveedorEnCurso(idProveedor);
        }

        public List<FormatoTurnos> ProveedorCargarTurnosBusqueda(int horarioInicio, int horarioFin, string busqueda)
        {
            return _ConsultasProveedor.ProveedorCargarTurnosBusqueda(horarioInicio, horarioFin, busqueda);
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

        public void ProveedorCargarDisponibilidad(int idProveedor)
        {
            _ConsultasProveedor.ProveedorCargarDisponibilidad(idProveedor);
        }
    }
}
