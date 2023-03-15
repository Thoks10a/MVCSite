using Microsoft.AspNetCore.Mvc;
using MVCSite.Models;
using System.Diagnostics;

namespace MVCSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // Startup inicia o Home e o Index (Pagina principal da home)
        {
            return View();
        }

        public IActionResult Privacy() // Pagina de privacidade
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() // Pagina de erro
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}