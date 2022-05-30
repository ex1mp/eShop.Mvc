using eShop.Mvc.BLL.Models;
using eShop.Mvc.BLL.ViewModels;

namespace eShop.Mvc.BLL.Services
{
    public interface IProductService
    {
        Task<List<ProductSlimViewModel>> GetCatalogProducts(CatalogRequest request);

        Task<List<ProductBreadcumbViewModel>> GetRecomendedProducts(string userId, int count);

        List<ProductSlimViewModel> GetNewProducts(int count);

        List<ProductSlimViewModel> GetProductsOnSales(int count, int discount);

        List<ProductSlimViewModel> GetLastSaledProducts(int count);

        List<ProductSlimViewModel> GetTopSellers(int count);

        List<ProductSlimViewModel> GetUpcomingProducts(int count);

        public ProductViewModel? GetproductById(Guid productId);
        int GetCatalogItemsCount();
    }
}