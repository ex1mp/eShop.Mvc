using eShop.Mvc.DAL.Enums;

namespace eShop.Mvc.BLL.ViewModels
{
    public class ProductSlimViewModel
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public int DiscountAmount { get; set; }

        public List<string> Genres { get; set; }

        public AgeRating AgeRating { get; set; }

        public string ImageDataURL { get; set; }
    }
}
