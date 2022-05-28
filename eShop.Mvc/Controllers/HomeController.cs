using eShop.Mvc.DAL;
using eShop.Mvc.Models;
using eShop.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eShop.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationContext applicationContext)
        {
            //applicationContext.Genres.ToArray();
            _logger = logger;
        }

        public IActionResult Index()
        {
            using var stream = System.IO.File.Open("C://Users/Mikalay/source/repos/eShop.Mvc/eShop.Mvc/wwwroot/img/placeholder.webp", FileMode.Open);
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
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.R,
                        imageDataURL = imageDataURL
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
                        AgeRating = Enums.AgeRating.NC17,
                        imageDataURL = imageDataURL
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
                        AgeRating = Enums.AgeRating.PG13,
                        imageDataURL = imageDataURL
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
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
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
                        AgeRating = Enums.AgeRating.PG,
                        imageDataURL = imageDataURL
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
                    },
                },
                Sells40ProcentProducts =new List<ProductSlimViewModel>()
                {
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 55,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 55,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 55,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 55,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 55,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
                    },
                },
                LastSales = new List<ProductSlimViewModel>()
                {
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 55,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 55,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 55,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                        ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 55,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.G,
                        imageDataURL = imageDataURL
                    },
                    new ProductSlimViewModel
                    {
                       ProductName = "Game",
                        Price = 25,
                        DiscountAmount = 55,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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
                        AgeRating = Enums.AgeRating.G,
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