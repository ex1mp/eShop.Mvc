using Microsoft.AspNetCore.Mvc;

namespace eShop.Mvc.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
