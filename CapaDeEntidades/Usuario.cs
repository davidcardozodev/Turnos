using CapaComun;
using CapaDeDatos;

namespace CapaDeEntidades
{
    public class Usuario
    {
        private ConsultasUsuario _ConsultasUsuario = new ConsultasUsuario();

        public Usuario() { }

        #region "Sesion"

        public bool IniciarSesion(string Usuario, string Clave)
        {
            return _ConsultasUsuario.IniciarSesion(Usuario, Clave);
        }

        public void CerrarSesion()
        {
            DatosUsuario.Id = 0;
            DatosUsuario.Usuario = "";
            DatosUsuario.Clave = "";
            DatosUsuario.PrimerNombre = "";
            DatosUsuario.Email = "";
            DatosUsuario.Rol = "";
        }

        #endregion
    }
}
