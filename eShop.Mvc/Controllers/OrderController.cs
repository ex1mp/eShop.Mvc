using eShop.Mvc.BLL.Services;
using eShop.Mvc.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Mvc.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductService productService;

        public OrderController(IProductService productService )
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            var products = productService.GetNewProducts(3);
            return View(products);
        }
    }
}
