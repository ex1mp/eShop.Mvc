
using eShop.Mvc.BLL.ViewModels;

namespace eShop.Mvc.BLL.Services
{
    public interface ICartService
    {
        List<ProductSlimViewModel> GetCartItems(Guid userId);

        Task RemoveProductFromCartAsync(Guid userId, Guid productId);

        Task AddCartItemAsync(Guid userId, Guid productId);
    }
}