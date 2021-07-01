using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEntidades
{
    public class Profesor
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string pais { get; set; }
        public string idioma { get; set; }
        public int Año { get; set; }
        public int Numeroedicion { get; set; }
        public string Materia { get; set; }
        public string ISBN { get; set; }

        public int NumeroPaginas { get; set; }

        public int Estado = 0;

        public int getEstado()
        {
            return Estado;
        }

        public void setEstado(int estado)
        {
            this.Estado = estado;
        }

        public string Editorial { get; set; }

        public string Pais { get; set; }
        public string Ubicacion { get; set; }

        public string Descripcion { get; set; }

        public string Idioma { get; set; }
    }
}
