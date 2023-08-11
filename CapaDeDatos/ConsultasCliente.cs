﻿using CapaComun;
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
        private DataTable _Tabla = new DataTable();
        private SqlCommand _Comando = new SqlCommand();
        private List<FormatoTurnos> _Valores = new List<FormatoTurnos>();

        #endregion

        public List<FormatoTurnos> TurnoCargar(int idCliente)
        {
            _Comando.Connection = _Conexion.ConexionAbrir();
            _Comando.CommandText = "TurnoCargar";
            _Comando.CommandType = CommandType.StoredProcedure;
            _Comando.Parameters.AddWithValue("@idCliente", idCliente);

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

    }
}
