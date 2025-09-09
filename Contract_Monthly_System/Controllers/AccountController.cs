using Contract_Monthly_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_System.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save user (e.g., EF Core later)
                return RedirectToAction("Login");
            }

            return View(user);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            // ⚠ For now: no DB. Just redirect by role.
            if (user.Role == "Lecturer")
            {
                return RedirectToAction("SubmitClaim", "Lecturer");
            }
            else if (user.Role == "Coordinator")
            {
                return RedirectToAction("Review", "Coordinator");
            }

            // If no match → back to login
            ModelState.AddModelError("", "Invalid role or login failed.");
            return View(user);
        }
    }
}
