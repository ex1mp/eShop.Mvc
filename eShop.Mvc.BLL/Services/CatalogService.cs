using AutoMapper;
using eShop.Mvc.BLL.Models;
using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.DAL;
using Microsoft.EntityFrameworkCore;

namespace eShop.Mvc.BLL.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ApplicationContext _aplicationContext;
        private readonly IMapper _mapper;

        public CatalogService(ApplicationContext aplicationContext, IMapper mapper)
        {
            _aplicationContext = aplicationContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductSlimViewModel>> GetCatalogProducts(CatalogRequest request)
        {
            var query = _aplicationContext.Catalog.Include(x => x.Product).Include(x => x.Product.Images).Include(x => x.Product.Genres).Include(x => x.Product.Languages).Where(x => !x.IsDeleted).AsQueryable();

            if (request.EndYear != default)
            {
                query.Where(x => x.Product.ReleaseDate.Year < request.EndYear);
            }

            if (request.StartYear != default)
            {
                query.Where(x => x.Product.ReleaseDate.Year > request.StartYear);
            }

            if (request.Genre != default)
            {
                query.Where(x => x.Product.Genres.Any(x => x.Name.Equals(request.Genre, StringComparison.InvariantCultureIgnoreCase)));
            }

            if (request.GameName != default)
            {
                query.Where(x => x.Product.Name.Equals(request.GameName, StringComparison.InvariantCultureIgnoreCase));
            }

            if (request.MinSum != default)
            {
                query.Where(x => x.Price > request.MinSum);
            }

            if (request.MaxSum != default)
            {
                query.Where(x => x.Price < request.MaxSum);
            }

            var products = await query.ToListAsync();

            return _mapper.Map<IEnumerable<ProductSlimViewModel>>(products);
        }

        public async Task<IEnumerable<ProductSlimViewModel>> GetLastSaledProducts()
        {
            var products = _aplicationContext.Orders.OrderBy(x => x.DateTime).Take(5).Select(x => x.Product).Include(x => x.Images);

            return _mapper.Map<IEnumerable<ProductSlimViewModel>>(products);
        }

        public async Task<IEnumerable<ProductSlimViewModel>> GetSales40PercentProducts()
        {
            var query = _aplicationContext.Catalog.Include(x => x.Product).Include(x => x.Product.Images).Where(x => !x.IsDeleted).AsQueryable();

            query.Where(x => x.Discount > 40).Take(5);

            return _mapper.Map<IEnumerable<ProductSlimViewModel>>(query);
        }

        public async Task<IEnumerable<ProductSlimViewModel>> GetNewProducts()
        {
            var query = _aplicationContext.Catalog.Include(x => x.Product).Include(x => x.Product.Images).Where(x => !x.IsDeleted).AsQueryable();

            query.OrderBy(x => x.Product.ReleaseDate).Take(8);

            return _mapper.Map<IEnumerable<ProductSlimViewModel>>(query);
        }

        public async Task<IEnumerable<ProductBreadcumbViewModel>> GetRecomendedProducts(Guid? userId)
        {
            if (userId != null)
            {
                // take from recomendation system
            }

            var query = _aplicationContext.Orders.GroupBy(x => x.ProductId).OrderByDescending(x => x.Count()).Select(x => x.First().Product).Include(x => x.Images).Take(5);

            return _mapper.Map<IEnumerable<ProductBreadcumbViewModel>>(query);
        }

        public int GetCatalogItemsCount()
        {
            return _aplicationContext.Catalog.Count();
        }
    }
}
