using CorEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo. Creando nueva escuela");
            Escuela escuelaFull = new Escuela("Escuela vrgs", 2019, "Mexico", "CDMX", TiposEscuela.Universidad);

            List<Curso> cursosPrimaria = new List<Curso>();
            cursosPrimaria.Add(new Curso("Español", 1));
            cursosPrimaria.Add(new Curso("Matemáticas", 2));
            cursosPrimaria.Add(new Curso("Ciencias", 2));

            List<Curso> cursosSecundaria = new List<Curso>();
            cursosSecundaria.Add(new Curso("Calculo", 2));
            cursosSecundaria.Add(new Curso("Álgebra", 2));
            cursosSecundaria.Add(new Curso("Literatura", 3));

            List<Curso> cursosPreparatoria = new List<Curso>();
            cursosPreparatoria.Add(new Curso("Trigonometría", 1));
            cursosPreparatoria.Add(new Curso("Biología", 2));

            List<Curso> cursosFake = new List<Curso>();
            Curso cursoFake = new Curso("Fake", 1);
            cursosFake.Add(cursoFake);

            List<Curso> cursosEscuela = new List<Curso>();
            cursosEscuela.AddRange(cursosPrimaria);
            cursosEscuela.AddRange(cursosSecundaria);
            cursosEscuela.AddRange(cursosPreparatoria);
            cursosEscuela.AddRange(cursosFake);
            
            ImprimirCursos(cursosEscuela);
            
            Console.WriteLine($"Eliminando el curso con el Hash: {cursoFake.GetHashCode()}");
            cursosEscuela.Remove(cursoFake);
            cursosEscuela.RemoveAt(cursosEscuela.Count - 1);
            cursosEscuela.RemoveRange(0, 2);
            cursosEscuela.RemoveAll(
                X => 
                X.Nombre.StartsWith('A') || 
                X.Nombre.StartsWith('B'));

            ImprimirCursos(cursosEscuela);
        }

        private static void ImprimirCursos(List<Curso> cursosEscuela)
        {
            foreach (Curso curso in cursosEscuela)
                Console.WriteLine(curso.ToString());
            Console.WriteLine("--------------");

        }
    }
}