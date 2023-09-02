using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class ConsultasTurno
    {
        private Conexion _Conexion = new Conexion();
        private SqlCommand _Comando = new SqlCommand();

        public void TurnoDarBaja(int IdTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoDarBaja";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

    }
}
