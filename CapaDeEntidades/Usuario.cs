using CapaDeDatos;

namespace CapaDeEntidades
{
    public class Usuario
    {
        private ConsultasUsuario _ConsultasUsuario = new ConsultasUsuario();

        public Usuario() { }

        public bool UsuarioIniciarSesion(string Usuario, string Clave)
        {
            return _ConsultasUsuario.UsuarioIniciarSesion(Usuario, Clave);
        }
    }
}
