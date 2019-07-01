using System;

namespace CorEscuela
{
    public class Escuela
    {
        public string nombre;
        public string direccion;
        public int anoFundacion;
        public void Timbrar()
        {
            //Todo
            Console.Beep(1000, 5000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando CorEscuela");
            Escuela platzi = new Escuela
            {
                nombre = "Platzi Academy",
                direccion = "Internet",
                anoFundacion = 2008
            };
            Console.WriteLine($"La escuela se llama {platzi.nombre}, y se encuentra en {platzi.direccion}, y se fundó en el año {platzi.anoFundacion}.");
            Console.WriteLine($"Hagamosla timbrar...");
            platzi.Timbrar();
        }
    }
}