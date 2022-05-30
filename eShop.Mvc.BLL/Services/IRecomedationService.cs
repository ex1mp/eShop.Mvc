using eShop.Mvc.DAL.Entities;

namespace eShop.Mvc.BLL.Services
{
    public interface IRecomedationService
    {
        Task<IEnumerable<Product>> GetMostSuitableProducts(Guid userId, int count);
    }
}
