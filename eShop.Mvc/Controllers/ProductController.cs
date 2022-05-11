using Microsoft.AspNetCore.Mvc;

namespace eShop.Mvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
