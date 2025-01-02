using Microsoft.AspNetCore.Mvc;

namespace KaiCarsMarket.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
