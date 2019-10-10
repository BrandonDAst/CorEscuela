using System.Collections.Generic;

namespace CorEscuela.Entidades
{
    public class Escuela
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Creacion { get; set; }
        public string Pais { get; set; }
        public string Cuidad { get; set; }
        public TiposEscuela Tipo;
        public List<Curso> Cursos { get; set; }

        
        public Escuela(string nombre, TiposEscuela tipo) => (Nombre, Tipo) = (nombre, tipo);//Tuplas
        public Escuela(string nombre, int creacion, string pais, string cuidad, TiposEscuela tipo) => (Nombre, Creacion, Pais, Cuidad, Tipo) = (nombre, creacion, pais, cuidad, tipo);
       

        public override string ToString()
        {
            return $"Nombre:{Nombre} \nTipo:{Tipo}";
        }
    }
}
