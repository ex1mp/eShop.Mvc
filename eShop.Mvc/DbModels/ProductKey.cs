namespace eShop.Mvc.DbModels
{
    public class ProductKey
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public string Key { get; set; }

        public bool IsSold { get; set; }
    }
}
