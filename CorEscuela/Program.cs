using System;
using CorEscuela.Entidades;

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando CorEscuela");
            Escuela platzi = new Escuela
            {
                Nombre = "Platzi Academy",
                pais = "Internet",
                anoCreacion = 2008
            };
            Console.WriteLine($"La escuela se llama {platzi.Nombre}, y se encuentra en {platzi.pais}, y se fundó en el año {platzi.anoCreacion}.");
            Console.WriteLine($"Hagamosla timbrar...");
            platzi.Timbrar();
        }
    }
}