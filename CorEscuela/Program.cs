using CorEscuela.Entidades;
using System;

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo.");
            Escuela escuela = new Escuela("Escuelita", TiposEscuela.Kinder);
            Console.WriteLine(escuela);
        }
    }
}