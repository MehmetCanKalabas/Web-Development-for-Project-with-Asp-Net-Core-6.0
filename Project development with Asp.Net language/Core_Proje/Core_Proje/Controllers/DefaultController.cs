using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index2()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
    }
}
