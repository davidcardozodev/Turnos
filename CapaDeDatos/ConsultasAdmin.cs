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
        private List<DatosUsuarioItem> _Usuarios = new List<DatosUsuarioItem>();

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
                string PrimerNombre = _Lector["PrimerNombre"].ToString();
                string SegundoNombre = _Lector["SegundoNombre"].ToString();
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
                    PrimerNombre = PrimerNombre,
                    SegundoNombre = SegundoNombre,
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

        public List<FormatoTurnos> TurnoCargarAdmin()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargarAdmin";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Lector = _Comando.ExecuteReader();
            CamposTurno();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> TurnoCargarEstadoFiltradoAdmin(string Estado)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargarEstadoFiltradoAdmin";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@Estado", Estado);
            _Lector = _Comando.ExecuteReader();
            CamposTurno();
            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public List<FormatoTurnos> TurnoCargarBusquedaAdmin(string Busqueda)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargarBusquedaAdmin";
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
                string PrimerNombre = _Lector["PrimerNombre"].ToString();
                string SegundoNombre = _Lector["SegundoNombre"].ToString();
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
                    PrimerNombre = PrimerNombre,
                    SegundoNombre = SegundoNombre,
                    NombreProveedor = NombreProveedor
                });
            }
        }

        #endregion

        #region "Guardar"

        public void AdminModificarUsuario(int IdUsuario, string Usuario, string Clave, string PrimerNombre, string SegundoNombre, string Email, string Rol)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminModificarUsuario";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            _Comando.Parameters.AddWithValue("@Usuario", Usuario);
            _Comando.Parameters.AddWithValue("@Clave", Clave);
            _Comando.Parameters.AddWithValue("@PrimerNombre", PrimerNombre);
            _Comando.Parameters.AddWithValue("@SegundoNombre", SegundoNombre);
            _Comando.Parameters.AddWithValue("@Email", Email);
            _Comando.Parameters.AddWithValue("@Rol", Rol);
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

        public void AdminGuardarProveedor(int IdTurno, string NombreProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminGuardarProveedor";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@IdTurno", IdTurno);
            _Comando.Parameters.AddWithValue("@NombreProveedor", NombreProveedor);
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

        public void AdminRegistrarUsuario(string NombreUsuario, string Clave, string PrimerNombre, string SegundoNombre, string Email, string Rol, int HorarioInicio, int HorarioFin, string TipoPlan)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminRegistrarUsuario";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            _Comando.Parameters.AddWithValue("@Clave", Clave);
            _Comando.Parameters.AddWithValue("@PrimerNombre", PrimerNombre);
            _Comando.Parameters.AddWithValue("@SegundoNombre", SegundoNombre);
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

    }
}
