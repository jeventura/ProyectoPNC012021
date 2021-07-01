using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SistemaDatos;
using SistemaEntidades;

namespace SistemaNegocio
{
    public class NProfesor
    {
        public static DataTable Listar()
        {
            DProfesor Datos = new DProfesor();
            return Datos.Listar();
        }
        /*public static string Insertar(string nombre, string apellido, int edad, string telefono)
        {
            DProfesor Datos = new DProfesor();
            Eprofesor objeto = new Eprofesor();
            objeto.nombre = nombre;
            objeto.apellido = apellido;
            objeto.edad = edad;
            objeto.telefono = telefono;
            return Datos.Insertar(objeto);
        }*/
    }
}
