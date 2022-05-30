
using eShop.Mvc.BLL.ViewModels;

namespace eShop.Mvc.BLL.Services
{
    public interface ICartService
    {
        List<ProductSlimViewModel> GetCartItems(Guid userId);

        Task RemoveProductFromCart(Guid userId, Guid productId);
    }
}