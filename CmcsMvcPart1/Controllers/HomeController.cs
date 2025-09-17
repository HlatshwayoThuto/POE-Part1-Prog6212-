using Microsoft.AspNetCore.Mvc;

namespace CmcsMvcPart1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
