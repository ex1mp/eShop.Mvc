namespace eShop.Mvc.BLL.ViewModels
{
    public class HomeViewModel
    {
        public List<ProductSlimViewModel> NewProducts { get; set; }

        public List<ProductSlimViewModel> SellsLeaders { get; set; }

        public List<ProductSlimViewModel> UpcomingProducts { get; set; }

        public List<ProductSlimViewModel> Sells40ProcentProducts { get; set; }

        public List<ProductSlimViewModel> LastSales { get; set; }

        public List<ProductBreadcumbViewModel> BreadcumbProducts { get; set; }
    }
}
