namespace eShop.Mvc.DbModels
{
    public class CatalogItem
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public int Price { get; set; }

        public int Discount { get; set; }

        public bool IsDeleted { get; set; }
    }
}
