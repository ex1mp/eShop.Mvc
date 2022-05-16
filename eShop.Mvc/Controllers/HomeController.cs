using eShop.Mvc.Models;
using eShop.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eShop.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using var stream = System.IO.File.Open("C://Users/Mikalay/source/repos/eShop.Mvc/eShop.Mvc/wwwroot/img/prototype-2.jpg", FileMode.Open);
            using var ms = new MemoryStream();
            stream.CopyTo(ms);

            var img = ms.ToArray();
            string imageBase64Data = Convert.ToBase64String(img);

            string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);

            var model = new HomeViewModel()
            {
                NewProducts = new List<ProductSlimViewModel>()
                {
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                },
                SellsLeaders = new List<ProductSlimViewModel>()
                {
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                },
                Sells40ProcentProducts =new List<ProductSlimViewModel>()
                {
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                },
                LastSales = new List<ProductSlimViewModel>()
                {
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                },
                UpcomingProducts = new List<ProductSlimViewModel>()
                {
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                },
                BreadcumbProducts = new List<ProductSlimViewModel>()
                {
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R18,
                        imageDataURL = imageDataURL
                    },
                }
            };
            return View(model);
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