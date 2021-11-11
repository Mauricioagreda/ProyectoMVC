using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Core;

namespace ProyectoMVC.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Index() => View(Repositorio.Albumes);
        
        public IActionResult Detalle(int id)
        {
            var album = Repositorio.GetAlbum(id);
            if (album is null)
            {
                return NotFound();
            }
            return View(album);
        }

        [HttpGet]
        public IActionResult FormAlta(int? idArtista)
        {
            var vmAlbum = new VMAlbum(Repositorio.album)
            {
                IdArtistaSeleccionado = idArtista
            };
            return View(vmAlbum);
        }

        [HttpPost]
        public IActionResult FormAlta(VMAlbum vMAlbum)
        {
            if (Validar(vMAlbum))
            {
                var artista = Repositorio.GetArtista(vMAlbum.IdArtistaSeleccionado.Value);
                artista.AgregarAlbum(vMAlbum.album);
                Repositorio.AgregarAlbum(vMAlbum.Album);
            }
            return View("Index", Repositorio.Albumes);
        }
    }
}