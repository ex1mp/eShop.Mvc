using eShop.Mvc.DbModels;
using eShop.Mvc.Enums;

namespace eShop.Mvc.ViewModels
{
    public class ProductViewModel : ProductSlimViewModel
    {
        public AvailabilityEnum Availability { get; set; }

        public SystemRequirments SystemRequirments { get; set; }

        public List<string> Languages { get; set; }

        public string Description { get; set; }

        public DateOnly ReleaseDate { get; set; }

        public string Developer { get; set; }

        public string Publisher { get; set; }
    }
}
