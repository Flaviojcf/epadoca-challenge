using Microsoft.AspNetCore.Mvc;

namespace epadoca_challenge.Controllers
{
    public class BakeryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
