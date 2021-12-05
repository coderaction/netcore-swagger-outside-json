using Microsoft.AspNetCore.Mvc;

namespace Swagger.Controllers.V1
{
    public class HeroesController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}