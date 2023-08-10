using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class Conexion
    {
        private SqlConnection _Conexion = new SqlConnection("Server=(local); DataBase=Turnos;Integrated Security=true");

        public SqlConnection ConexionAbrir()
        {
            if (_Conexion.State == ConnectionState.Closed)
                _Conexion.Open();

            return _Conexion;
        }

        public SqlConnection ConexionCerrar()
        {
            if (_Conexion.State == ConnectionState.Open)
                _Conexion.Close();

            return _Conexion;
        }

    }
}
