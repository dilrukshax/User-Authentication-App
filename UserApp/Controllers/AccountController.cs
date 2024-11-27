using Microsoft.AspNetCore.Mvc;

namespace UserApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();  
        }
    }
}
