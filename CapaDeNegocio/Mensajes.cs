using System;

namespace CapaDeNegocio
{
    public class Mensajes
    {
        public const string GuardadoCambios = "Cambios guardados";
        public const string GuardadoTurno = "Turno guardado";
        public const string GuardadoRegistro = "Se registro correctamente";
        public const string ErrorDB = "Error: No se encontro la base de datos o el procedimiento almacenado";
        public const string ErrorArea = "Error: Debe seleccionar un area";
        public const string ErrorEstablecimiento = "Error: Debe seleccionar un establecimiento";
        public const string ErrorSesion = "Error: Usuario o clave incorrecta";
        public const string ErrorClave = "Error: Usuario o clave incorrecta";
        public const string ErrorUsuario = "Error: Usuario o clave incorrecta";
        public const string ErrorCamposFaltantes = "Error: Todos los campos deben estar llenos";
        public const string ErrorHorario = "Error: Debe seleccionar un horario";
        public const string AlertaBajaOpcion = "¿Quiere dar de baja el turno?";
        public const string AlertaBajaTitulo = "¿Quiere dar de baja el turno?";
        public const string AlertaEliminacionTitulo = "Eliminacion";
        public const string AlertaEliminacion = "Para confirmar la eliminacion haga click en si";
        public string AdministradorBaja = "Cancelado por" + Environment.NewLine + "el administrador";
    }
}
