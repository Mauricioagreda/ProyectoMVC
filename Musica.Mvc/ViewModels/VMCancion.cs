using SuperSimple.Core;
using System.Collections.Generic;

namespace SuperSimple.ViewModels
{
    public class VMCancion
    {
        public IEnumerable<Album> Albumes { get; set; }
        public Cancion Canciones { get; set; }

        public int? IdAlbumSeleccionado { get; set; }
        public VMCancion() => Cancion = new Cancion();
        public VMCancion(IEnumerable<Cancion> canicones) : this() => Albumes = albumes;

        public VMCancion(Cancion cancion)
        {
            Cancion = cancion;            
        }

    }
}