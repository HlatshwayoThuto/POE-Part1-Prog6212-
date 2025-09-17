using Microsoft.AspNetCore.Mvc;

namespace CmcsMvcPart1.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult CreateClaim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateClaimPost()
        {
            ViewBag.Message = "Claim submitted (UI-only prototype).";
            return View("CreateClaim");
        }
    }
}
