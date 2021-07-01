using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistema.Datos;
using SistemaEntidades;

namespace SistemaNegocio
{
    public class NLibro
    {
        public static DataTable Listar()
        {
            DLibro Datos = new DLibro();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DLibro Datos = new DLibro();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(int Numero_Ejemplares, string ISBN, string Titulo, string Autor, string Editorial, int Anno_Edicion, int Numero_Edicion, string Pais, string Idioma, string Materia, int Numero_Paginas, string Ubicacion, string Descripcion, bool Estado)
        {
            DLibro Datos = new DLibro();
            string Existe = Datos.Existe(Titulo);
            if (Existe.Equals("1"))
            {
                Libro obj = new Libro();
                obj.Numero_Ejemplares = Numero_Ejemplares+1;
                obj.ISBN = ISBN;
                obj.Titulo = Titulo;
                obj.Autor = Autor;
                obj.Editorial = Editorial;
                obj.Anno_Edicion = Anno_Edicion;
                obj.Numero_Edicion = Numero_Edicion;
                obj.Pais = Pais;
                obj.Idioma = Idioma;
                obj.Materia = Materia;
                obj.Numero_Paginas = Numero_Paginas;
                obj.Ubicacion = Ubicacion;
                obj.Descripcion = Descripcion;
                obj.Estado = Estado;
                return Datos.Insertar(obj);
            }
            else
            {
                Libro obj = new Libro();
                obj.Numero_Ejemplares = Numero_Ejemplares;
                obj.ISBN = ISBN;
                obj.Titulo = Titulo;
                obj.Autor = Autor;
                obj.Editorial = Editorial;
                obj.Anno_Edicion = Anno_Edicion;
                obj.Numero_Edicion = Numero_Edicion;
                obj.Pais = Pais;
                obj.Idioma = Idioma;
                obj.Materia = Materia;
                obj.Numero_Paginas = Numero_Paginas;
                obj.Ubicacion = Ubicacion;
                obj.Descripcion = Descripcion;
                obj.Estado = Estado;
                return Datos.Insertar(obj);
            }

           

        }
        public static string Actualizar(int Codigo_Libro, int Numero_Ejemplares, string ISBN, string Titulo, string Autor, string Editorial, int Anno_Edicion, int Numero_Edicion, string Pais, string Idioma, string Materia, int Numero_Paginas, string Ubicacion, string Descripcion, bool Estado)
        {
            DLibro Datos = new DLibro();
            string Existe = Datos.Existe(Titulo);
            if (Existe.Equals("1"))
            {
                Libro obj = new Libro();
                obj.Numero_Ejemplares = Numero_Ejemplares + 1;
                obj.ISBN = ISBN;
                obj.Titulo = Titulo;
                obj.Autor = Autor;
                obj.Editorial = Editorial;
                obj.Anno_Edicion = Anno_Edicion;
                obj.Numero_Edicion = Numero_Edicion;
                obj.Pais = Pais;
                obj.Idioma = Idioma;
                obj.Materia = Materia;
                obj.Numero_Paginas = Numero_Paginas;
                obj.Ubicacion = Ubicacion;
                obj.Descripcion = Descripcion;
                obj.Estado = Estado;
                return Datos.Actualizar(obj);
            }
            else
            {
                return "El libro no existe";
            }
        }
        public static string Eliminar (int Codigo_Libro)
        {
            DLibro Datos = new DLibro();
            return Datos.Eliminar(Codigo_Libro);
        }
        public static string Prestar (int Codigo_Libro)
        {
            DLibro Datos = new DLibro();
            return Datos.Prestar(Codigo_Libro);
        }
        public static string Devolver(int Codigo_Libro)
        {
            DLibro Datos = new DLibro();
            return Datos.Devolver(Codigo_Libro);
        }
    }

}
