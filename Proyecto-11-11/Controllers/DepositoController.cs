using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_11_11.Models;
using Proyecto_11_11.Models.Entities;

namespace Proyecto_11_11.Controllers
{
    public class DepositoController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List <Deposito> Depositos = await context.Depositos.ToListAsync();

            return View(Depositos);
        }

        [HttpGet]
        public IActionResult CreateDeposito()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeposito(Deposito deposito)
        {
            if(deposito != null)
            {
                context.Depositos.Add(deposito);
                await context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
