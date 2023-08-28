using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Proveedor
    {
        public Proveedor() { }

        ConsultasProveedor _ConsultasProveedor = new ConsultasProveedor();

        public List<FormatoTurnos> ProveedorCargarTurnos(int HorarioInicio, int HorarioFin)
        {
            return _ConsultasProveedor.ProveedorCargarTurnos(HorarioInicio, HorarioFin);
        }

        public List<FormatoTurnos> TurnoCargarProveedorAsignado(int IdProveedor)
        {
            return _ConsultasProveedor.TurnoCargarProveedorAsignado(IdProveedor);
        }

        public List<FormatoTurnos> TurnoCargarProveedorEnCurso(int IdProveedor)
        {
            return _ConsultasProveedor.TurnoCargarProveedorEnCurso(IdProveedor);
        }

        public List<FormatoTurnos> ProveedorCargarTurnosBusqueda(int HorarioInicio, int HorarioFin, string Busqueda)
        {
            return _ConsultasProveedor.ProveedorCargarTurnosBusqueda(HorarioInicio, HorarioFin, Busqueda);
        }

        public void ProveedorAsignar(int IdProveedor, int IdTurno)
        {
            _ConsultasProveedor.ProveedorAsignar(IdProveedor, IdTurno);
        }

        public void ProveedorAgregarEnCurso(int IdTurno)
        {
            _ConsultasProveedor.ProveedorAgregarEnCurso(IdTurno);
        }

        public void TurnoProveedorFinalizar(int IdTurno)
        {
            _ConsultasProveedor.TurnoProveedorFinalizar(IdTurno);
        }

        public void ProveedorCargarDisponibilidad(int IdProveedor)
        {
            _ConsultasProveedor.ProveedorCargarDisponibilidad(IdProveedor);
        }
    }
}
