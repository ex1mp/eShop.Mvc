using eShop.Mvc.BLL.Models;
using eShop.Mvc.BLL.Services;
using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.DAL.Enums;
using eShop.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Mvc.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICatalogService _catalogService;

        private const int PageSize = 8;

        public CatalogController(ICatalogService catalogService)
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

            using var stream = System.IO.File.Open("C://Users/Mikalay/source/repos/eShop.Mvc/eShop.Mvc/wwwroot/img/placeholder.webp", FileMode.Open);
            using var ms = new MemoryStream();
            stream.CopyTo(ms);

            var img = ms.ToArray();
            string imageBase64Data = Convert.ToBase64String(img);

            string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);


            ViewData["StartYear"] = catalogRequest.StartYear;
            ViewData["EndYear"] = catalogRequest.EndYear;
            ViewData["MinSum"] = catalogRequest.MinSum;
            ViewData["MaxSum"] = catalogRequest.MaxSum;
            ViewData["Genre"] = catalogRequest.Genre;
            ViewData["GameName"] = catalogRequest.GameName;

            var model = new List<ProductSlimViewModel>()
                {
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.R,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 17,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.NC17,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 14,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.PG13,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.PG,
                        ImageDataURL = imageDataURL
                    },
                     new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 17,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.NC17,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 14,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.PG13,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.PG,
                        ImageDataURL = imageDataURL
                    },
                     new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 17,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.NC17,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 14,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.PG13,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.PG,
                        ImageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
                    },
                };
            return View(PaginatedList<ProductSlimViewModel>.Create(products, productsCount, catalogRequest.PageNumber ?? 1, PageSize));
        }
    }
}
