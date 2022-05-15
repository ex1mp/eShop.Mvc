using eShop.Mvc.Enums;

namespace eShop.Mvc.ViewModels
{
    public class ProductSlimViewModel
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public int DiscountAmount { get; set; }

        public List<string> Genres { get; set; }

        public AgeRating AgeRating { get; set; }

    }
}
