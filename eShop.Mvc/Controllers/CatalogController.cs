using eShop.Mvc.Models;
using eShop.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Mvc.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index(int startYear, int endYear, decimal minSum, decimal maxSum, string genre, string gameName, int? pageNumber, bool? IsNewSearch)
        {
            if (IsNewSearch != null && IsNewSearch == true)
            {
                pageNumber = 1;
            }

            using var stream = System.IO.File.Open("C://Users/Mikalay/source/repos/eShop.Mvc/eShop.Mvc/wwwroot/img/placeholder.webp", FileMode.Open);
            using var ms = new MemoryStream();
            stream.CopyTo(ms);

            var img = ms.ToArray();
            string imageBase64Data = Convert.ToBase64String(img);

            string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);


            ViewData["StartYear"] = startYear;
            ViewData["EndYear"] = endYear;
            ViewData["MinSum"] = minSum;
            ViewData["MaxSum"] = maxSum;
            ViewData["Genre"] = genre;
            ViewData["GameName"] = gameName;

            var pageSize = 8;
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
                };
            return View(PaginatedList<ProductSlimViewModel>.Create(model, 15, pageNumber ?? 1, pageSize));
        }
    }
}
