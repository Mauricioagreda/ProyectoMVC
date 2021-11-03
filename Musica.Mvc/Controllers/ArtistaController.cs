using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Core;

namespace ProyectoMVC.Controllers
{
    public class ArtistaController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View(Repositorio.Artistas);

        
    }
}