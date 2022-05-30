using eShop.Mvc.DAL.Entities;

namespace eShop.Mvc.BLL.Services
{
    public class RecomedationService : IRecomedationService
    {
        public async Task<IEnumerable<Product>> GetMostSuitableProducts(Guid userId, int count)
        {
            throw new NotImplementedException();
        }
    }
}
