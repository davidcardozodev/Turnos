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

        public List<FormatoTurnos> ProveedorCargarTurnoAsignado(int IdProveedor)
        {
            return _ConsultasProveedor.ProveedorCargarTurnoAsignado(IdProveedor);
        }

        public List<FormatoTurnos> ProveedorCargarTurnoEnCurso(int IdProveedor)
        {
            return _ConsultasProveedor.ProveedorCargarTurnoEnCurso(IdProveedor);
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

        public void ProveedorFinalizarTurno(int IdTurno)
        {
            _ConsultasProveedor.ProveedorFinalizarTurno(IdTurno);
        }

        public void ProveedorCargarDisponibilidad(int IdProveedor)
        {
            _ConsultasProveedor.ProveedorCargarDisponibilidad(IdProveedor);
        }

        public void ProveedorCargarLugar(int IdProveedor)
        {
            _ConsultasProveedor.ProveedorCargarLugar(IdProveedor);
        }

        public void ProveedorGuardarLugar(int IdTurno, string Lugar)
        {
            _ConsultasProveedor.ProveedorGuardarLugar(IdTurno, Lugar);
        }
    }
}
