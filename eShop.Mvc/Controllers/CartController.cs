using Microsoft.AspNetCore.Mvc;

namespace eShop.Mvc.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
