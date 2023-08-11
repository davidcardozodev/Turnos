using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class ConsultasTurno
    {
        #region "Objetos"

        private Conexion _Conexion = new Conexion();
        private SqlDataReader _Lector;
        private DataTable _Tabla = new DataTable();
        private SqlCommand _Comando = new SqlCommand();

        #endregion

        public void TurnoDarBaja(int idTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoDarBaja";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idTurno", idTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }
    }
}
