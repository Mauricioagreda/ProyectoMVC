using System;

namespace Musica.Core
{
    public class Cancion
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public Album Album {get; set;} 

        public Cancion(string nombre)
        {
            Nombre = nombre;
        }
        
    }
}
