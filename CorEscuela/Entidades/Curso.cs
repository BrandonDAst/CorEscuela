using System;
using System.Collections.Generic;
using System.Text;

namespace CorEscuela.Entidades
{
    public class Curso
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre.ToUpper(); }
            set { nombre = value; }
        }
        private int grado;

        public int Grado
        {
            get { return grado; }
            set { grado = value; }
        }


        public Curso(string nombre, int grado) => (Nombre, Grado) = (nombre, grado);

        public override string ToString()
        {
            return $"Curso: {nombre}. Grado: {grado}";
        }
    }
}
