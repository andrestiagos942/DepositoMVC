using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_11_11.Models;
using Proyecto_11_11.Models.Entities;

namespace Proyecto_11_11.Controllers
{
    public class ProductoController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List <Producto> productos = await context.Productos.ToListAsync();

            return View(productos);
        }

        [HttpGet]
        public IActionResult CreateProducto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProducto(Producto producto)
        {
            if (producto != null)
            {
                context.Productos.Add(producto);
                await context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
