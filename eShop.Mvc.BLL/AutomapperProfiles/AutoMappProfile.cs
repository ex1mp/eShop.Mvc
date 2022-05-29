using AutoMapper;
using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.DAL.Entities;

namespace eShop.Mvc.BLL.AutomapperProfiles
{
    public class AutoMappProfile : Profile
    {
        public AutoMappProfile()
        {
            CreateMap<CatalogItem, ProductSlimViewModel>().ForMember(v => v.ProductId, x => x.MapFrom(i => i.ProductId))
                .ForMember(v => v.ProductName, x => x.MapFrom(i => i.Product.Name))
                .ForMember(v => v.Price, x => x.MapFrom(i => i.Price))
                .ForMember(v => v.DiscountAmount, x => x.MapFrom(i => i.Discount))
                .ForMember(v => v.Genres, x => x.MapFrom(i => i.Product.Genres.Select(x => x.Name).ToList()))
                .ForMember(v => v.AgeRating, x => x.MapFrom(i => i.Product.AgeRating))
                .ForMember(v => v.ImageDataURL, x => x.MapFrom(i => i.Product.Images.CatalogImageDataURL));

            CreateMap<CatalogItem, ProductViewModel>().ForMember(v => v.ProductId, x => x.MapFrom(i => i.ProductId))
                .ForMember(v => v.ProductName, x => x.MapFrom(i => i.Product.Name))
                .ForMember(v => v.Price, x => x.MapFrom(i => i.Price))
                .ForMember(v => v.DiscountAmount, x => x.MapFrom(i => i.Discount))
                .ForMember(v => v.Genres, x => x.MapFrom(i => i.Product.Genres.Select(x => x.Name).ToList()))
                .ForMember(v => v.AgeRating, x => x.MapFrom(i => i.Product.AgeRating))
                .ForMember(v => v.ImageDataURL, x => x.MapFrom(i => i.Product.Images.ImageDataURL))
                .ForMember(v => v.SystemRequirments, x => x.MapFrom(i => i.Product.SystemRequirments))
                .ForMember(v => v.Languages, x => x.MapFrom(i => i.Product.Languages.Select(x => x.Name).ToList()))
                .ForMember(v => v.Description, x => x.MapFrom(i => i.Product.Description))
                .ForMember(v => v.ReleaseDate, x => x.MapFrom(i => new DateOnly(i.Product.ReleaseDate.Year, i.Product.ReleaseDate.Month, i.Product.ReleaseDate.Day)))
                .ForMember(v => v.Developer, x => x.MapFrom(i => i.Product.Developer.Name))
                .ForMember(v => v.Publisher, x => x.MapFrom(i => i.Product.Publisher.Name));

            CreateMap<CatalogItem, ProductBreadcumbViewModel>().ForMember(v => v.ProductId, x => x.MapFrom(i => i.ProductId))
                .ForMember(v => v.ProductName, x => x.MapFrom(i => i.Product.Name))
                .ForMember(v => v.Price, x => x.MapFrom(i => i.Price))
                .ForMember(v => v.DiscountAmount, x => x.MapFrom(i => i.Discount))
                .ForMember(v => v.BreadcumbImageDataURL, x => x.MapFrom(i => i.Product.Images.BreadcumbImageDataURL));
        }
    }
}
