using System;
using System.Collections.Generic;

namespace Musica.Core
{
    public class Repositorio
    {
        static int idArtista = 1; 
        static int idAlbum = 1; 
        static int idCancion = 1;

        static readonly List<Artista> artistas = new List<Artista>();
        public static IEnumerable<Artista> Artistas => artistas;
        public static Artista GetArtista(int id) => artistas.Find(c => c.Id == id);
        public static void AgregarArtistas(Artista artista)
        {
            artista.Id = idArtista++;
            artistas.Add(artista);
        }

        public static void AgregarArtista(Artista artista) => artistas.RemoveAll(c => c.Id == artista.Id);

        //-----------
        public static void AgregarAlbum(Album album)
        {
            album.Id = idAlbum++;
        }
        //public static IEnumerable<Album> album => artistas.SelectMany(c => c.albumes);
        public static IEnumerable<Album> AlbumesDe(int idArtista)
        {
            var artista = GetArtista(idArtista);
            if (artista is null)
            {
                return null;
            }
            return artista.Album;
        }
        public static Album GetAlbum(int id) => Albumes.First(p => p.Id == id);
        
        //-----------
        public static void AgregarCancion(Cancion cancion)
        {
            cancion.Id = idCancion++;
        }
        //public static IEnumerable<Cancion> Canciones => albumes.SelectMany(c => c.Canciones);
        public static IEnumerable<Cancion> CancionDe(int idAlbum)
        {
            var album = GetAlbum(idAlbum);
            if (album is null)
            {
                return null;
            }
            return album.Canciones;
        }
        public static Cancion GetCancion(int id) => Canciones.First(p => p.Id == id);
    }
}
