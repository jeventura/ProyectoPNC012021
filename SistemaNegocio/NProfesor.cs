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
        
    }
}
