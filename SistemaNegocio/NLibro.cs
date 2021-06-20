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
            DPersona Datos = new DPersona();
            return Datos.Listar();
        }
        public static string Insertar(string nombre, string apellido, int edad, string telefono)
        {
            DPersona Datos = new DPersona();
            Persona objeto = new Persona();
            objeto.nombre = nombre;
            objeto.apellido = apellido;
            objeto.edad = edad;
            objeto.telefono = telefono;
            return Datos.Insertar(objeto);
        }
    }
}
