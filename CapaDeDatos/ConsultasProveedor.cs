using CapaComun;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class ConsultasProveedor
    {
        #region "Objetos"

        private Conexion _Conexion = new Conexion();
        private SqlDataReader _Lector;
        private DataTable _Tabla = new DataTable();
        private SqlCommand _Comando = new SqlCommand();
        private List<FormatoTurnosAdmin> _Valores = new List<FormatoTurnosAdmin>();

        #endregion

        public List<FormatoTurnosAdmin> TurnoCargarProveedor()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargarProveedor";
            _Comando.CommandType = CommandType.StoredProcedure;

            _Lector = _Comando.ExecuteReader();

            while (_Lector.Read())
            {
                int Id = int.Parse(_Lector["Id"].ToString());
                int IdCliente = int.Parse(_Lector["IdCliente"].ToString());
                string DiaNombre = _Lector["DiaNombre"].ToString();
                string DiaNumero = _Lector["DiaNumero"].ToString();
                string Mes = _Lector["Mes"].ToString();
                string Anio = _Lector["Anio"].ToString();
                string Hora = _Lector["Hora"].ToString();
                string Descripcion = _Lector["Descripcion"].ToString();
                string Estado = _Lector["Estado"].ToString();
                string Usuario = _Lector["Usuario"].ToString();
                string PrimerNombre = _Lector["PrimerNombre"].ToString();
                string SegundoNombre = _Lector["SegundoNombre"].ToString();

                _Valores.Add(new FormatoTurnosAdmin
                {
                    Id = Id,
                    IdCliente = IdCliente,
                    DiaNombre = DiaNombre,
                    DiaNumero = DiaNumero,
                    Mes = Mes,
                    Anio = Anio,
                    Hora = Hora,
                    Descripcion = Descripcion,
                    Estado = Estado,
                    Usuario = Usuario,
                    PrimerNombre = PrimerNombre,
                    SegundoNombre = SegundoNombre
                });
            }

            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public void ProveedorAsignar(int idProveedor, int idTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorAsignar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idProveedor", idProveedor);
            _Comando.Parameters.AddWithValue("@idTurno", idTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

    }
}
