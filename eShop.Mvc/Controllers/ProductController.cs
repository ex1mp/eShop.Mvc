using eShop.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Mvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string productId)
        {
            using var stream = System.IO.File.Open("C://Users/Mikalay/source/repos/eShop.Mvc/eShop.Mvc/wwwroot/img/elden-ring.jpg", FileMode.Open);
            using var ms = new MemoryStream();
            stream.CopyTo(ms);

            var img = ms.ToArray();
            string imageBase64Data = Convert.ToBase64String(img);

            string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
            var model = new ProductViewModel()
            {
                ProductId = new Guid("00000000-0000-0000-0000-000000000000"),
                ProductName = "ELDEN RING",
                Availability = Enums.AvailabilityEnum.Enough,
                Price = 25,
                DiscountAmount = 13,
                Genres = new List<string>()
                {
                    "Action",
                    "Shooter"
                },
                AgeRating = Enums.AgeRating.R18,
                Languages = new List<string>()
                {
                    "English",
                    "Russian"
                },
                ReleaseDate = new DateOnly(2022, 4, 21),
                Publisher = "FromSoftware Inc., BANDAI NAMCO Entertainment",
                Developer = "FromSoftware Inc.",
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
                SystemRequirments = new DbModels.SystemRequirments()
                {
                    Os = "Windows 10",
                    Processor = "INTEL CORE I5-8400 or AMD RYZEN 3 3300X",
                    Ram = "12 GB",
                    GraphicCard = "NVIDIA GEFORCE GTX 1060 3 GB or AMD RADEON RX 580 4 GB",
                    DiretX = "Version 12",
                    Hdd = "60 GB"
                },
                imageDataURL = imageDataURL

            };

            return View(model);
        }
    }
}
