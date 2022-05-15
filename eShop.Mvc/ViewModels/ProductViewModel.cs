using eShop.Mvc.DbModels;
using eShop.Mvc.Enums;

namespace eShop.Mvc.ViewModels
{
    public class ProductViewModel
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public AvailabilityEnum Availability { get; set; }

        public int Price { get; set; }

        public int DiscountAmount { get; set; }

        public List<string> Genres { get; set; }

        public SystemRequirments SystemRequirments { get; set; }

        public List<string> Languages { get; set; }

        public string Description { get; set; }

        public DateOnly ReleaseDate { get; set; }

        public AgeRating AgeRating { get; set; }

        public string Developer { get; set; }

        public string Publisher { get; set; }
    }
}
