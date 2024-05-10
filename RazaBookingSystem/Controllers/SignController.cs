using Microsoft.AspNetCore.Mvc;

namespace RazaBookingSystem.Controllers
{
    public class SignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
