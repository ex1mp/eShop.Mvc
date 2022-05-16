namespace eShop.Mvc.DbModels
{
    public class ProductImages
    {
        public Guid ProductId { get; private set; }

        public string CatalogImageBase64Data { get; set; }

        public string ImageBase64Data { get; set; }

        public string BreadcumbImageBase64Data { get; set; }
    }
}
