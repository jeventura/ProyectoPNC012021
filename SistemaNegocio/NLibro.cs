using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SistemaDatos;
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
        public static string Insertar(string Titulo, string Autor, string pais, string idioma, int Año, int Numeroedicion, string Materia, string ISBN, string ubicacion, int NumeroPaginas, string Descripcion)
        {
            DLibro Datos = new DLibro();
            ELibro objeto = new ELibro();
            objeto.Titulo = Titulo;
            objeto.Autor = Autor;
            objeto.Pais = pais;
            objeto.Idioma = idioma;
            objeto.Año = Año;
            objeto.Numeroedicion = Numeroedicion;
            objeto.Materia = Materia;
            objeto.ISBN = ISBN;
            objeto.Ubicacion = ubicacion;
            objeto.Descripcion = Descripcion;
            objeto.NumeroPaginas = NumeroPaginas;
            return Datos.Insertar(objeto);
        }

        public static DataTable Buscar(string titulo)
        {
            DLibro Datos = new DLibro();
            return Datos.Buscar(titulo);

        }
    }
}
