using CapaComun;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class ConsultasCliente
    {
        #region "Objetos"

        private Conexion _Conexion = new Conexion();
        private SqlDataReader _Lector;
        private SqlCommand _Comando = new SqlCommand();
        private List<FormatoTurnos> _Valores = new List<FormatoTurnos>();
        private DataTable _Tabla = new DataTable();

        #endregion

        #region "Lista turnos (pantalla principal)"

        public List<FormatoTurnos> TurnoCargar(int idCliente)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idCliente", idCliente);
            _Lector = _Comando.ExecuteReader();
            CamposTurno();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> TurnoCargarDetalle(int IdTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargarDetalle";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Lector = _Comando.ExecuteReader();
            CamposTurno();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> TurnoCargarBusqueda(int idCliente, string busqueda)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargarBusqueda";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idCliente", idCliente);
            _Comando.Parameters.AddWithValue("@busqueda", busqueda);
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
                string DiaNombre = _Lector["DiaNombre"].ToString();
                string DiaNumero = _Lector["DiaNumero"].ToString();
                string Mes = _Lector["Mes"].ToString();
                string Anio = _Lector["Anio"].ToString();
                string Hora = _Lector["Hora"].ToString();
                string Descripcion = _Lector["Descripcion"].ToString();
                string Estado = _Lector["Estado"].ToString();
                string NombreProveedor = _Lector["NombreProveedor"].ToString();

                _Valores.Add(new FormatoTurnos
                {
                    Id = Id,
                    DiaNombre = DiaNombre,
                    DiaNumero = DiaNumero,
                    Mes = Mes,
                    Anio = Anio,
                    Hora = Hora,
                    Descripcion = Descripcion,
                    Estado = Estado,
                    NombreProveedor = NombreProveedor,
                });
            }
        }

        #endregion

        #region "Lista turnos (pantalla notificacion)"

        public List<FormatoTurnos> TurnoCargarModificacion(int idCliente)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargarModificacion";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idCliente", idCliente);
            _Lector = _Comando.ExecuteReader();
            CamposTurnoModificacion();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> CargarTurnoModificacionBusqueda(int idCliente, string busqueda)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "CargarTurnoModificacionBusqueda";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idCliente", idCliente);
            _Comando.Parameters.AddWithValue("@busqueda", busqueda);
            _Lector = _Comando.ExecuteReader();
            CamposTurnoModificacion();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        private void CamposTurnoModificacion()
        {
            while (_Lector.Read())
            {
                int IdTurno = int.Parse(_Lector["IdTurno"].ToString());
                string DiaNombre = _Lector["DiaNombre"].ToString();
                string DiaNumero = _Lector["DiaNumero"].ToString();
                string Mes = _Lector["Mes"].ToString();
                string Anio = _Lector["Anio"].ToString();
                string NombreProveedor = _Lector["NombreProveedor"].ToString();
                string Estado = _Lector["Estado"].ToString();

                _Valores.Add(new FormatoTurnos
                {
                    Id = IdTurno,
                    DiaNombre = DiaNombre,
                    DiaNumero = DiaNumero,
                    Mes = Mes,
                    Anio = Anio,
                    NombreProveedor = NombreProveedor,
                    Estado = Estado
                });
            }
        }

        #endregion

        #region "Modificar turno"

        public void TurnoModificacionAceptar(int IdTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoModificacionAceptar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void TurnoModificacionCambiarFecha(int IdTurno, string diaNumero, string diaNombre, string mes, string anio)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoModificacionCambiarFecha";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.Parameters.AddWithValue("@diaNumero", diaNumero);
            _Comando.Parameters.AddWithValue("@diaNombre", diaNombre);
            _Comando.Parameters.AddWithValue("@mes", mes);
            _Comando.Parameters.AddWithValue("@anio", anio);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void TurnoModificacionCambiarProveedor(int IdTurno, string nombreProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoModificacionCambiarProveedor";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        #endregion

        #region "Registrar presencia"

        public bool BuscarCliente(string Usuario, string Clave)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "BuscarCliente";
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
                conexion.ConexionCerrar();
                return true;
            }
            else
            {
                conexion.ConexionCerrar();
                return false;
            }
        }

        public void RegistrarPresencia(string Usuario)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "RegistrarPresencia";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@Usuario", Usuario);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        #endregion

        public void TurnoCrear(int idCliente, string diaNombre, string diaNumero, string mes, string anio, string hora, string descripcion)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCrear";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idCliente", idCliente);
            _Comando.Parameters.AddWithValue("@diaNombre", diaNombre);
            _Comando.Parameters.AddWithValue("@diaNumero", diaNumero);
            _Comando.Parameters.AddWithValue("@mes", mes);
            _Comando.Parameters.AddWithValue("@anio", anio);
            _Comando.Parameters.AddWithValue("@hora", hora);
            _Comando.Parameters.AddWithValue("@descripcion", descripcion);
            _Comando.ExecuteNonQuery();
            _Comando.Parameters.Clear();
        }

        public void TurnoModificacionRechazar(int IdTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoModificacionRechazar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public DataTable ClienteCargarArea()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteCargarArea";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.ExecuteNonQuery();

            SqlDataAdapter adaptador = new SqlDataAdapter(_Comando);
            adaptador.Fill(_Tabla);

            _Conexion.ConexionCerrar();
            return _Tabla;
        }
    }
}
