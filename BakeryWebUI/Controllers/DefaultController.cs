using Microsoft.AspNetCore.Mvc;

namespace BakeryWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
