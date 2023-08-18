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
        private SqlCommand _Comando = new SqlCommand();
        private List<FormatoTurnos> _Valores = new List<FormatoTurnos>();

        #endregion

        public List<FormatoTurnos> ProveedorCargarTurnos(int horarioInicio, int horarioFin)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorCargarTurnos";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@horarioInicio", horarioInicio);
            _Comando.Parameters.AddWithValue("@horarioFin", horarioFin);

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

                _Valores.Add(new FormatoTurnos
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

        public List<FormatoTurnos> TurnoCargarProveedorAsignado(int idProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargarProveedorAsignado";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("idProveedor", idProveedor);

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

                _Valores.Add(new FormatoTurnos
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

        public List<FormatoTurnos> TurnoCargarProveedorEnCurso(int idProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargarProveedorEnCurso";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("idProveedor", idProveedor);

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

                _Valores.Add(new FormatoTurnos
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

        public void TurnoProveedorFinalizar(int idTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoProveedorFinalizar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idTurno", idTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void ProveedorAgregarEnCurso(int idTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorAgregarEnCurso";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idTurno", idTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void ProveedorCargarDisponibilidad(int idProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorCargarDisponibilidad";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idProveedor", idProveedor);

            SqlDataReader Reader = _Comando.ExecuteReader();

            LeerFilas(Reader, _Conexion);
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
            DatosDisponibilidad.HorarioInicio = int.Parse(Reader["HorarioInicio"].ToString());
            DatosDisponibilidad.HorarioFin = int.Parse(Reader["HorarioFin"].ToString());
        }
    }
}
