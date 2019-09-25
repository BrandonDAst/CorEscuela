namespace CorEscuela.Entidades
{
    public class Escuela
    {
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public byte añoCreacion { get; set; }
        public string pais { get; set; }
        public string cuidad { get; set; }
        public TiposEscuela tipo;

        
        public Escuela(string nombre, TiposEscuela tipo) => (this.nombre) = (nombre);//Tuplas
        public Escuela(string nombre, byte añoCreacion, string pais, string cuidad, TiposEscuela tipo)
        {
            this.nombre = nombre;
            this.añoCreacion = añoCreacion;
            this.pais = pais;
            this.cuidad = cuidad;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return $"Nombre:{nombre} \nTipo:{tipo}";
        }
    }
}
