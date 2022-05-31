using AutoMapper;
using eShop.Mvc.BLL.Exceptions;
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

        public async Task AddCartItemAsync(Guid userId, Guid productId)
        {
            var exists = _applicationContext.Catalog.Any(x => x.ProductId == productId);

            if (!exists)
            {
                throw new NotFoundException($"product with id = {productId} is not found");
            }

            await _applicationContext.CartItems.AddAsync(new DAL.Entities.CartItem()
            {
                UserId = userId,
                ProductId = productId,
            });

            await _applicationContext.SaveChangesAsync();
        }

        public List<ProductSlimViewModel> GetCartItems(Guid userId)
        {
            var productIds = _applicationContext.CartItems.Where(x => x.UserId == userId).Select(x => x.ProductId);

            if (productIds == null)
            {
                return new List<ProductSlimViewModel>();
            }

            var products = _applicationContext.Catalog.Include(x => x.Product.Images).Include(x => x.Product.Genres).Where(x => productIds.Contains(x.ProductId));

            return _mapper.Map<List<ProductSlimViewModel>>(products);
        }

        public async Task RemoveProductFromCartAsync(Guid userId, Guid productId)
        {
            var item = await _applicationContext.CartItems.FirstOrDefaultAsync(x => x.UserId == userId && x.ProductId == productId);

            if (item == null)
            {
                throw new NotFoundException($"product with id = {productId} is not found");
            }

            _applicationContext.CartItems.Remove(item);
            await _applicationContext.SaveChangesAsync();
        }
    }
}
