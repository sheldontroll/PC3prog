using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using PC3prog.Models;


namespace PC3prog.Controllers
{
    public class PublicacionesController : Controller
    {
        private readonly PublicacionContext _context;

        public PublicacionesController (PublicacionContext context){
            _context = context;
        }

        public IActionResult NuevaCategoria(){
            ViewBag.Categorias = _context.Categorias.ToList().Select(r => new SelectListItem(r.Nombre, r.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult NuevaCategoria(Categoria r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevaCategoriaConfirmacion");
            }
            return View(r);
        }

        public IActionResult NuevaCategoriaConfirmacion(){
            return View();
        }
    }
}