using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class Conexion
    {
        private SqlConnection _Conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;" + "Initial Catalog=Turnos;" + "Integrated Security = true");

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
