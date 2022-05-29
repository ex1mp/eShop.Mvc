using eShop.Mvc.BLL.Models;
using eShop.Mvc.BLL.ViewModels;

namespace eShop.Mvc.BLL.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<ProductSlimViewModel>> GetCatalogProducts(CatalogRequest request);
        int GetCatalogItemsCount();
    }
}