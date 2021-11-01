using System;

namespace Musica.Core
{
    public class Album
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public List<Cancion> Canciones { get; set; } 

        public Album()
        {
            Canciones = new List<Cancion>();
        }

        public void AgregarCancion(Cancion cancion)
            => Canciones.Add(cancion);
        public void EliminarCancion(Cancion cancion)
            => Cancion.Remove(cancion);
    }
}
