using CapaDeDatos;

namespace CapaDeEntidades
{
    public class Usuario
    {
        private ConsultasUsuario _ConsultasUsuario = new ConsultasUsuario();

        public Usuario() { }

        public bool IniciarSesion(string Usuario, string Clave)
        {
            return _ConsultasUsuario.IniciarSesion(Usuario, Clave);
        }
    }
}
