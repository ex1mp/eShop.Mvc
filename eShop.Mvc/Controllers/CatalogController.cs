using eShop.Mvc.BLL.Models;
using eShop.Mvc.BLL.Services;
using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Mvc.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService _catalogService;

        private const int PageSize = 7;

        public CatalogController(IProductService catalogService)
        {
            _catalogService = catalogService;
        }
        public async Task<IActionResult> Index(CatalogRequest catalogRequest)
        {
            if (catalogRequest.IsNewSearch != null && catalogRequest.IsNewSearch == true)
            {
                catalogRequest.PageNumber = 1;
            }

            var products = await _catalogService.GetCatalogProducts(catalogRequest);

            var productsCount = _catalogService.GetCatalogItemsCount();

            ViewData["StartYear"] = catalogRequest.StartYear;
            ViewData["EndYear"] = catalogRequest.EndYear;
            ViewData["MinSum"] = catalogRequest.MinSum;
            ViewData["MaxSum"] = catalogRequest.MaxSum;
            ViewData["Genre"] = catalogRequest.Genre;
            ViewData["GameName"] = catalogRequest.GameName;

            return View(PaginatedList<ProductSlimViewModel>.Create(products, productsCount, catalogRequest.PageNumber ?? 1, PageSize));
        }
    }
}
