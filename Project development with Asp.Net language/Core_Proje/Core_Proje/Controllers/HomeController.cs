using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
