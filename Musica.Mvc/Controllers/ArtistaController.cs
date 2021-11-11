using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Core;

namespace ProyectoMVC.Controllers
{
    public class ArtistaController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View(Repositorio.Artistas);

        [HttpGet]
        public IActionResult FormAlta() => View();

        [HttpPost]
        public IActionResult FormAlta(Artista artista)
        {
            Repositorio.AgregarArtista(artista);
            return View("Index", Repositorio.Artistas);
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var artista = Repositorio.GetArtista(id);
            if (artista is null)
            {
                return NotFound();
            }
            return View(artista);
        }
    }
}