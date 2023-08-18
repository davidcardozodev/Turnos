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

        public List<DatosUsuarioItem> AdminCargarUsuario()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminCargarUsuario";
            _Comando.CommandType = CommandType.StoredProcedure;

            _Lector = _Comando.ExecuteReader();

            while (_Lector.Read())
            {
                int Id = int.Parse(_Lector["Id"].ToString());
                string Usuario = _Lector["Usuario"].ToString();
                string Clave = _Lector["Clave"].ToString();
                string PrimerNombre = _Lector["PrimerNombre"].ToString();
                string SegundoNombre = _Lector["SegundoNombre"].ToString();
                string Email = _Lector["Email"].ToString();
                string Rol = _Lector["Rol"].ToString();

                _Usuarios.Add(new DatosUsuarioItem
                {
                    Id = Id,
                    Usuario = Usuario,
                    Clave = Clave,
                    PrimerNombre = PrimerNombre,
                    SegundoNombre = SegundoNombre,
                    Email = Email,
                    Rol = Rol
                });
            }

            _Conexion.ConexionCerrar();

            return _Usuarios;
        }

        public List<FormatoTurnos> TurnoCargarAdmin()
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargarAdmin";
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

            _Conexion.ConexionCerrar();

            return _Valores;
        }

        public void AdminModificarUsuario(int idUsuario, string rol)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminModificarUsuario";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            _Comando.Parameters.AddWithValue("@rol", rol);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void AdminGuardarDisponibilidad(int idUsuario, int horarioInicio, int horarioFin)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminGuardarDisponibilidad";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            _Comando.Parameters.AddWithValue("@horarioInicio", horarioInicio);
            _Comando.Parameters.AddWithValue("@horarioFin", horarioFin);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

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

        public void AdminGuardarProveedor(int idTurno, string nombreProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminGuardarProveedor";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idTurno", idTurno);
            _Comando.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void AdminGuardarModificacion(int idTurno, int idAdmin, int idCliente, string diaNombre, string diaNumero, string mes, string anio, string nombreProveedor)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminGuardarModificacion";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idTurno", idTurno);
            _Comando.Parameters.AddWithValue("@idAdmin", idAdmin);
            _Comando.Parameters.AddWithValue("@idCliente", idCliente);
            _Comando.Parameters.AddWithValue("@diaNombre", diaNombre);
            _Comando.Parameters.AddWithValue("@diaNumero", diaNumero);
            _Comando.Parameters.AddWithValue("@mes", mes);
            _Comando.Parameters.AddWithValue("@anio", anio);
            _Comando.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

        public void AdminRegistrarUsuario(string nombreUsuario, string clave, string primerNombre, string segundoNombre, string email, string rol)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminRegistrarUsuario";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            _Comando.Parameters.AddWithValue("@clave", clave);
            _Comando.Parameters.AddWithValue("@primerNombre", primerNombre);
            _Comando.Parameters.AddWithValue("@segundoNombre", segundoNombre);
            _Comando.Parameters.AddWithValue("@email", email);
            _Comando.Parameters.AddWithValue("@rol", rol);
            _Comando.ExecuteNonQuery();
            _Comando.Parameters.Clear();
        }

        public void AdminGuardarBajaNotificacion(int idTurno, int idAdmin, int idCliente)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "AdminGuardarBajaNotificacion";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idTurno", idTurno);
            _Comando.Parameters.AddWithValue("@idAdmin", idAdmin);
            _Comando.Parameters.AddWithValue("@idCliente", idCliente);
            _Comando.ExecuteNonQuery();
            _Conexion.ConexionCerrar();
        }

    }
}
