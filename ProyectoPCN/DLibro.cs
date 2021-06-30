using System;
using System.Data;
using Sistema.Entidades;
using Sistema.Datos;
using System.Data.SqlClient;


namespace Sistema.Datos
{
    public class DLibro
    {
        public DataTable Buscar (string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = SistemaDatos.Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor;
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
        public String Actualizar (Libro obj)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = SistemaDatos.Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Comando.Parameters.Add("@Codigo_Libro", SqlDbType.Int).Value = obj.Codigo_libro;
                Comando.Parameters.Add("@Numero_Ejemplares", SqlDbType.Int).Value = obj.Numero_Ejemplares;
                Comando.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = obj.ISBN;
                Comando.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = obj.Titulo;
                Comando.Parameters.Add("@Autor", SqlDbType.VarChar).Value = obj.Autor;
                Comando.Parameters.Add("@Editorial", SqlDbType.VarChar).Value = obj.Editorial;
                Comando.Parameters.Add("@Anno_Edicion", SqlDbType.Int).Value = obj.Anno_Edicion;
                Comando.Parameters.Add("@Numero_Edicion", SqlDbType.Int).Value = obj.Numero_Edicion;
                Comando.Parameters.Add("@Pais", SqlDbType.VarChar).Value = obj.Pais;
                Comando.Parameters.Add("@Idioma", SqlDbType.Int).Value = obj.Idioma;
                Comando.Parameters.Add("@Materia", SqlDbType.VarChar).Value = obj.Materia;
                Comando.Parameters.Add("@Numero_Paginas", SqlDbType.Int).Value = obj.Numero_Paginas;
                Comando.Parameters.Add("@Ubicacion", SqlDbType.VarChar).Value = obj.Ubicacion;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                Comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = obj.Estado;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
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
        public String Eliminar(int Codigo_Libro)
        {

        }
        public string Prestar(int Codigo_Libro)
        {

        }
        public string Devolver(int Codigo_Libro)
        {

        }

        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = SistemaDatos.Conexion.getInstancia().CrearConexion();
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

            public string Insertar(Libro obj)
            {
                string respuesta = "";
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon = SistemaDatos.Conexion.getInstancia().CrearConexion();
                    SqlCommand Comando = new SqlCommand("libros_insertar", SqlCon);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@Numero_Ejemplares", SqlDbType.Int).Value = obj.Numero_Ejemplares;
                    Comando.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = obj.ISBN;
                    Comando.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = obj.Titulo;
                    Comando.Parameters.Add("@Autor", SqlDbType.VarChar).Value = obj.Autor;
                    Comando.Parameters.Add("@Editorial", SqlDbType.VarChar).Value = obj.Editorial;
                    Comando.Parameters.Add("@Anno_Edicion", SqlDbType.Int).Value = obj.Anno_Edicion;
                    Comando.Parameters.Add("@Numero_Edicion", SqlDbType.Int).Value = obj.Numero_Edicion;
                    Comando.Parameters.Add("@Pais", SqlDbType.VarChar).Value = obj.Pais;
                    Comando.Parameters.Add("@Idioma", SqlDbType.Int).Value = obj.Idioma;
                    Comando.Parameters.Add("@Materia", SqlDbType.VarChar).Value = obj.Materia;
                    Comando.Parameters.Add("@Numero_Paginas", SqlDbType.Int).Value = obj.Numero_Paginas;
                    Comando.Parameters.Add("@Ubicacion", SqlDbType.VarChar).Value = obj.Ubicacion;
                    Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                    Comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = obj.Estado;
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
        
    }
}
