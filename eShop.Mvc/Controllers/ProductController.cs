using AutoMapper;
using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.DAL;
using eShop.Mvc.DAL.Entities;
using eShop.Mvc.DAL.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShop.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationContext aplicationContext;
        private readonly IMapper mapper;

        public ProductController(ApplicationContext aplicationContext, IMapper mapper)
        {
            this.aplicationContext = aplicationContext;
            this.mapper = mapper;
        }
        public IActionResult Index(string productId)
        {
            using var stream = System.IO.File.Open("C://Users/Mikalay/source/repos/eShop.Mvc/eShop.Mvc/wwwroot/img/placeholder.webp", FileMode.Open);
            using var ms = new MemoryStream();
            stream.CopyTo(ms);

            var img = ms.ToArray();
            string imageBase64Data = Convert.ToBase64String(img);

            string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
            var model = new ProductViewModel()
            {
                ProductId = new Guid("00000000-0000-0000-0000-000000000000"),
                ProductName = "Game",
                Availability = AvailabilityEnum.Enough,
                Price = 25,
                DiscountAmount = 13,
                Genres = new List<string>()
                {
                    "Action",
                    "Shooter"
                },
                AgeRating = AgeRating.G,
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
                SystemRequirments = new SystemRequirments()
                {
                    Os = "Windows 10",
                    Processor = "INTEL CORE I5-8400 or AMD RYZEN 3 3300X",
                    Ram = "12 GB",
                    GraphicCard = "NVIDIA GEFORCE GTX 1060 3 GB or AMD RADEON RX 580 4 GB",
                    DiretX = "Version 12",
                    Hdd = "60 GB"
                },
                ImageDataURL = imageDataURL

            };
            ViewBag.Model = model;

            var mo = aplicationContext.Catalog.Include(x => x.Product).Include(x => x.Product.Images)
                .Include(x => x.Product.Genres)
                .Include(x => x.Product.Languages)
                .Include(x => x.Product.Publisher)
                .Include(x => x.Product.Developer)
                .Include(x => x.Product.SystemRequirments)
                .FirstOrDefault(x => x.ProductId == new Guid(productId));

            var s = mapper.Map<CatalogItem, ProductViewModel>(mo);
            return View(s);
        }

        [HttpPost]
        public async Task<IActionResult> Post(string productId)
        {

            return RedirectToAction("Index", "Product", productId);
        }

    }
}
