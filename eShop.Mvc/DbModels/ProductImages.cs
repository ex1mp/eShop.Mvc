using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DbModels
{
    public class ProductImages
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; private set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public string CatalogImageBase64Data { get; set; }

        public string ImageBase64Data { get; set; }

        public string BreadcumbImageBase64Data { get; set; }
    }
}
