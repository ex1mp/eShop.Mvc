using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.DAL.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace eShop.Mvc.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            using var stream = System.IO.File.Open("C://Users/Mikalay/source/repos/eShop.Mvc/eShop.Mvc/wwwroot/img/placeholder.webp", FileMode.Open);
            using var ms = new MemoryStream();
            stream.CopyTo(ms);

            var img = ms.ToArray();
            string imageBase64Data = Convert.ToBase64String(img);

            string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
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
                };
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(string productId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            return RedirectToAction("Index", "Cart");
        }
    }
}
