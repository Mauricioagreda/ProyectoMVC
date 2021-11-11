using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Core;

namespace ProyectoMVC.Controllers
{
    public class CancionController : Controller
    {
        public IActionResult Index() => View(Repositorio.Canciones);
        
        public IActionResult Detalle(int id)
        {
            var cancion = Repositorio.GetCancion(id);
            if (cancion is null)
            {
                return NotFound();
            }
            return View(cancion);
        }

        [HttpGet]
        public IActionResult FormAlta(int? idAlbum)
        {
            var vmCancion = new VMCancion(Repositorio.cancion)
            {
                IdAlbumSeleccionado = idAlbum
            };
            return View(vmCancion);
        }

        [HttpPost]
        public IActionResult FormAlta(VMCancion vMCancion)
        {
            if (Validar(vMCancion))
            {
                var album = Repositorio.GetAlbum(vMCancion.IdAlbumSeleccionado.Value);
                album.AgregarCanncion(vMCancion.cancion);
                Repositorio.AgregarCancion(vMCancion.Cancion);
            }
            return View("Index", Repositorio.Cancion);
        }
    }
}