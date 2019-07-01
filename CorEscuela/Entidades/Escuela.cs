using System;

namespace CorEscuela.Entidades
{
    public class Escuela
    {
        string nombre { get; set; }
        public string Nombre { 
            get { return nombre; } 
            set { nombre = value; } 
        }
        public int anoCreacion { get; set; }
        public string pais { get; set; }
        public string ciudad { get; set; }

        public Escuela(){

        }

        public void Timbrar(){
            
        }
    }
}