using CapaComun;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class ConsultasUsuario
    {
        #region "Objetos"

        private Conexion _Conexion = new Conexion();
        private SqlCommand _Comando = new SqlCommand();

        #endregion


        public bool UsuarioIniciarSesion(string Usuario, string Clave)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "UsuarioIniciarSesion";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@Usuario", Usuario);
            _Comando.Parameters.AddWithValue("@Clave", Clave);

            SqlDataReader Reader = _Comando.ExecuteReader();

            return LeerFilas(Reader, _Conexion);
        }

        private static bool LeerFilas(SqlDataReader Reader, Conexion _Conexion)
        {
            if (Reader.HasRows)
            {
                while (Reader.Read())
                    FormatoCamposCache(Reader);

                _Conexion.ConexionCerrar();
                return true;
            }
            else
            {
                _Conexion.ConexionCerrar();
                return false;
            }

        }

        private static void FormatoCamposCache(SqlDataReader Reader)
        {
            DatosUsuario.Id = int.Parse(Reader["Id"].ToString());
            DatosUsuario.Usuario = Reader["Usuario"].ToString();
            DatosUsuario.Clave = Reader["Clave"].ToString();
            DatosUsuario.Nombre = Reader["Nombre"].ToString();
            DatosUsuario.Email = Reader["Email"].ToString();
            DatosUsuario.Rol = Reader["Rol"].ToString();
        }
    }
}
