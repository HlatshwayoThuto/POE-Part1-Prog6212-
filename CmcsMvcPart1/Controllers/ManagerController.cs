using Microsoft.AspNetCore.Mvc;

namespace CmcsMvcPart1.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Approve(string id)
        {
            ViewBag.Message = $"Claim {id} approved by Manager (UI-only).";
            return View("Dashboard");
        }

        [HttpPost]
        public IActionResult Disapprove(string id)
        {
            ViewBag.Message = $"Claim {id} disapproved by Manager (UI-only).";
            return View("Dashboard");
        }
    }
}
