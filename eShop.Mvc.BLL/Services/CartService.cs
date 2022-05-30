using AutoMapper;
using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.DAL;
using Microsoft.EntityFrameworkCore;

namespace eShop.Mvc.BLL.Services
{
    public class CartService : ICartService
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IMapper _mapper;

        public CartService(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }

        public List<ProductSlimViewModel> GetCartItems(Guid userId)
        {
            var productIds = _applicationContext.CartItems.Where(x => x.UserId == userId).Select(x => x.ProductId);

            if (productIds == null)
            {
                return new List<ProductSlimViewModel>();
            }

            var products = _applicationContext.Catalog.Include(x => x.Product.Images).Where(x => productIds.Contains(x.ProductId));

            return _mapper.Map<List<ProductSlimViewModel>>(products);
        }

        public async Task RemoveProductFromCart(Guid userId, Guid productId)
        {
            var item = await _applicationContext.CartItems.FirstOrDefaultAsync(x => x.UserId == userId && x.ProductId == productId);

            if (item == null)
            {
                throw new Exception("Not found");
            }

            _applicationContext.CartItems.Remove(item);
            await _applicationContext.SaveChangesAsync();
        }
    }
}
