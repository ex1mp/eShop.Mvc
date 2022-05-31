using eShop.Mvc.BLL.Services;
using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.DAL;
using eShop.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace eShop.Mvc.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductService _productService;

        public HomeController(ApplicationContext applicationContext, IProductService productService)
        {
            applicationContext.SaveChanges();
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var homeModel = new HomeViewModel()
            {
                BreadcumbProducts = await _productService.GetRecomendedProductsAsync(userId, 5),
                LastSales = _productService.GetLastSaledProducts(5),
                NewProducts = _productService.GetNewProducts(6),
                Sells40ProcentProducts = _productService.GetProductsOnSales(5, 40),
                SellsLeaders = _productService.GetTopSellers(6),
                UpcomingProducts = _productService.GetUpcomingProducts(6)
            };

            return View(homeModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}