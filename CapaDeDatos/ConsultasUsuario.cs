using CapaComun;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class ConsultasUsuario
    {
        #region "Objetos"

        private Conexion _Conexion = new Conexion();
        private SqlDataReader _Lector;
        private DataTable _Tabla = new DataTable();
        private SqlCommand _Comando = new SqlCommand();
        private List<FormatoTurnos> _Valores = new List<FormatoTurnos>();

        #endregion


        public bool IniciarSesion(string Usuario, string Clave)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "IniciarSesion";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@Usuario", Usuario);
            _Comando.Parameters.AddWithValue("@Clave", Clave);

            SqlDataReader Reader = _Comando.ExecuteReader();

            return LeerFilas(Reader, _Conexion);
        }

        private static bool LeerFilas(SqlDataReader Reader, Conexion conexion)
        {
            if (Reader.HasRows)
            {
                while (Reader.Read())
                    FormatoCamposCache(Reader);

                conexion.ConexionCerrar();
                return true;
            }
            else
            {
                conexion.ConexionCerrar();
                return false;
            }

        }

        private static void FormatoCamposCache(SqlDataReader Reader)
        {
            DatosUsuario.Id = Reader.GetInt32(0);
            DatosUsuario.Usuario = Reader.GetString(1);
            DatosUsuario.Clave = Reader.GetString(2);
            DatosUsuario.PrimerNombre = Reader.GetString(3);
            DatosUsuario.SegundoNombre = Reader.GetString(4);
            DatosUsuario.Email = Reader.GetString(5);
            DatosUsuario.Rol = Reader.GetString(6);
        }
    }
}
