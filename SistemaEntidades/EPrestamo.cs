using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEntidades
{
    public class EPrestamo
    {
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set;}

        public int DUIEncargado { get; set; }
        public int DUIProfesor { get; set; }
    }
}
