using Microsoft.AspNetCore.Mvc;

namespace Proyecto_11_11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return RedirectToAction("Index", "Deposito");
        }
    }
}
