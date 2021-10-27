using System;

namespace Musica.Core
{
    public class Artista
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public List<Album> Albumes { get; set; } 

        public Artista()
        {
            Albumes = new List<Album>();
        }

        
    }
}
