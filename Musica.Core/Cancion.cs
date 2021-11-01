using System;

namespace Musica.Core
{
    public class Cancion
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public List<Cancion> Canciones { get; set; }

        
    }
}
