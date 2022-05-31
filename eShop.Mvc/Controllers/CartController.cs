using eShop.Mvc.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eShop.Mvc.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = _cartService.GetCartItems(new Guid(userId));

            return View(model);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(string productId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _cartService.RemoveProductFromCartAsync(new Guid(userId), new Guid(productId));

            return RedirectToAction("Index", "Cart");
        }

        [HttpPost]
        public async Task<IActionResult> Add(string productId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            await _cartService.AddCartItemAsync(new Guid(userId), new Guid(productId));

            return RedirectToAction("Index", "Product", new { productId = productId });
        }

    }
}
