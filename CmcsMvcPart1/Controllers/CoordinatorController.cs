using Microsoft.AspNetCore.Mvc;

namespace CmcsMvcPart1.Controllers
{
    public class CoordinatorController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Verify(string id)
        {
            ViewBag.Message = $"Claim {id} verified (UI-only).";
            return View("Dashboard");
        }

        [HttpPost]
        public IActionResult Reject(string id)
        {
            ViewBag.Message = $"Claim {id} rejected by Coordinator (UI-only).";
            return View("Dashboard");
        }
    }
}
