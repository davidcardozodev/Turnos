using CapaComun;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class ConsultasAdmin
    {
        #region "Objetos"

        private Conexion _Conexion = new Conexion();
        private SqlDataReader _Lector;
        private SqlCommand _Comando = new SqlCommand();
        private List<FormatoTurnos> _Valores = new List<FormatoTurnos>();
        private List<FormatoArea> _Areas = new List<FormatoArea>();
        private List<DatosUsuarioItem> _Usuarios = new List<DatosUsuarioItem>();
        private DataTable _Tabla = new DataTable();

        #endregion

        #region "Lista usuarios"

        public List<DatosUsuarioItem> AdminCargarUsuario()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarUsuario";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Lector = _Comando.ExecuteReader();
            CamposUsuario();
            _Conexion.ConexionCerrar();

            return _Usuarios;
        }

        public List<DatosUsuarioItem> AdminCargarUsuarioFiltrado(string Rol)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarUsuarioFiltrado";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@Rol", Rol);
            _Lector = _Comando.ExecuteReader();
            CamposUsuario();
            _Conexion.ConexionCerrar();

            return _Usuarios;
        }

        public List<DatosUsuarioItem> AdminCargarUsuarioBusqueda(string Busqueda)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarUsuarioBusqueda";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@Busqueda", Busqueda);
            _Lector = _Comando.ExecuteReader();
            CamposUsuario();
            _Conexion.ConexionCerrar();

            return _Usuarios;
        }


        private void CamposUsuario()
        {
            while (_Lector.Read())
            {
                int Id = int.Parse(_Lector["Id"].ToString());
                string Usuario = _Lector["Usuario"].ToString();
                string Clave = _Lector["Clave"].ToString();
                string Nombre = _Lector["Nombre"].ToString();
                string Email = _Lector["Email"].ToString();
                string Rol = _Lector["Rol"].ToString();
                string TipoPlan = _Lector["TipoPlan"].ToString();
                int HorarioInicio = int.Parse(_Lector["HorarioInicio"].ToString());
                int HorarioFin = int.Parse(_Lector["HorarioFin"].ToString());

                _Usuarios.Add(new DatosUsuarioItem
                {
                    Id = Id,
                    Usuario = Usuario,
                    Clave = Clave,
                    Nombre = Nombre,
                    Email = Email,
                    Rol = Rol,
                    TipoPlan = TipoPlan,
                    HorarioInicio = HorarioInicio,
                    HorarioFin = HorarioFin
                });
            }
        }

        #endregion

        #region "Lista turnos"

        public List<FormatoTurnos> AdminCargarTurno()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarTurno";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Lector = _Comando.ExecuteReader();
            CamposTurno();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> AdminCargarTurnoEstadoFiltrado(string Estado)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarTurnoEstadoFiltrado";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@Estado", Estado);
            _Lector = _Comando.ExecuteReader();
            CamposTurno();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> AdminCargarTurnoBusqueda(string Busqueda)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarTurnoBusqueda";
            _Comando.CommandType = CommandType.StoredProcedure;
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
                string NombreProveedor = _Lector["NombreProveedor"].ToString();

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
                    NombreProveedor = NombreProveedor
                });
            }
        }

        #endregion

        #region "Guardar"

        public void AdminModificarUsuario(int IdUsuario, string Usuario, string Clave, string Nombre, string Email, string Rol, string Plan)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminModificarUsuario";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            _Comando.Parameters.AddWithValue("@Usuario", Usuario);
            _Comando.Parameters.AddWithValue("@Clave", Clave);
            _Comando.Parameters.AddWithValue("@Nombre", Nombre);
            _Comando.Parameters.AddWithValue("@Email", Email);
            _Comando.Parameters.AddWithValue("@Rol", Rol);
            _Comando.Parameters.AddWithValue("@Plan", Plan);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void AdminGuardarDisponibilidad(int IdUsuario, int HorarioInicio, int HorarioFin)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminGuardarDisponibilidad";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            _Comando.Parameters.AddWithValue("@HorarioInicio", HorarioInicio);
            _Comando.Parameters.AddWithValue("@HorarioFin", HorarioFin);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void AdminGuardarModificacion(int IdTurno, int IdAdmin, int IdCliente, string DiaNombre, string DiaNumero, string Mes, string Anio, string NombreProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminGuardarModificacion";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.Parameters.AddWithValue("@IdAdmin", IdAdmin);
            _Comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            _Comando.Parameters.AddWithValue("@DiaNombre", DiaNombre);
            _Comando.Parameters.AddWithValue("@DiaNumero", DiaNumero);
            _Comando.Parameters.AddWithValue("@Mes", Mes);
            _Comando.Parameters.AddWithValue("@Anio", Anio);
            _Comando.Parameters.AddWithValue("@NombreProveedor", NombreProveedor);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void AdminRegistrarUsuario(string NombreUsuario, string Clave, string Nombre, string Email, string Rol, int HorarioInicio, int HorarioFin, string TipoPlan)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminRegistrarUsuario";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            _Comando.Parameters.AddWithValue("@Clave", Clave);
            _Comando.Parameters.AddWithValue("@Nombre", Nombre);
            _Comando.Parameters.AddWithValue("@Email", Email);
            _Comando.Parameters.AddWithValue("@Rol", Rol);
            _Comando.Parameters.AddWithValue("@HorarioInicio", HorarioInicio);
            _Comando.Parameters.AddWithValue("@HorarioFin", HorarioFin);
            _Comando.Parameters.AddWithValue("@TipoPlan", TipoPlan);
            _Comando.ExecuteNonQuery();
            _Comando.Parameters.Clear();
        }

        public void AdminGuardarBajaNotificacion(int IdTurno, int IdAdmin, int IdCliente)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminGuardarBajaNotificacion";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.Parameters.AddWithValue("@IdAdmin", IdAdmin);
            _Comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void AdminAsociarLugar(int IdLugar, int IdProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminAsociarLugar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdLugar", IdLugar);
            _Comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void AdminAsociarEstablecimientoArea(int IdEstablecimiento, int IdArea)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminAsociarEstablecimientoArea";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdEstablecimiento", IdEstablecimiento);
            _Comando.Parameters.AddWithValue("@IdArea", IdArea);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void AdminModificarArea(int IdArea, string Nombre)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminModificarArea";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdArea", IdArea);
            _Comando.Parameters.AddWithValue("@Nombre", Nombre);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }


        #endregion

        public DataTable AdminCargarProveedores()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarProveedores";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.ExecuteNonQuery();

            DataTable TablaFiltrada = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(_Comando);

            adaptador.Fill(TablaFiltrada);

            _Conexion.ConexionCerrar();
            return TablaFiltrada;
        }

        public DataTable AdminCargarLugares()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarLugares";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.ExecuteNonQuery();

            DataTable TablaFiltrada = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(_Comando);

            adaptador.Fill(TablaFiltrada);

            _Conexion.ConexionCerrar();
            return TablaFiltrada;
        }

        public DataTable AdminCargarEstablecimiento()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarEstablecimiento";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.ExecuteNonQuery();

            SqlDataAdapter adaptador = new SqlDataAdapter(_Comando);
            adaptador.Fill(_Tabla);

            _Conexion.ConexionCerrar();
            return _Tabla;
        }

        public DataTable AdminCargarArea()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarArea";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.ExecuteNonQuery();

            SqlDataAdapter adaptador = new SqlDataAdapter(_Comando);
            adaptador.Fill(_Tabla);

            _Conexion.ConexionCerrar();
            return _Tabla;
        }

        public List<FormatoArea> AdminCargarAreaItem()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarAreaItem";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Lector = _Comando.ExecuteReader();

            while (_Lector.Read())
            {
                int Id = int.Parse(_Lector["Id"].ToString());
                string Nombre = _Lector["Nombre"].ToString();

                _Areas.Add(new FormatoArea
                {
                    Id = Id,
                    Nombre = Nombre
                });
            }

            _Conexion.ConexionCerrar();

            return _Areas;
        }
    }
}
