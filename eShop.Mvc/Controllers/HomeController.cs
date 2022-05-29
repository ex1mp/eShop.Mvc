using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.DAL;
using eShop.Mvc.DAL.Entities;
using eShop.Mvc.DAL.Enums;
using eShop.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eShop.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _applicationContext;

        public HomeController(ILogger<HomeController> logger, ApplicationContext applicationContext)
        {
            //applicationContext.Genres.ToArray();
            _logger = logger;
            _applicationContext = applicationContext;
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
                        DiscountAmount = 13,
                        Genres = new List<string>
                        {
                            "Action",
                            "Strategy"
                        },
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
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
                        AgeRating = AgeRating.G,
                        ImageDataURL = imageDataURL
                    },
                },
                BreadcumbProducts = new List<ProductBreadcumbViewModel>()
                {
                    new ProductBreadcumbViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        BreadcumbImageDataURL = imageDataURL
                    },
                   new ProductBreadcumbViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        BreadcumbImageDataURL = imageDataURL
                    },new ProductBreadcumbViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        BreadcumbImageDataURL = imageDataURL
                    },new ProductBreadcumbViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        BreadcumbImageDataURL = imageDataURL
                    },new ProductBreadcumbViewModel
                    {
                        ProductName = "Gme",
                        Price = 24,
                        DiscountAmount = 13,
                        BreadcumbImageDataURL = imageDataURL
                    },
                }
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            using var stream = System.IO.File.Open("C://Users/Mikalay/source/repos/eShop.Mvc/eShop.Mvc/wwwroot/img/elden-ring.jpg", FileMode.Open);
            using var ms1 = new MemoryStream();
            stream.CopyTo(ms1);

            var img = ms1.ToArray();
            string imageBase64Data = Convert.ToBase64String(img);

            string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);

            using var stream2 = System.IO.File.Open("C://Users/Mikalay/source/repos/eShop.Mvc/eShop.Mvc/wwwroot/img/elden2.png", FileMode.Open);
            using var ms2 = new MemoryStream();
            stream2.CopyTo(ms2);

            var img2 = ms2.ToArray();
            string imageBase64Data2 = Convert.ToBase64String(img2);

            string imageDataURL2 = string.Format("data:image/webp;base64,{0}", imageBase64Data2);

            using var stream3 = System.IO.File.Open("C://Users/Mikalay/source/repos/eShop.Mvc/eShop.Mvc/wwwroot/img/3elden-ring.jpg", FileMode.Open);
            using var ms3 = new MemoryStream();
            stream3.CopyTo(ms3);

            var img3 = ms3.ToArray();
            string imageBase64Data3 = Convert.ToBase64String(img3);

            string imageDataURL3 = string.Format("data:image/png;base64,{0}", imageBase64Data3);

            var product = new Product()
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                Name = "ELDEN RING",
                Genres = new()
                {
                    new Genre()
                    {
                        Name = "RPG"
                    }
                },
                SystemRequirments = new()
                {
                    //ProguctId = new Guid("00000000-0000-0000-0000-000000000001"),
                    Os = "Windows 10",
                    Processor = "INTEL CORE I5-8400 or AMD RYZEN 3 3300X",
                    Ram = "12 GB",
                    GraphicCard = "NVIDIA GEFORCE GTX 1060 3 GB or AMD RADEON RX 580 4 GB",
                    DiretX = "Version 12",
                    Hdd = "60 GB"
                },
                Languages = new()
                {
                    new Language()
                    {
                        Name ="English"
                    }
                },
                Description = @"<p>Arise, quenched soul! Interearth is waiting for its master. May grace lead you to the Ring of Elden.</p>
                <p> Huge world with big losses,
                dangers and huge dungeons where complex intricate structures fit together.Travel,
                reach deadly dangers and rejoice in success.</p>
                <p> You can not only change the appearance of the character,
                but also combine weapons,
                armor and items.Develop your character to your liking.Build muscle or comprehend the mysteries of magic.</p>
                <p> A multi - layered story,
                broken into fragments.An epic drama in which thoughts are presented in the Inter - earth.</p>
                <p> In addition to the multiplayer mode where you connect and join other users,
                there is an asynchronous online mode where you can observe the presence of other players.</p> ",
                ReleaseDate = DateTime.Now,
                AgeRating = AgeRating.NC17,
                Developer = new Company()
                {
                    Name = "FromSoftware Inc."
                },
                Publisher = new Company()
                {
                    Name = "FromSoftware Inc., BANDAI NAMCO Entertainment"
                },
                Images = new()
                {
                    ImageDataURL = imageDataURL,
                    CatalogImageDataURL = imageDataURL2,
                    //ProductId = new Guid("00000000-0000-0000-0000-000000000001"),
                    BreadcumbImageDataURL = imageDataURL3,
                }
            };
            var catl = new CatalogItem()
            {
                IsDeleted = false,
                Discount = 13,
                Price = 35,
                Product = product
            };
            _applicationContext.Add(catl);
            _applicationContext.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}