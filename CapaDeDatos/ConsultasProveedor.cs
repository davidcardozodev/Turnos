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

        #region "Pantalla principal"

        public List<FormatoTurnos> ProveedorCargarTurnos(int HorarioInicio, int HorarioFin)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorCargarTurnos";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@HorarioInicio", HorarioInicio);
            _Comando.Parameters.AddWithValue("@HorarioFin", HorarioFin);
            _Lector = _Comando.ExecuteReader();

            while (_Lector.Read())
            {
                int Id = int.Parse(_Lector["Id"].ToString());
                int IdCliente = int.Parse(_Lector["IdCliente"].ToString());
                string Hora = _Lector["Hora"].ToString();
                string Descripcion = _Lector["Descripcion"].ToString();
                string Estado = _Lector["Estado"].ToString();
                string Usuario = _Lector["Usuario"].ToString();
                string Nombre = _Lector["Nombre"].ToString();
                string Presencia = _Lector["Presencia"].ToString();
                string TipoPlan = _Lector["TipoPlan"].ToString();

                _Valores.Add(new FormatoTurnos
                {
                    Id = Id,
                    IdCliente = IdCliente,
                    Hora = Hora,
                    Descripcion = Descripcion,
                    Estado = Estado,
                    Usuario = Usuario,
                    Nombre = Nombre,
                    Presencia = Presencia,
                    TipoPlan = TipoPlan
                });
            }

            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> ProveedorCargarTurnosBusqueda(int HorarioInicio, int HorarioFin, string Busqueda)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorCargarTurnosBusqueda";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@HorarioInicio", HorarioInicio);
            _Comando.Parameters.AddWithValue("@HorarioFin", HorarioFin);
            _Comando.Parameters.AddWithValue("@Busqueda", Busqueda);
            _Lector = _Comando.ExecuteReader();
            CamposTurno();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        private void CamposTurno()
        {
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
                string Nombre = _Lector["Nombre"].ToString();
                string Presencia = _Lector["Presencia"].ToString();
                string TipoPlan = _Lector["TipoPlan"].ToString();

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
                    Nombre = Nombre,
                    Presencia = Presencia,
                    TipoPlan = TipoPlan
                });
            }
        }

        public void ProveedorCargarLugar(int IdProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorCargarLugar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);

            SqlDataReader Reader = _Comando.ExecuteReader();

            LeerLugar(Reader, _Conexion);
        }

        private static bool LeerLugar(SqlDataReader Reader, Conexion _Conexion)
        {
            if (Reader.HasRows)
            {
                while (Reader.Read())
                    DatosUsuario.Lugar = Reader["Nombre"].ToString();

                _Conexion.ConexionCerrar();
                return true;
            }
            else
            {
                _Conexion.ConexionCerrar();
                return false;
            }

        }

        public void ProveedorGuardarLugar(int IdTurno, string Lugar)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorGuardarLugar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.Parameters.AddWithValue("@Lugar", Lugar);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }


        #endregion

        #region "Pantalla llamador"

        public List<FormatoTurnos> ProveedorCargarTurnoAsignado(int IdProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorCargarTurnoAsignado";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("IdProveedor", IdProveedor);

            _Lector = _Comando.ExecuteReader();

            while (_Lector.Read())
            {
                int Id = int.Parse(_Lector["Id"].ToString());
                string Nombre = _Lector["Nombre"].ToString();
                string TipoPlan = _Lector["TipoPlan"].ToString();
                string Lugar = _Lector["Lugar"].ToString();

                _Valores.Add(new FormatoTurnos
                {
                    Id = Id,
                    Nombre = Nombre,
                    TipoPlan = TipoPlan,
                    Lugar = Lugar
                });
            }

            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> ProveedorCargarTurnoEnCurso(int IdProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorCargarTurnoEnCurso";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("IdProveedor", IdProveedor);

            _Lector = _Comando.ExecuteReader();

            while (_Lector.Read())
            {
                int Id = int.Parse(_Lector["Id"].ToString());
                string Nombre = _Lector["Nombre"].ToString();
                string Lugar = _Lector["Lugar"].ToString();

                _Valores.Add(new FormatoTurnos
                {
                    Id = Id,
                    Nombre = Nombre,
                    Lugar = Lugar,
                });
            }

            _Conexion.ConexionCerrar();

            return _Valores;
        }

        #endregion

        #region "Acciones"

        public void ProveedorAsignar(int IdProveedor, int IdTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorAsignar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void ProveedorFinalizarTurno(int IdTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorFinalizarTurno";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void ProveedorAgregarEnCurso(int IdTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorAgregarEnCurso";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        #endregion

        #region "Disponibilidad"

        public void ProveedorCargarDisponibilidad(int IdProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ProveedorCargarDisponibilidad";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);

            SqlDataReader Reader = _Comando.ExecuteReader();

            LeerFilas(Reader, _Conexion);
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
            DatosDisponibilidad.HorarioInicio = int.Parse(Reader["HorarioInicio"].ToString());
            DatosDisponibilidad.HorarioFin = int.Parse(Reader["HorarioFin"].ToString());
        }

        #endregion

    }
}
