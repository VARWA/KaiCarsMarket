using Microsoft.AspNetCore.Mvc;

namespace KaiCarsMarket.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
