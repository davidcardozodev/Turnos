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

        public List<FormatoTurnos> ClienteCargarTurno(int IdCliente)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteCargarTurno";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            _Lector = _Comando.ExecuteReader();
            CamposTurno();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> ClienteCargarTurnoDetalle(int IdTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteCargarTurnoDetalle";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Lector = _Comando.ExecuteReader();
            CamposTurno();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> ClienteCargarTurnoBusqueda(int IdCliente, string Busqueda)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteCargarTurnoBusqueda";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            _Comando.Parameters.AddWithValue("@Busqueda", Busqueda);
            _Lector = _Comando.ExecuteReader();
            CamposTurno();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> ClienteCargarTurnoFiltrado(int IdCliente_, string Estado_)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteCargarTurnoFiltrado";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdCliente", IdCliente_);
            _Comando.Parameters.AddWithValue("@Estado", Estado_);

            _Lector = _Comando.ExecuteReader();

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

        public List<FormatoTurnos> ClienteCargarTurnoModificacion(int IdCliente)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteCargarTurnoModificacion";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            _Lector = _Comando.ExecuteReader();
            CamposTurnoModificacion();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> ClienteCargarTurnoModificacionBusqueda(int IdCliente, string Busqueda)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteCargarTurnoModificacionBusqueda";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            _Comando.Parameters.AddWithValue("@Busqueda", Busqueda);
            _Lector = _Comando.ExecuteReader();
            CamposTurnoModificacion();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> ClienteCargarTurnoModificacionFiltrado(int IdCliente_, string Estado_)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteCargarTurnoModificacionFiltrado";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdCliente", IdCliente_);
            _Comando.Parameters.AddWithValue("@Estado", Estado_);

            _Lector = _Comando.ExecuteReader();

            while (_Lector.Read())
            {
                int Id = int.Parse(_Lector["Id"].ToString());
                string DiaNombre = _Lector["DiaNombre"].ToString();
                string DiaNumero = _Lector["DiaNumero"].ToString();
                string Mes = _Lector["Mes"].ToString();
                string Anio = _Lector["Anio"].ToString();
                string Estado = _Lector["Estado"].ToString();
                string NombreProveedor = _Lector["NombreProveedor"].ToString();

                _Valores.Add(new FormatoTurnos
                {
                    Id = Id,
                    DiaNombre = DiaNombre,
                    DiaNumero = DiaNumero,
                    Mes = Mes,
                    Anio = Anio,
                    Estado = Estado,
                    NombreProveedor = NombreProveedor,
                });
            }

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

        public void ClienteTurnoModificacionAceptar(int IdTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteTurnoModificacionAceptar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void ClienteTurnoModificacionCambiarFecha(int IdTurno, string DiaNumero, string DiaNombre, string Mes, string Anio)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteTurnoModificacionCambiarFecha";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.Parameters.AddWithValue("@DiaNumero", DiaNumero);
            _Comando.Parameters.AddWithValue("@DiaNombre", DiaNombre);
            _Comando.Parameters.AddWithValue("@Mes", Mes);
            _Comando.Parameters.AddWithValue("@Anio", Anio);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void ClienteTurnoModificacionCambiarProveedor(int IdTurno, string NombreProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteTurnoModificacionCambiarProveedor";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.Parameters.AddWithValue("@NombreProveedor", NombreProveedor);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        #endregion

        #region "Registrar presencia"

        public bool ClienteBuscarCoincidencia(string Usuario, string Clave)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteBuscarCoincidencia";
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
                _Conexion.ConexionCerrar();
                return true;
            }
            else
            {
                _Conexion.ConexionCerrar();
                return false;
            }
        }

        public void ClienteRegistrarPresencia(string Usuario)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteRegistrarPresencia";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@Usuario", Usuario);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        #endregion

        public void ClienteCrearTurno(int IdCliente, string DiaNombre, string DiaNumero, string Mes, string Anio, string Hora, string Descripcion, string Area, string Establecimiento)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteCrearTurno";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            _Comando.Parameters.AddWithValue("@DiaNombre", DiaNombre);
            _Comando.Parameters.AddWithValue("@DiaNumero", DiaNumero);
            _Comando.Parameters.AddWithValue("@Mes", Mes);
            _Comando.Parameters.AddWithValue("@Anio", Anio);
            _Comando.Parameters.AddWithValue("@Hora", Hora);
            _Comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            _Comando.Parameters.AddWithValue("@Area", Area);
            _Comando.Parameters.AddWithValue("@Establecimiento", Establecimiento);
            _Comando.ExecuteNonQuery();
            _Comando.Parameters.Clear();
        }

        public void ClienteTurnoModificacionRechazar(int IdTurno)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteTurnoModificacionRechazar";
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

        public DataTable ClienteCargarEstablecimiento()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "ClienteCargarEstablecimiento";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.ExecuteNonQuery();

            SqlDataAdapter adaptador = new SqlDataAdapter(_Comando);
            adaptador.Fill(_Tabla);

            _Conexion.ConexionCerrar();
            return _Tabla;
        }
    }
}
