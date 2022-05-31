using AutoMapper;
using eShop.Mvc.BLL.Models;
using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.DAL;
using eShop.Mvc.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShop.Mvc.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationContext _aplicationContext;
        private readonly IMapper _mapper;
        private readonly IRecomedationService _recomedationService;

        public ProductService(ApplicationContext aplicationContext, IMapper mapper, IRecomedationService recomedationService)
        {
            _aplicationContext = aplicationContext;
            _mapper = mapper;
            _recomedationService = recomedationService;
        }

        public async Task<List<ProductSlimViewModel>> GetCatalogProductsAsync(CatalogRequest request)
        {
            var query = _aplicationContext.Catalog.Include(x => x.Product).Include(x => x.Product.Images).Include(x => x.Product.Genres).Include(x => x.Product.Languages).Where(x => !x.IsDeleted).AsQueryable();

            if (request.EndYear != default)
            {
                query = query.Where(x => x.Product.ReleaseDate.Year < request.EndYear);
            }

            if (request.StartYear != default)
            {
                query = query.Where(x => x.Product.ReleaseDate.Year > request.StartYear);
            }

            if (request.Genre != default)
            {
                query = query.Where(x => x.Product.Genres.Any(x => x.Name.Equals(request.Genre, StringComparison.InvariantCultureIgnoreCase)));
            }

            if (request.GameName != default)
            {
                query = query.Where(x => x.Product.Name.Equals(request.GameName, StringComparison.InvariantCultureIgnoreCase));
            }

            if (request.MinSum != default)
            {
                query = query.Where(x => x.Price > request.MinSum);
            }

            if (request.MaxSum != default)
            {
                query = query.Where(x => x.Price < request.MaxSum);
            }

            var products = await query.ToListAsync();

            return _mapper.Map<IEnumerable<ProductSlimViewModel>>(products).ToList();
        }

        public ProductViewModel? GetproductById (Guid productId)
        {
            var product = _aplicationContext.Catalog.Include(x => x.Product.Images)
                .Include(x => x.Product.Genres)
                .Include(x => x.Product.Languages)
                .Include(x => x.Product.Developer)
                .Include(x => x.Product.Publisher)
                .Include(x => x.Product.SystemRequirments)
                .FirstOrDefault(x => x.ProductId == productId);

            if (product == null)
            {
                return null;
            }

            return _mapper.Map<CatalogItem, ProductViewModel>(product);
        }

        public List<ProductSlimViewModel> GetLastSaledProducts(int count)
        {
            var productsIds = _aplicationContext.Orders.OrderBy(x => x.DateTime).Select(x => x.ProductId).Take(count);
            var products = _aplicationContext.Catalog.Include(x => x.Product.Images).Where(x => productsIds.Contains(x.ProductId));
            return _mapper.Map<List<ProductSlimViewModel>>(products);
        }

        public List<ProductSlimViewModel> GetProductsOnSales(int count, int discount)
        {
            var query = _aplicationContext.Catalog.Include(x => x.Product).Include(x => x.Product.Images).Where(x => !x.IsDeleted).Where(x => x.Discount > discount).Take(count);

            return _mapper.Map<List<ProductSlimViewModel>>(query);
        }

        public List<ProductSlimViewModel> GetNewProducts(int count)
        {
            var query = _aplicationContext.Catalog.Include(x => x.Product).Include(x => x.Product.Images).Include(x => x.Product.Genres).Where(x => !x.IsDeleted).AsQueryable();

            query = query.OrderByDescending(x => x.Product.ReleaseDate).Take(count);

            return _mapper.Map<List<ProductSlimViewModel>>(query);
        }

        public async Task<List<ProductBreadcumbViewModel>> GetRecomendedProductsAsync(string userId, int count)
        {
            IEnumerable<Product> products;

            //if (userId != null)
            //{
            //    products = await _recomedationService.GetMostSuitableProducts(new Guid(userId), count);
            //}
            //else
            {
                products = _aplicationContext.Orders.Include(x => x.Product.Images).GroupBy(x => x.ProductId).OrderByDescending(x => x.Count()).Select(x => x.First().Product).Take(count);
            }

            return _mapper.Map<List<ProductBreadcumbViewModel>>(products);
        }

        public List<ProductSlimViewModel> GetTopSellers(int count)
        {
            var productsIds = _aplicationContext.Orders.GroupBy(x => x.ProductId).OrderByDescending(x => x.Count()).Select(x => x.First().ProductId).Take(count);
            var products = _aplicationContext.Catalog.Include(x => x.Product.Images).Include(x => x.Product.Genres).Where(x => productsIds.Contains(x.ProductId) && !x.IsDeleted);

            return _mapper.Map<List<ProductSlimViewModel>>(products);
        }

        public List<ProductSlimViewModel> GetUpcomingProducts(int count)
        {
            var products = _aplicationContext.Catalog.Include(x => x.Product.Images).Include(x => x.Product.Genres).Where(x => x.Product.ReleaseDate > DateTime.Now).OrderByDescending(x => x.Product.ReleaseDate).Take(count);
            return _mapper.Map<List<ProductSlimViewModel>>(products);
        }

        public int GetCatalogItemsCount()
        {
            return _aplicationContext.Catalog.Where(x => !x.IsDeleted).Count();
        }
    }
}
