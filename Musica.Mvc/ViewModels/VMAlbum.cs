using SuperSimple.Core;
using System.Collections.Generic;

namespace ProyectoMVC.ViewModels
{
    public class VMAlbum
    {
        public IEnumerable<Artista> Artistas { get; set; }
        public Album Album { get; set; }
        public int? IdArtistaSeleccionado { get; set; }

        public VMAlbum() => Album = new Album();
        public VMAlbum(IEnumerable<Artista> artistas) : this() => Artistas = artistas;

        public VMAlbum(Album album)
        {
            Album = album;            
        }
    }
}