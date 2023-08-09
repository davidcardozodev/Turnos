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
        private DataTable _Tabla = new DataTable();
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
                });
            }

            _Conexion.ConexionCerrar();

            return _Valores;
        }

    }
}
