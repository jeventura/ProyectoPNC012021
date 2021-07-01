using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SistemaEntidades;
using System.Data.SqlClient;

namespace SistemaDatos
{
    public class DLibro
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_listar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

            public string Insertar(ELibro obj)
            {
                string respuesta = "";
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon = Conexion.GetInstancia().CrearConexion();
                    SqlCommand Comando = new SqlCommand("libros_insertar", SqlCon);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = obj.ISBN;
                    Comando.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = obj.Titulo;
                    Comando.Parameters.Add("@Autor", SqlDbType.Int).Value = obj.Autor;
                    Comando.Parameters.Add("@Editorial", SqlDbType.VarChar).Value = obj.Editorial;
                    Comando.Parameters.Add("@Anno_Edicion", SqlDbType.Int).Value = obj.Año;
                    Comando.Parameters.Add("@Numero_Edicion", SqlDbType.Int).Value = obj.Numeroedicion;
                    Comando.Parameters.Add("@Pais", SqlDbType.VarChar).Value = obj.Pais;
                    Comando.Parameters.Add("@Idioma", SqlDbType.VarChar).Value = obj.idioma;
                    Comando.Parameters.Add("@Materia", SqlDbType.VarChar).Value = obj.Materia;
                    Comando.Parameters.Add("@Numero_Paginas", SqlDbType.Int).Value = obj.NumeroPaginas;
                    Comando.Parameters.Add("@Ubicacion", SqlDbType.VarChar).Value = obj.Ubicacion;
                    Comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = 0;


                SqlCon.Open();
                    respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
                }
                catch (Exception e)
                {
                    respuesta = e.Message;
                }
                finally
                {
                    if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
                }
                return respuesta;
            }

        public DataTable Buscar(string titulo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor",SqlDbType.VarChar).Value = titulo;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }
        
    }
}
