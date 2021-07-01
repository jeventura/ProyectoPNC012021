namespace SistemaEntidades
{
    public class Libro
    {
        public int idpersona { get; set; }
        public int Codigo_Libro { get; set; }
        public int Numero_Ejemplares { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Anno_Edicion { get; set; }
        public int Numero_Edicion { get; set; }
        public string Pais { get; set; }
        public string Idioma { get; set; }
        public string Materia { get; set; }
        public int Numero_Paginas { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
